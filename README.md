# ScottPlot.NET

This repository contains source code for the ScottPlot Website (ScottPlot.NET)

ScottPlot source code is located in the [ScottPlot repository](https://github.com/scottplot/scottplot)

### Development Environment

* [SiteBuilder](dev/SiteBuilder) is a C# console application that builds the website. It uses the [Statix](https://github.com/swharden/statix) package to convert Markdown to HTML pages based on [template.html](dev/theme/article-single.html).

* [build.bat](dev/localBuild.bat) rebuilds the site with local URLs (http://localhost:8080)

* [serve.bat](dev/localServe.bat) serves the local site using Docker

* The website is automatically built and deployed using GitHub actions