---
Title: "Numeric Format String - ScottPlot 4.1 Cookbook"
Description: "Tick labels can be converted to text using a custom format string."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/ticks_numericformatstring/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Numeric Format String"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/ticks_numericformatstring/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ticks_numericformatstring.png"
---

<h2><a id='numeric-format-string' href='/cookbook/4.1/recipes/ticks_numericformatstring/'>Numeric Format String</a></h2>

Tick labels can be converted to text using a custom format string.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// See https://tinyurl.com/y86clj9k to learn about numeric format strings
plt.XAxis.TickLabelFormat("E2", dateTimeFormat: false);
plt.YAxis.TickLabelFormat("P1", dateTimeFormat: false);

plt.SaveFig("ticks_numericFormatString.png");
```

<img src='../../images/ticks_numericformatstring.png' class='d-block mx-auto my-5' />


