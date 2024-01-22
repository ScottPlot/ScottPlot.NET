---
Title: "Custom Label - ScottPlot 4.1 Cookbook"
Description: "Value labels above bars can be customized."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/barseries_custom_label/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Series", "Custom Label"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-series", "/cookbook/4.1/recipes/barseries_custom_label/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/barseries_custom_label.png"
---

<h2><a id='custom-label' href='/cookbook/4.1/recipes/barseries_custom_label/'>Custom Label</a></h2>

Value labels above bars can be customized.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

// This is the data we will plot
double[] values = { 10, 23, 13, 7, 9 };

// Create a palette to use for bar and label colors
IPalette myPalette = new ScottPlot.Palettes.Aurora();

// Add a BarSeries to the plot
BarSeries barSeries = plt.AddBarSeries();

// iterate values
for (int i = 0; i < values.Length; i++)
{
    // add a bar to the bar series
    Bar bar = new()
    {
        Value = values[i],
        Position = i,
        FillColor = myPalette.GetColor(i),
        LineColor = Color.Black,
        LineWidth = 1,
    };
    barSeries.Bars.Add(bar);

    // add a label and customize it as desired
    var txt = plt.AddText(values[i].ToString(), i, values[i]);
    txt.Color = myPalette.GetColor(i);
    txt.Font.Alignment = Alignment.LowerCenter;
    txt.Font.Size = 24;
    txt.Font.Bold = true;
}

plt.SetAxisLimits(-1, 5, 0, 30);

plt.SaveFig("barseries_custom_label.png");
```

{{< /code-sp4 >}}

<img src='../../images/barseries_custom_label.png' class='d-block mx-auto my-5' />


