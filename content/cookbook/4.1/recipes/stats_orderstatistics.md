---
Title: "Nth Order Statistics - ScottPlot 4.1 Cookbook"
Description: "The Nth order statistic of a set is the Nth smallest value of the set (indexed from 1)."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/stats_orderstatistics/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Statistics", "Nth Order Statistics"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/statistics", "/cookbook/4.1/recipes/stats_orderstatistics/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/stats_orderstatistics.png"
---

<h2><a id='nth-order-statistics' href='/cookbook/4.1/recipes/stats_orderstatistics/'>Nth Order Statistics</a></h2>

The Nth order statistic of a set is the Nth smallest value of the set (indexed from 1).

```cs
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 500;
double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.Random(rand, pointCount);

int n = 200;
double nthValue = Statistics.Common.NthOrderStatistic(ys, n);

plt.Title($"{n}th Smallest Value (of {pointCount})");
plt.AddScatter(xs, ys, lineWidth: 0, markerShape: MarkerShape.openCircle);
plt.AddHorizontalLine(nthValue, width: 3, style: LineStyle.Dash);

plt.SaveFig("stats_orderStatistics.png");
```

<img src='../../images/stats_orderstatistics.png' class='d-block mx-auto my-5' />


