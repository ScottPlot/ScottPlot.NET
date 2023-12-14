// TODO: use a data attribute or dataset on the modal for this
let matchingRecipeClassNames = ""; // CSV list of recipes currently listed in the modal

/* return a search modal and special div that can show search results */
function GetSearchHtml() {
    return `
    <style>
    #search-input-wrapper input {
        border: none;
    }
    
    #search-input-wrapper input:focus {
        outline: none;
    }
    
    pre code {
        background-color: #EEE !important;
    }
    
    img {
        max-width: 100%;
    }
    </style>
    
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/highlight.js/11.9.0/styles/vs.min.css">

    <!-- Button trigger modal -->
    <div class="m-5 text-center">
        <button type="button" class="btn btn-primary" data-bs-toggle="modal" data-bs-target="#exampleModal">
            🔎 Search ScottPlot 5.0 Cookbook
        </button>
    </div>
    
    <div id="div-recipes-full">
        <!-- recipes inserted here using javascript -->
    </div>
    
    <!-- Modal -->
    <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-lg modal-dialog-scrollable">
            <div class="modal-content bg-light">
    
                <!-- search input -->
                <div class="modal-header">
                    <div class="d-flex align-items-center w-100">
                        <div id="search-input-wrapper" class="d-flex align-items-center w-100 rounded p-2 bg-white"
                            style="border: 2px solid #712cf9">
                            <svg class="me-2" xmlns="http://www.w3.org/2000/svg" width="24" height="24"
                                fill="currentColor" class="bi bi-search" viewBox="0 0 16 16">
                                <path
                                    d="M11.742 10.344a6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0" />
                            </svg>
                            <input id="input-recipe-search" class="w-100" placeholder="Search" autocomplete="off">
                        </div>
                    </div>
                </div>
    
                <div class="modal-body pt-0">
                    <div id="div-search-results">
                        <!-- content here is replaced by JavaScript -->
                    </div>
                </div>
    
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Cancel</button>
                    <button type="button" class="btn btn-primary" data-bs-dismiss="modal" id="button-show-all"
                        onclick="ShowAll();">
                        Show All
                    </button>
                </div>
            </div>
        </div>
    </div>
    `;
}

/* returns a div to display inside the search modal for recipes matching the category */
function GetSearchResultsCategoryDiv(recipes, category) {
    const categoryRecipes = recipes.filter(x => x.category == category);
    const listGroup = document.createElement("div");
    listGroup.classList.add("list-group");
    categoryRecipes.forEach(x => listGroup.innerHTML +=
        `<button class="list-group-item list-group-item-action" 
        data-bs-dismiss="modal" onclick="ShowRecipes('${x.recipeClassName}');">${x.name}</a>`);
    const div = document.createElement("div");
    div.innerHTML += `<div class="fw-semibold mt-3">${category}</div>`;
    div.appendChild(listGroup);
    return div;
}

/* returns a div to display on the page for a given recipe */
function GetRecipeDiv(recipe) {
    const div = document.createElement("div");
    const sourceHtml = recipe.source.replace("<", "&lt;").replace(">", "&gt;");
    div.innerHTML = `
        <div class='border m-4 rounded shadow-sm mb-5'>
        <h1 class='px-3 pt-0 mt-2 border-0'>${recipe.name}</h1>
        <div class='ps-3 mb-3'>${recipe.description}</div>
        <div class='ps-3'>Category: <a href='${recipe.categoryUrl}'>${recipe.category}</a></div>
        <div class='ps-3'>Permalink: <a href='${recipe.recipeUrl}'>${recipe.name}</a></div>
        <div class='ps-3'>Source File: <a href='${recipe.sourceUrl}' target='_blank'>${recipe.categoryClassName}.cs</a></div>
        <img src="${recipe.imageUrl}" class="p-3">
        <pre class='m-0 p-0'><code class="language-csharp">${sourceHtml}</code></pre>
        </div>`;
    return div;
}

/* update the search modal results to display only the given recipes */
function UpdateSearchResults(recipes) {

    // update global csv list so all can be added later
    matchingRecipeClassNames = recipes.map(x => x.recipeClassName).join(",");

    // update content of the modal to display the given recipes
    const categories = new Set(recipes.map(x => x.category));
    const div = document.getElementById("div-search-results");
    div.innerHTML = "";
    categories.forEach(category => {
        const divCategoryResults = GetSearchResultsCategoryDiv(recipes, category);
        div.appendChild(divCategoryResults);
    });

    // update the "show all" button based on these new results
    const showAllButton = document.getElementById("button-show-all");
    showAllButton.innerText = `Show All (${recipes.length})`;
}

/* display full recipes on the page described by the CSV list of class names */
function ShowRecipes(recipeClassNames) {
    const el = document.getElementById("div-recipes-full");
    el.innerHTML = "";
    recipeClassNames.split(",").forEach(recipeClassName => {
        const recipe = globalRecipes.filter(x => x.recipeClassName == recipeClassName)[0];
        const recipeDiv = GetRecipeDiv(recipe);
        el.appendChild(recipeDiv);
    });
    hljs.highlightAll();
}

/* return true if the string contains the given substring (case invariant) */
function StringContains(needle, haystack) {
    needle = String(needle).toUpperCase();
    haystack = String(haystack).toUpperCase();
    return haystack.indexOf(needle) != -1;
}

/* Activated with the "show all" button is clicked, display all recipes currently listed in the modal. */
function ShowAll() {
    ShowRecipes(matchingRecipeClassNames);
}

/* returns true if the recipe contains the given term */
function RecipeContains(recipe, needle) {
    return StringContains(needle, recipe.name) || StringContains(needle, recipe.description);
}

/* invoked any time the user types in the search input box in the modal */
function ShowRecipesInModalMatching(searchTerm) {
    const recipes = searchTerm == ""
        ? globalRecipes
        : globalRecipes.filter(x => RecipeContains(x, searchTerm));
    UpdateSearchResults(recipes);
}

/* Run after the page loads to add the modal to the page and wire-up events */
function SetupSearchElements() {

    // replace the loading spinner with the search button and modal
    document.getElementById("div-search").innerHTML = GetSearchHtml();

    // pre-populate the modal with every recipe since no search term is present
    UpdateSearchResults(globalRecipes);

    /* focus on the input box when the modal is launched */
    const myModal = document.getElementById('exampleModal');
    myModal.addEventListener('shown.bs.modal', () => { document.getElementById("input-recipe-search").focus(); })

    /* update the list of matching recipes in the modal as the user types in the input box */
    const searchInput = document.getElementById("input-recipe-search");
    searchInput.oninput = () => ShowRecipesInModalMatching(searchInput.value);
}

fetch("/cookbook/5.0/recipes.json", { cache: "no-store" })
    .then(response => response.json())
    .then(data => {
        globalRecipes = data.recipes;
        SetupSearchElements();
    });