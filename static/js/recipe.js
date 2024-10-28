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

function select_single_button(button) {
    const buttons = button.parentElement.querySelectorAll("button");
    buttons.forEach(x => x.classList.remove("active"));
    buttons.forEach(x => x.classList.add("inactive"));
    button.classList.add("active");
    button.classList.remove("inactive");
}

function recipe_button_console(button) {
    select_single_button(button);
    pre = recipe_reset(button.parentElement.parentElement);
    highlight(pre);
}

function recipe_button_winforms(button) {
    select_single_button(button);
    pre = recipe_reset(button.parentElement.parentElement);
    pre.innerHTML = getControlCode(pre.innerHTML, 'formsPlot1');
    highlight(pre);
}

function recipe_button_wpf(button) {
    select_single_button(button);
    pre = recipe_reset(button.parentElement.parentElement);
    pre.innerHTML = getControlCode(pre.innerHTML, 'WpfPlot1');
    highlight(pre);
}

function recipe_button_other(button) {
    select_single_button(button);
    pre = recipe_reset(button.parentElement.parentElement);
    pre.innerHTML = getControlCode(pre.innerHTML, 'MyPlotControl');
    highlight(pre);
}

/* startup using the console highlighting as if the console button were clicked */
document.querySelectorAll(".recipe-code-container").forEach(el => { pre = recipe_reset(el); highlight(pre); });