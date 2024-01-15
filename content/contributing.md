---
Title: Contributing to ScottPlot
Description: Resources for users who wish to contribute to ScottPlot
date: 2023-12-13
---

# Contributing to ScottPlot

## Pull Requests

**Code contributions are welcome!** Creating an issue to go with each pull request is not required, but it is recommended for topics that would benefit from improved discoverability.

**Seek feedback before opening large pull requests.** Consider [creating an issue](https://github.com/ScottPlot/ScottPlot/issues) to discuss your pull request before investing a lot of work into it. This is an opportunity to ensure your modifications (and their timing) will be consistent with the direction ScottPlot is going, also a good chance to get feedback and suggestions that may improve your implementation.

## Address Questions
**One of the most helpful things members of the open-source community can do** is to lighten the burden on core developers by answering questions in the [ScottPlot Discord](/discord) and [GitHub issues](https://github.com/ScottPlot/ScottPlot/issues). Even if you don't know how to fully answer a question, helping the question asker to more clearly define their question or create a [reproducible code example](/faq/repro/) really helps!

## Ideas for New Contributors

**Add a cookbook recipe** - If you have a code example you think would be useful to include in the [ScottPlot Cookbook](/cookbook/), we welcome contributions for new recipes! Copy one of the adjacent recipe classes and modify it to include your code. As an example, [Here's the source code](https://github.com/ScottPlot/ScottPlot/blob/86b00e00d45709225242cc3e1b58a6c89c5c52a8/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs#L47-L61) for a recipe on the scatter plot page.

**Create a new plot type** - Users can create their own classes that implement `IPlottable` then add them to a plot. See the [Create a Custom Plot Types](/faq/custom-plot-type/) page for details.

**Improve the ScottPlot website** - The [ScottPlot website](/) website has lots of pages, but many of them could benefit from additional information or refinements to the existing language. Most pages have an edit button at the bottom where users can submit changes as pull requests!

**Good first issues** - Good first issues include adding or fixing XML docs, creating new plot types, and adding new color schemes or cookbook recipes. See issues labeled [Good First Issue](https://github.com/ScottPlot/ScottPlot/issues?q=label%3A%22Good+First+Issue%22) (including closed issues) for code contribution ideas aimed at new contributors.