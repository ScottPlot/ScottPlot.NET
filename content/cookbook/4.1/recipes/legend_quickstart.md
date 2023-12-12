---
Title: "Legend Quickstart - ScottPlot 4.1 Cookbook"
Description: "Add labels to plot items, then enable the legend to display a key in the corner of the data area."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/legend_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Legend", "Legend Quickstart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/legend", "/cookbook/4.1/recipes/legend_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/legend_quickstart.png"
---

<h2><a href='/cookbook/4.1/recipes/legend_quickstart/'>Legend Quickstart</a></h2>

Add labels to plot items, then enable the legend to display a key in the corner of the data area.

```cs
var plt = new ScottPlot.Plot(600, 400);

// add a label using the helper methods
plt.AddSignal(Generate.Sin(), label: "sin");

// or add a label manually
var sig2 = plt.AddSignal(Generate.Cos());
sig2.Label = "Second Label";

// enable the legend
plt.Legend();

plt.SaveFig("legend_quickstart.png");
```

<img src='../../images/legend_quickstart.png' class='d-block mx-auto my-5' />

