---
Title: "BarSeries Quickstart - ScottPlot 4.1 Cookbook"
Description: "A BarSeries plot allows each Bar to be created and customized individually."
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/barseries_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Series", "BarSeries Quickstart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-series", "/cookbook/4.1/recipes/barseries_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/barseries_quickstart.png"
---

<h2><a href='/cookbook/4.1/recipes/barseries_quickstart/'>BarSeries Quickstart</a></h2>

A BarSeries plot allows each Bar to be created and customized individually.

```cs
var plt = new ScottPlot.Plot(600, 400);

// Create a collection of Bar objects
Random rand = new(0);
List<ScottPlot.Plottable.Bar> bars = new();
for (int i = 0; i < 10; i++)
{
    int value = rand.Next(25, 100);
    ScottPlot.Plottable.Bar bar = new()
    {
        // Each bar can be extensively customized
        Value = value,
        Position = i,
        FillColor = ScottPlot.Palette.Category10.GetColor(i),
        Label = value.ToString(),
        LineWidth = 2,
    };
    bars.Add(bar);
};

// Add the BarSeries to the plot
plt.AddBarSeries(bars);
plt.SetAxisLimitsY(0, 120);

plt.SaveFig("barseries_quickstart.png");
```

<img src='../../images/barseries_quickstart.png' class='d-block mx-auto my-5' />


