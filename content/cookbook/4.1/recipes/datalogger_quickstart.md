---
Title: "DataLogger - ScottPlot 4.1 Cookbook"
Description: "A DataLogger is a plot type designed for growing datasets. Unlike most other plot types, the DataLogger can automatically expand the axis limits to accommodate new data as it is added."
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/datalogger_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Data Logger", "DataLogger"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-datalogger", "/cookbook/4.1/recipes/datalogger_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/datalogger_quickstart.png"
---

<h2><a id='datalogger' href='/cookbook/4.1/recipes/datalogger_quickstart/'>DataLogger</a></h2>

A DataLogger is a plot type designed for growing datasets. Unlike most other plot types, the DataLogger can automatically expand the axis limits to accommodate new data as it is added.

```cs
var plt = new ScottPlot.Plot(600, 400);

var logger = plt.AddDataLogger();

for (int i = 0; i < 100; i++)
{
    double x = i * .2;
    double y = Math.Sin(x);
    logger.Add(x, y); // data grows as new data is added
}

plt.SaveFig("datalogger_quickstart.png");
```

<img src='../../images/datalogger_quickstart.png' class='d-block mx-auto my-5' />


