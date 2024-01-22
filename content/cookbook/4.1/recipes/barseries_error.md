---
Title: "BarSeries with Error Bars - ScottPlot 4.1 Cookbook"
Description: "Combine a BarSeries plot with an ErrorBar plot to achieve this effect."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/barseries_error/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Series", "BarSeries with Error Bars"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-series", "/cookbook/4.1/recipes/barseries_error/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/barseries_error.png"
---

<h2><a id='barseries-with-error-bars' href='/cookbook/4.1/recipes/barseries_error/'>BarSeries with Error Bars</a></h2>

Combine a BarSeries plot with an ErrorBar plot to achieve this effect.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

// Create and add Bar objects to the plot
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
        LineWidth = 2,
    };
    bars.Add(bar);
};
plt.AddBarSeries(bars);

// Add error bars on top of the BarSeries plot
double[] xs = bars.Select(x => x.Position).ToArray();
double[] xErrs = bars.Select(x => (double)0).ToArray();
double[] ys = bars.Select(x => x.Value).ToArray();
double[] yErrs = bars.Select(x => (double)rand.Next(2, 20)).ToArray();
var err = plt.AddErrorBars(xs, ys, xErrs, yErrs);
err.LineWidth = 2;
err.CapSize = 5;
err.LineColor = Color.Black;

plt.SetAxisLimitsY(0, 120);

plt.SaveFig("barseries_error.png");
```

{{< /code-sp4 >}}

<img src='../../images/barseries_error.png' class='d-block mx-auto my-5' />


