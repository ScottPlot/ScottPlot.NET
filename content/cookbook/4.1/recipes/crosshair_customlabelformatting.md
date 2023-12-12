---
Title: "Custom Label Format - ScottPlot 4.1 Cookbook"
Description: "For ultimate control over crosshair label format you can create a custom formatter function and use that to convert positions to labels. This allows logic to be used to format crosshair labels."
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/crosshair_customlabelformatting/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Crosshair", "Custom Label Format"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-crosshair", "/cookbook/4.1/recipes/crosshair_customlabelformatting/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/crosshair_customlabelformatting.png"
---

<h2><a id='custom-label-format' href='/cookbook/4.1/recipes/crosshair_customlabelformatting/'>Custom Label Format</a></h2>

For ultimate control over crosshair label format you can create a custom formatter function and use that to convert positions to labels. This allows logic to be used to format crosshair labels.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(ScottPlot.DataGen.Sin(51));
plt.AddSignal(ScottPlot.DataGen.Cos(51));

var ch = plt.AddCrosshair(20, 0);

// create a custom formatter as a static class
static string customFormatter(double position)
{
    if (position == 0)
        return "zero";
    else if (position > 0)
        return $"+{position:F2}";
    else
        return $"({Math.Abs(position):F2})";
}

// use the custom formatter for X and Y crosshair labels
ch.HorizontalLine.PositionFormatter = customFormatter;
ch.VerticalLine.PositionFormatter = customFormatter;

// style the plot
plt.Title("Crosshair with Custom Label Formmater");
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

plt.SaveFig("crosshair_customlabelformatting.png");
```

<img src='../../images/crosshair_customlabelformatting.png' class='d-block mx-auto my-5' />


