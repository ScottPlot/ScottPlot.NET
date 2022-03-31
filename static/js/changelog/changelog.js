/* Code here builds a HTML changelog page from a Markdown changelog.
 * References to issues and discussions are converted to links.
 * GitHub usernames are converted to links too.
 * By Scott Harden (www.swharden.com) on 2022-03-30 released under MIT license
 */

class ChangelogPageGenerator {
    constructor(divID, changelogUrl, repoUser, repoProject) {
        this.divID = divID;
        this.repoUser = repoUser;
        this.repoProject = repoProject;
        this.repoUrl = `https://github.com/${repoUser}/${repoProject}`;

        fetch(changelogUrl)
            .then(res => res.text())
            .then(text => this.updateDiv(text));
    }

    updateDiv(markdownText) {
        const lines = markdownText.split("\n");
        const changelogDiv = document.getElementById("changelog");
        changelogDiv.innerHTML = "";
        let headingsShown = 0;
        let contributors = [];
        lines.forEach(line => {
            if (String(line).startsWith("# ")) {
                // ignore top-level headings
            } else if (String(line).startsWith("## ")) {
                if (contributors.length) {
                    changelogDiv.appendChild(this.getContributorIcons(contributors));
                    contributors = [];
                }
                const h = document.createElement("h2");
                h.innerText = String(line).substring(3);
                const firstHeadingOnPage = contributors.length == 0;
                if (headingsShown++ == 0)
                    h.classList.add("mt-0");
                changelogDiv.appendChild(h);
            } else {
                contributors = contributors.concat(this.getAllContributors(line));
                const newDiv = document.createElement("div");
                line = this.markdownLineToHtml(line)
                newDiv.innerHTML = line;
                changelogDiv.appendChild(newDiv);
            }

        });
    }

    compareIgnoreCase(a, b) {
        return a.toLowerCase().localeCompare(b.toLowerCase());
    }

    getContributorIcons(contributors) {

        const frameTemplate = `
            <div class='text-center mt-4'>
                <div class='fs-4 fw-lighter text-center mx-5 px-5'>
                    Special thanks to this version's contributors!
                </div>
                <div class='d-flex justify-content-center flex-wrap'>
                    {{ICONS}}
                </div>
            </div>`;

        const iconTemplate = `
            <div class='bg-light border rounded text-center mx-3 my-2'>
                <div>
                    <a href='https://github.com/{{USER}}'>
                        <img src='https://github.com/{{USER}}.png?size=125' loading='lazy' height='125' width='125'
                            class='img-fluid rounded m-1' />
                    </a>
                </div>
                <div>
                    <a href='https://github.com/{{USER}}'>@{{USER}}</a>
                </div>
            </div>`;

        const usernames = contributors
            .concat("swharden")
            .map(x => x.replace("@", ""))
            .sort(this.compareIgnoreCase);
        const uniqueUsernames = [...new Set(usernames)];
        const iconsHtml = uniqueUsernames.map(username => iconTemplate.replaceAll("{{USER}}", username));
        const frame = document.createElement("section");
        frame.innerHTML = frameTemplate.replace("{{ICONS}}", iconsHtml.join(""));
        return frame;
    }

    markdownLineToHtml(text) {

        if (text.startsWith("* ")) {
            text = "<li> " + text.substring(2).trim() + " </li>";
        }

        if (text.startsWith("  * ")) {
            text = "<li class='ms-4'> " + text.substring(4) + " </li>";
        }

        text = " " + text.trim() + " ";
        text = this.markdownFormatToHtml(text, "_", "i")
        text = this.markdownFormatToHtml(text, "`", "code");
        text = this.markdownFormatToHtml(text, '**', "b");
        text = this.markdownLinksToHtml(text);
        text = this.markdownTagToHtml(text, "#", this.repoUrl + "/issues/");
        text = this.markdownTagToHtml(text, "@", "https://github.com/");
        return text;
    }

    markdownLinksToHtml(text) {
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

    markdownFormatToHtml(text, marker = "*", element = "i") {
        return String(" " + text + " ")
            .replaceAll(` ${marker}`, ` <${element}>`)
            .replaceAll(`${marker} `, `</${element}> `)
            .replaceAll(`${marker},`, `</${element}>,`)
            .replaceAll(`(${marker}`, `(<${element}>`)
            .replaceAll(`${marker})`, `</${element}>)`)
            .replaceAll(`${marker}. `, `</${element}>. `)
            .replaceAll(`.${marker} `, `.</${element}> `)
            .trim();
    }

    getAllContributors(markdownLine) {
        return markdownLine
            .replaceAll("(", " ( ")
            .replaceAll(")", " ) ")
            .replaceAll(",", " , ")
            .replaceAll(">", "> ")
            .replaceAll("<", " <")
            .split(" ")
            .filter(x => x.startsWith("@"))
            .map(x => x.trim())
            .map(x => x.endsWith("_") ? x.substring(0, x.length - 1) : x)
            .map(x => x.endsWith("_") ? x.substring(0, x.length - 1) : x)
            .sort()
            .reverse(); // TODO better sanitization
    }

    markdownTagToHtml(text, char = "@", baseUrl = "https://github.com/") {

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
}