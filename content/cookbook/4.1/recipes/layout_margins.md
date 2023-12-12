---
Title: "Data Margins - ScottPlot 4.1 Cookbook"
Description: "Users who want to define the amount of space around their data can use Margins() to automatically pad data boundaries with a certain percentage of extra space when axis limits are calculated automatically. Note that this operation acts on the axis limits, and does not technically adjust the layout of the plot itself."
Date: 12/11/2023 8:13:09 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/layout_margins/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Layout", "Data Margins"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/layout", "/cookbook/4.1/recipes/layout_margins/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/layout_margins.png"
---

<h2><a id='data-margins' href='/cookbook/4.1/recipes/layout_margins/'>Data Margins</a></h2>

Users who want to define the amount of space around their data can use Margins() to automatically pad data boundaries with a certain percentage of extra space when axis limits are calculated automatically. Note that this operation acts on the axis limits, and does not technically adjust the layout of the plot itself.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");
plt.Title("Plot Title");
plt.Style(figureBackground: Color.SkyBlue);

// 25% horizontal padding means data occupies 75% of horizontal space
// 40% vertical padding means data occupies 60% of vertical space
plt.Margins(x: .25, y: .4);

plt.SaveFig("layout_margins.png");
```

<img src='../../images/layout_margins.png' class='d-block mx-auto my-5' />


