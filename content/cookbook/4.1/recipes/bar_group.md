---
Title: "Grouped Bar Graphs - ScottPlot 4.1 Cookbook"
Description: "By customizing positions of multiple bar plots you can achieve the appearance of grouped bar graphs. The AddBarGroups() method is designed to simplify this process. More advanced grouping and bar plot styling is possible using the Population plot type."
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/bar_group/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Bar Graph", "Grouped Bar Graphs"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-bar-graph", "/cookbook/4.1/recipes/bar_group/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/bar_group.png"
---

<h2><a id='grouped-bar-graphs' href='/cookbook/4.1/recipes/bar_group/'>Grouped Bar Graphs</a></h2>

By customizing positions of multiple bar plots you can achieve the appearance of grouped bar graphs. The AddBarGroups() method is designed to simplify this process. More advanced grouping and bar plot styling is possible using the Population plot type.

```cs
var plt = new ScottPlot.Plot(600, 400);

// generate random data to plot
int groupCount = 5;
Random rand = new(0);
double[] values1 = DataGen.RandomNormal(rand, groupCount, 20, 5);
double[] values2 = DataGen.RandomNormal(rand, groupCount, 20, 5);
double[] values3 = DataGen.RandomNormal(rand, groupCount, 20, 5);
double[] errors1 = DataGen.RandomNormal(rand, groupCount, 5, 2);
double[] errors2 = DataGen.RandomNormal(rand, groupCount, 5, 2);
double[] errors3 = DataGen.RandomNormal(rand, groupCount, 5, 2);

// group all data together
string[] groupNames = { "Group A", "Group B", "Group C", "Group D", "Group E" };
string[] seriesNames = { "Series 1", "Series 2", "Series 3" };
double[][] valuesBySeries = { values1, values2, values3 };
double[][] errorsBySeries = { errors1, errors2, errors3 };

// add the grouped bar plots and show a legend
plt.AddBarGroups(groupNames, seriesNames, valuesBySeries, errorsBySeries);
plt.Legend(location: Alignment.UpperRight);

// adjust axis limits so there is no padding below the bar graph
plt.SetAxisLimits(yMin: 0);

plt.SaveFig("bar_group.png");
```

<img src='../../images/bar_group.png' class='d-block mx-auto my-5' />


