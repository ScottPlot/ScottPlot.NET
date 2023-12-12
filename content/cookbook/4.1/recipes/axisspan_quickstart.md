---
Title: "Axis Span - ScottPlot 4.1 Cookbook"
Description: "Axis spans shade a portion of one axis. Axis spans extend to negative and positive infinity on the other axis."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/axisspan_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis Line and Span", "Axis Span"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-axis-line-and-span", "/cookbook/4.1/recipes/axisspan_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/axisspan_quickstart.png"
---

<h2><a href='/cookbook/4.1/recipes/axisspan_quickstart/'>Axis Span</a></h2>

Axis spans shade a portion of one axis. Axis spans extend to negative and positive infinity on the other axis.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// add axis spans
plt.AddVerticalSpan(.15, .85);
plt.AddHorizontalSpan(10, 25);

plt.SaveFig("axisSpan_quickstart.png");
```

<img src='../../images/axisspan_quickstart.png' class='d-block mx-auto my-5' />


