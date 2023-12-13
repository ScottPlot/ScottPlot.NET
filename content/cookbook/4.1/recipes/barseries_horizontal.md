---
Title: "BarSeries Horizontal - ScottPlot 4.1 Cookbook"
Description: "Horizontal orientation can be achieved by customizing the IsVertical property of each Bar."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/barseries_horizontal/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Series", "BarSeries Horizontal"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-series", "/cookbook/4.1/recipes/barseries_horizontal/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/barseries_horizontal.png"
---

<h2><a id='barseries-horizontal' href='/cookbook/4.1/recipes/barseries_horizontal/'>BarSeries Horizontal</a></h2>

Horizontal orientation can be achieved by customizing the IsVertical property of each Bar.

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new(0);
List<ScottPlot.Plottable.Bar> bars = new();
for (int i = 0; i < 10; i++)
{
    int value = rand.Next(25, 100);
    ScottPlot.Plottable.Bar bar = new()
    {
        Value = value,
        Position = i,
        FillColor = ScottPlot.Palette.Category10.GetColor(i),
        Label = value.ToString(),
        IsVertical = false, // ENABLE HORIZONTAL ORIENTATION
    };
    bars.Add(bar);
};

plt.AddBarSeries(bars);
plt.SetAxisLimitsX(0, 120);

plt.SaveFig("barseries_horizontal.png");
```

<img src='../../images/barseries_horizontal.png' class='d-block mx-auto my-5' />


