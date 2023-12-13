---
Title: "Defined DateTime Spacing - ScottPlot 4.1 Cookbook"
Description: "This example shows how to use a fixed inter-tick distance for a DateTime axis"
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/ticks_defineddatetimespace/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Defined DateTime Spacing"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/ticks_defineddatetimespace/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ticks_defineddatetimespace.png"
---

<h2><a id='defined-datetime-spacing' href='/cookbook/4.1/recipes/ticks_defineddatetimespace/'>Defined DateTime Spacing</a></h2>

This example shows how to use a fixed inter-tick distance for a DateTime axis

```cs
var plt = new ScottPlot.Plot(600, 400);

// create a series of dates
int pointCount = 20;
double[] dates = new double[pointCount];
var firstDay = new DateTime(2020, 1, 22);
for (int i = 0; i < pointCount; i++)
    dates[i] = firstDay.AddDays(i).ToOADate();

// simulate data for each date
double[] values = new double[pointCount];
Random rand = new Random(0);
for (int i = 1; i < pointCount; i++)
    values[i] = values[i - 1] + rand.NextDouble();

plt.AddScatter(dates, values);
plt.XAxis.DateTimeFormat(true);

// define tick spacing as 1 day (every day will be shown)
plt.XAxis.ManualTickSpacing(1, ScottPlot.Ticks.DateTimeUnit.Day);
plt.XAxis.TickLabelStyle(rotation: 45);

// add some extra space for rotated ticks
plt.XAxis.SetSizeLimit(min: 50);

plt.SaveFig("ticks_definedDateTimeSpace.png");
```

<img src='../../images/ticks_defineddatetimespace.png' class='d-block mx-auto my-5' />


