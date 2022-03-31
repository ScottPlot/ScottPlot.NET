/* Code here builds a HTML contributors page from a Markdown changelog.
 * By Scott Harden (www.swharden.com) on 2022-03-30 released under MIT license
 */

class ContributorPageGenerator {
    constructor(divID, changelogUrl) {
        fetch(changelogUrl)
            .then(res => res.text())
            .then(text => this.updateDiv(divID, text));
    }

    updateDiv(divID, text) {
        const mainDiv = document.getElementById(divID);
        const lines = text.split(" ");
        const contributors = new Set();
        lines.forEach(line => {
            const contributorsInLine = this.getAllContributors(line);
            contributorsInLine.forEach(contributor => {
                contributors.add(contributor);
            });
        });

        const usernames = [...contributors]
            .map(x => x.replace("@", ""))
            .sort(this.compareIgnoreCase);

        const mainTemplate = `
            <div class='d-flex justify-content-center flex-wrap'>
            {{ICONS}}
            </div>
        `;

        const iconTemplate = `       
            <div class='bg-light border rounded text-center mx-3 my-2'>
                <div>
                    <a href='https://github.com/{{USER}}'>
                        <img src='https://github.com/{{USER}}.png?size=125' loading='lazy' height='125' width='125' class='img-fluid rounded m-1' />
                    </a>
                </div>
                <div>
                    <a href='https://github.com/{{USER}}'>
                        @{{USER}}
                    </a>
                </div>
            </div>
        `;

        const iconsHtml = usernames.map(username => iconTemplate.replaceAll("{{USER}}", username)).join("");

        mainDiv.innerHTML = mainTemplate.replace("{{ICONS}}", iconsHtml);
    }

    getAllContributors(markdownLine) {
        return markdownLine
            .replaceAll("\n", " ")
            .replaceAll("\r", " ")
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

    compareIgnoreCase(a, b) {
        return a.toLowerCase().localeCompare(b.toLowerCase());
    }
}