---
Title: "Cleveland Dot Plot - ScottPlot 4.1 Cookbook"
Description: "Cleveland Dot Plots allow comparing two categories in situations where a Bar Plot may be crowded."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/bar_cleveland_dot/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Graph", "Cleveland Dot Plot"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-graph", "/cookbook/4.1/recipes/bar_cleveland_dot/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bar_cleveland_dot.png"
---

<h2><a id='cleveland-dot-plot' href='/cookbook/4.1/recipes/bar_cleveland_dot/'>Cleveland Dot Plot</a></h2>

Cleveland Dot Plots allow comparing two categories in situations where a Bar Plot may be crowded.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

// Data from https://footystats.org/england/premier-league/home-away-league-table
double[] homeWins = { 12, 17, 16, 18, 18 };
double[] awayWins = { 11, 13, 16, 14, 14 };
string[] labels = { "2015/16", "2016/17", "2017/18", "2018/19", "2019/20" };

var clevelandDot = plt.AddClevelandDot(homeWins, awayWins);
clevelandDot.SetPoint1Style(label: "Home Wins");
clevelandDot.SetPoint2Style(label: "Away Wins", markerShape: MarkerShape.triUp);

plt.XTicks(labels);
plt.Title("British Premier League Champion Home vs Away Wins");
plt.Legend();

plt.SaveFig("bar_cleveland_dot.png");
```

{{< /code-sp4 >}}

<img src='../../images/bar_cleveland_dot.png' class='d-block mx-auto my-5' />


