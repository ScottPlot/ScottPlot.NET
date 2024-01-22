---
Title: "Customization - ScottPlot 4.1 Cookbook"
Description: "Radar charts support extensive customization options."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/radar_customization/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radar Chart", "Customization"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radar", "/cookbook/4.1/recipes/radar_customization/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radar_customization.png"
---

<h2><a id='customization' href='/cookbook/4.1/recipes/radar_customization/'>Customization</a></h2>

Radar charts support extensive customization options.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[,] values = { { 2, 4, 3 }, { 3, 3, 4 } };
double[] maxValues = { 5, 5, 5 };

var radar = plt.AddRadar(
    values: values,
    independentAxes: false,
    maxValues: maxValues,
    alphafill: 20);

static string CustomLabelFormatter(double position)
{
    return position.ToString("f1");
}

radar.CategoryLabels = new string[] { "Speed", "Velocity", "Strength" };
radar.GroupLabels = new[] { "First try", "Second try" };
radar.Font.Size = 10;
radar.TickValues = new double[] { 1, 2, 3, 4, 5 };
radar.AxisLabelStringFormatter = CustomLabelFormatter;
radar.WebColor = System.Drawing.Color.WhiteSmoke;
radar.LineWidth = 3;

plt.SaveFig("radar_customization.png");
```

{{< /code-sp4 >}}

<img src='../../images/radar_customization.png' class='d-block mx-auto my-5' />


