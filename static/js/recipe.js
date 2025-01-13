function recipe_reset(recipe_code_container) {
    const preElements = recipe_code_container.querySelectorAll("pre");
    const pre_original = preElements[0];
    pre_original.classList.add("collapse");
    const code_dynamic = preElements[1].firstElementChild;
    code_dynamic.innerHTML = pre_original.innerHTML;
    return code_dynamic;
}

function highlight(pre) {
    hljs.configure({ ignoreUnescapedHTML: true });
    delete pre.dataset.highlighted;
    hljs.highlightElement(pre);
}

function getControlCode(original_code, control_name) {
    let lines = original_code.split('\n')
        .filter(line => !line.includes("myPlot.SavePng("))
        .filter(line => !line.includes("ScottPlot.Plot myPlot = new()"));

    // remove empty lines at start
    const firstNonEmptyIndex = lines.findIndex(x => x != "");
    if (firstNonEmptyIndex) {
        lines = lines.slice(firstNonEmptyIndex);
    }

    // remove empty lines at end
    const lastNonEmptyIndex = lines.lastIndexOf("");
    if (lastNonEmptyIndex) {
        lines = lines.slice(0, lastNonEmptyIndex + 1);
    }

    lines.push(`${control_name}.Refresh();`);

    return lines.join("\n").replaceAll("myPlot.", `${control_name}.Plot.`);
}

function highlight_language_tab(recipe_container, name) {
    recipe_container.parentElement.querySelectorAll("button").forEach(button => {
        if (button.innerText == name) {
            button.classList.add("active");
            button.classList.remove("inactive");
        } else {
            button.classList.remove("active");
            button.classList.add("inactive");
        }
    })
}

function set_language(name) {
    localStorage.setItem("startupLanguage", name);
    document.querySelectorAll(".recipe-code-container")
        .forEach(el => {
            pre = recipe_reset(el);
            highlight_language_tab(el, name);
            if (name == "Console") {
                // do nothing
            } else if (name == "WinForms") {
                pre.innerHTML = getControlCode(pre.innerHTML, 'formsPlot1');
            } else if (name == "WPF") {
                pre.innerHTML = getControlCode(pre.innerHTML, 'WpfPlot1');
            } else if (name == "Other") {
                pre.innerHTML = getControlCode(pre.innerHTML, 'MyPlotControl');
            } else {
                console.error("unknown language: " + name)
            }
            highlight(pre);
        });
}

function set_language_button_clicked(button) {
    set_language(button.innerText);
}

function copy_button_clicked(button) {
    const walker = document.createTreeWalker(
        document.body,
        NodeFilter.SHOW_ELEMENT,
        {
            acceptNode: node => node.tagName === 'CODE'
                ? NodeFilter.FILTER_ACCEPT : NodeFilter.FILTER_SKIP
        }
    );
    walker.currentNode = button;
    const codeBlock = walker.nextNode();

    const name = localStorage.getItem("startupLanguage");
    code = "";
    if (name == "Console") {
        code = codeBlock.innerHTML;
    } else if (name == "WinForms") {
        code = getControlCode(codeBlock.innerHTML, 'formsPlot1');
    } else if (name == "WPF") {
        code = getControlCode(codeBlock.innerHTML, 'WpfPlot1');
    } else if (name == "Other") {
        code = getControlCode(codeBlock.innerHTML, 'MyPlotControl');
    } else {
        console.error("unknown language: " + name)
    }

    navigator.clipboard.writeText(code);
}