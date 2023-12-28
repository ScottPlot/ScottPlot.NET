---
Title: "Stacked Bar Plot - ScottPlot 4.1 Cookbook"
Description: "By customizing each Bar of a BarSeries we can achieve a stacked bar plot. Text objects can be added to the plot to serve as labels."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/barseries_stacked/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Series", "Stacked Bar Plot"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-series", "/cookbook/4.1/recipes/barseries_stacked/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/barseries_stacked.png"
---

<h2><a id='stacked-bar-plot' href='/cookbook/4.1/recipes/barseries_stacked/'>Stacked Bar Plot</a></h2>

By customizing each Bar of a BarSeries we can achieve a stacked bar plot. Text objects can be added to the plot to serve as labels.

```cs
var plt = new ScottPlot.Plot(600, 400);

// This is the source data
double[] values = { 10, 23, 13, 7, 9 };
string[] labels = { "North", "East", "South", "West", "Endogenous" };

// Add a BarSeries to the plot
BarSeries barSeries = plt.AddBarSeries();

// Manually add each Bar to the BarSeries
double lastBarTop = 0;
IPalette palette = new ScottPlot.Palettes.Tsitsulin();
for (int i = 0; i < values.Length; i++)
{
    // Determine how high the bar should be
    double barTop = lastBarTop + values[i];
    double barBottom = lastBarTop;
    lastBarTop += values[i];

    // Add a bar to the existing BarSeries
    Bar bar = new()
    {
        Value = barTop,
        ValueBase = barBottom,
        FillColor = palette.GetColor(i),
        LineColor = Color.Black,
        LineWidth = 1,
    };
    barSeries.Bars.Add(bar);

    // Add a text object to the plot to label this bar
    double barMiddle = (barBottom + barTop) / 2;
    var txt = plt.AddText(labels[i], .6, barMiddle);
    txt.Font.Alignment = Alignment.MiddleLeft;
    txt.Font.Size = 16;
    txt.Font.Bold = true;
    txt.Color = bar.FillColor; // match text and bar
}

// Set the axis limits for a pretty figure
plt.SetAxisLimits(-5, 5, -5, 70);

plt.SaveFig("barseries_stacked.png");
```

<img src='../../images/barseries_stacked.png' class='d-block mx-auto my-5' />


