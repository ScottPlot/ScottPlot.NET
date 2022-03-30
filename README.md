# ![](static/images/brand/favicon-32.png) ScottPlot.NET (the website)

* This repository contains source code for the [ScottPlot.NET](https://scottplot.net) website

* Source code for the ScottPlot package is in the [ScottPlot repository](https://github.com/scottplot/scottplot)

### Development Environment

This website uses [Hugo](https://gohugo.io/) to convert Markdown content into HTML files

* Get the [latest Hugo release from GitHub](https://github.com/gohugoio/hugo/releases) and ensure it is in your `PATH`\
  _Binaries are available for Windows, Linux, and MacOS_

* Run `hugo serve` and navigate to http://localhost:1313 to see the site locally

### Deployment

* GitHub Actions builds the Hugo site and deploys it using rsync ([details](https://swharden.com/blog/2022-03-20-github-actions-hugo))