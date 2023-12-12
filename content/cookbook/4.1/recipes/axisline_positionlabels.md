---
Title: "Position Labels - ScottPlot 4.1 Cookbook"
Description: "Axis line positions can be labeled on the axis on top of axis ticks and tick labels. Custom position formatters allow for full customization of the text displayed in these labels. If using a DateTime axis, implement a custom formatter that uses DateTime.FromOADate()."
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/axisline_positionlabels/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis Line and Span", "Position Labels"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-axis-line-and-span", "/cookbook/4.1/recipes/axisline_positionlabels/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/axisline_positionlabels.png"
---

<h2><a href='/cookbook/4.1/recipes/axisline_positionlabels/'>Position Labels</a></h2>

Axis line positions can be labeled on the axis on top of axis ticks and tick labels. Custom position formatters allow for full customization of the text displayed in these labels. If using a DateTime axis, implement a custom formatter that uses DateTime.FromOADate().

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

var hline = plt.AddHorizontalLine(.85);
hline.LineWidth = 2;
hline.PositionLabel = true;
hline.PositionLabelBackground = hline.Color;
hline.DragEnabled = true;

var vline = plt.AddVerticalLine(23);
vline.LineWidth = 2;
vline.PositionLabel = true;
vline.PositionLabelBackground = vline.Color;
vline.DragEnabled = true;

Func<double, string> xFormatter = x => $"X={x:F2}";
vline.PositionFormatter = xFormatter;

plt.SaveFig("axisLine_positionLabels.png");
```

<img src='../../images/axisline_positionlabels.png' class='d-block mx-auto my-5' />


