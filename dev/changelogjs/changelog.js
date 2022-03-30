/* Code here builds a HTML changelog page from a Markdown changelog.
 * References to issues and discussions are converted to links.
 * GitHub usernames are converted to links too.
 * By Scott Harden (www.swharden.com) on 2022-03-30 released under MIT license
 */

function markdownLinksToHtml(text) {
    while (text.includes("](")) {
        const centerIndex = text.indexOf("](");
        let firstIndex = centerIndex;
        while (firstIndex-- > 0) {
            if (text.substring(firstIndex, firstIndex + 1) == "[")
                break;
        }
        let lastIndex = centerIndex;
        while (lastIndex++ < text.length) {
            if (text.substring(lastIndex, lastIndex + 1) == ")")
                break;
        }
        const linkMarkdown = text.substring(firstIndex, lastIndex + 1);
        const linkTitle = text.substring(firstIndex + 1, centerIndex);
        const linkUrl = text.substring(centerIndex + 2, lastIndex);
        text = text.replace(linkMarkdown, `<a href='${linkUrl}'>${linkTitle}</a>`);
    }
    return text;
}

function markdownFormatToHtml(text, char, element) {
    let html = " " + String(text) + " ";
    html = text
        .replaceAll(` ${char}`, ` <${element}>`)
        .replaceAll(`${char} `, `</${element}> `)
        .replaceAll(`${char},`, `</${element}>,`)
        .replaceAll(`(${char}`, `(<${element}>`)
        .replaceAll(`${char})`, `</${element}>)`)
        .replaceAll(`${char}. `, `</${element}>. `)
        .replaceAll(`.${char} `, `.</${element}> `)

        // why this no work as argument?
        .replaceAll(" **", "<b>")
        .replaceAll("** ", "</b>")
        .trim()

    if (html.includes("**"))
        console.log(html);

    return html;
}

function markdownTagToHtml(text, char = "@", baseUrl = "https://github.com/") {

    const words = text
        .replaceAll("(", " ( ")
        .replaceAll(")", " ) ")
        .replaceAll(",", " , ")
        .replaceAll(">", "> ")
        .replaceAll("<", " <")
        .split(" ");

    // reverse sort so partial matches don't cause problems
    const tags = words.filter(x => x.startsWith(char)).sort().reverse();
    tags.forEach(tag => {
        const url = baseUrl + tag.substring(1);
        const html = `<a href='${url}'>${tag}</a>`
        text = text.replaceAll(tag, html);
    })

    return text;
}

function markdownLineToHtml(text) {

    if (text.startsWith("* ")) {
        text = "<li> " + text.substring(2).trim() + " </li>";
    }

    if (text.startsWith("  * ")) {
        text = "<li class='ms-4'> " + text.substring(4) + " </li>";
    }

    text = " " + text.trim() + " ";
    text = markdownFormatToHtml(text, "_", "i")
    text = markdownFormatToHtml(text, "`", "code");
    text = markdownFormatToHtml(text, '**', "b");
    text = markdownLinksToHtml(text);
    text = markdownTagToHtml(text, "#", "https://github.com/ScottPlot/ScottPlot/issues/");
    text = markdownTagToHtml(text, "@", "https://github.com/");
    return text;
}

function updateChangelogDiv(markdownText) {
    const lines = markdownText.split("\n");
    const changelogDiv = document.getElementById("changelog");
    changelogDiv.innerHTML = "";

    lines.forEach(line => {
        if (String(line).startsWith("# ")) {
            const h = document.createElement("h1");
            h.innerText = String(line).substring(2);
            changelogDiv.appendChild(h);
        } else if (String(line).startsWith("## ")) {
            const h = document.createElement("h2");
            h.innerText = String(line).substring(3);
            h.classList.add("mt-4");
            changelogDiv.appendChild(h);
        } else {
            const newDiv = document.createElement("div");
            line = markdownLineToHtml(line)
            newDiv.innerHTML = line;
            changelogDiv.appendChild(newDiv);
        }

    });
}

function updateChangelog() {
    fetch("changelog.md")
        .then(res => res.text())
        .then(text => updateChangelogDiv(text))
}