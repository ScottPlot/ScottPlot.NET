---
Title: "Ignore Axis Limits - ScottPlot 4.1 Cookbook"
Description: "Calling Plot.AxisAuto (or middle-clicking the plot) will set the axis limits automatically to fit the data on the plot. By default the position of axis lines and spans are included in automatic axis limit calculations, but setting the '' flag can disable this behavior."
Date: 12/11/2023 8:13:09 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/axisspan_ignore/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis Line and Span", "Ignore Axis Limits"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-axis-line-and-span", "/cookbook/4.1/recipes/axisspan_ignore/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/axisspan_ignore.png"
---

<h2><a id='ignore-axis-limits' href='/cookbook/4.1/recipes/axisspan_ignore/'>Ignore Axis Limits</a></h2>

Calling Plot.AxisAuto (or middle-clicking the plot) will set the axis limits automatically to fit the data on the plot. By default the position of axis lines and spans are included in automatic axis limit calculations, but setting the '' flag can disable this behavior.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

var hline = plt.AddHorizontalLine(0.23);
hline.DragEnabled = true;
hline.IgnoreAxisAuto = true;

var hSpan = plt.AddHorizontalSpan(-10, 20);
hSpan.DragEnabled = true;
hSpan.IgnoreAxisAuto = true;

plt.SaveFig("axisSpan_ignore.png");
```

<img src='../../images/axisspan_ignore.png' class='d-block mx-auto my-5' />


