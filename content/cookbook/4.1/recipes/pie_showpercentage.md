---
Title: "Slice Percentages - ScottPlot 4.1 Cookbook"
Description: "The percentage of each slice can be displayed at its center."
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/pie_showpercentage/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Pie Chart", "Slice Percentages"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-pie", "/cookbook/4.1/recipes/pie_showpercentage/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/pie_showpercentage.png"
---

<h2><a id='slice-percentages' href='/cookbook/4.1/recipes/pie_showpercentage/'>Slice Percentages</a></h2>

The percentage of each slice can be displayed at its center.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 778, 43, 283, 76, 184 };
var pie = plt.AddPie(values);
pie.ShowPercentages = true;

plt.SaveFig("pie_showPercentage.png");
```

<img src='../../images/pie_showpercentage.png' class='d-block mx-auto my-5' />


