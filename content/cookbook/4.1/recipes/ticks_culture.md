---
Title: "Tick Label Culture - ScottPlot 4.1 Cookbook"
Description: "Large numbers and dates are formatted differently for different cultures. Hungarian uses spaces to separate large numbers and periods to separate fields in dates."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/ticks_culture/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Tick Label Culture"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/ticks_culture/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ticks_culture.png"
---

<h2><a id='tick-label-culture' href='/cookbook/4.1/recipes/ticks_culture/'>Tick Label Culture</a></h2>

Large numbers and dates are formatted differently for different cultures. Hungarian uses spaces to separate large numbers and periods to separate fields in dates.

```cs
var plt = new ScottPlot.Plot(600, 400);

// generate some data
double[] price = DataGen.RandomWalk(null, 60 * 8, 10000);
DateTime start = new DateTime(2019, 08, 25, 8, 30, 00);
double pointsPerDay = 24 * 60;

// create the plot
var sig = plt.AddSignal(price, pointsPerDay);
sig.OffsetX = start.ToOADate();

// set the localization
var culture = System.Globalization.CultureInfo.CreateSpecificCulture("hu"); // Hungarian
plt.SetCulture(culture);

// further decorate the plot
plt.XAxis.DateTimeFormat(true);
plt.YAxis.Label("Price");
plt.XAxis.Label("Date and Time");
plt.XAxis2.Label("Hungarian Formatted DateTime Tick Labels");

plt.SaveFig("ticks_culture.png");
```

<img src='../../images/ticks_culture.png' class='d-block mx-auto my-5' />


