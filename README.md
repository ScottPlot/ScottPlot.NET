# ScottPlot.NET

This repository contains source code for the [ScottPlot.NET](https://scottplot.net) website.

Source code for the ScottPlot package is in the [ScottPlot repository](https://github.com/scottplot/scottplot).

### Development Environment

* [SiteBuilder](dev/SiteBuilder) is a C# console application that builds the website. It uses the [Statix](https://github.com/swharden/statix) package to convert Markdown to HTML pages based on [`template.html`](dev/theme/article-single.html).

* Scripts for building and serving locally are in [`dev/`](dev) 

* The website is automatically built and deployed using GitHub Actions ([`ci.yaml`](.github/workflows/ci.yaml))