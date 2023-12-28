---
Title: "DateTime Bar Plot - ScottPlot 4.1 Cookbook"
Description: "Bars have a default width of 1.0, but when using DateTime axis this means bars are one day wide. To plot DateTime data you may need to manually set the width of a bar to a desired size (in fractions of a day)."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/bar_datetime/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Graph", "DateTime Bar Plot"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-graph", "/cookbook/4.1/recipes/bar_datetime/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bar_datetime.png"
---

<h2><a id='datetime-bar-plot' href='/cookbook/4.1/recipes/bar_datetime/'>DateTime Bar Plot</a></h2>

Bars have a default width of 1.0, but when using DateTime axis this means bars are one day wide. To plot DateTime data you may need to manually set the width of a bar to a desired size (in fractions of a day).

```cs
var plt = new ScottPlot.Plot(600, 400);

// let's plot 24 hours of data
int pointCount = 24;

// generate some random values
var rand = new Random(0);
double[] values = DataGen.Random(rand, pointCount, 1.0, 2.5);

// space every time point by 1 hour from a starting point
DateTime start = new DateTime(2021, 09, 24, 0, 0, 0);
double[] positions = new double[pointCount];
for (int i = 0; i < pointCount; i++)
    positions[i] = start.AddHours(i).ToOADate();

// display the bar plot using a time axis
var bar = plt.AddBar(values, positions);
plt.XAxis.DateTimeFormat(true);

// indicate each bar width should be 1/24 of a day then shrink sligtly to add spacing between bars
bar.BarWidth = (1.0 / 24) * .8;

// adjust axis limits so there is no padding below the bar graph
plt.SetAxisLimits(yMin: 0);
plt.Layout(right: 20); // add room for the far right date tick

plt.SaveFig("bar_dateTime.png");
```

<img src='../../images/bar_datetime.png' class='d-block mx-auto my-5' />


