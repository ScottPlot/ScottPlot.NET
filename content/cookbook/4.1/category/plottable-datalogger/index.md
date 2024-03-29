---
Title: "Plot Type: Data Logger - ScottPlot 4.1 Cookbook"
Description: "The DataLogger plot type facilitates displaying live data by giving the developer a simple way to Add() new data points by either shifting them in or appending them to a growing list. This plot type also has special options to manage axis limits as new data arrives. See code in the WinForms Demo app for advanced usage information."
Date: 2024-01-21
Version: ScottPlot 4.1.71
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Data Logger"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-datalogger/"]
SearchUrl: "/cookbook/4.1/search/"
---

# Plot Type: Data Logger
* This page contains recipes for the _Data Logger_ category.
* Visit the [Cookbook Home Page](../../) to view all cookbook recipes.
* Generated by ScottPlot 4.1.71 on 1/21/2024
<h2><a id='datalogger' href='/cookbook/4.1/recipes/datalogger_quickstart/'>DataLogger</a></h2>

A DataLogger is a plot type designed for growing datasets. Unlike most other plot types, the DataLogger can automatically expand the axis limits to accommodate new data as it is added.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
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

{{< /code-sp4 >}}

<img src='../../images/datalogger_quickstart.png' class='d-block mx-auto my-5' />


<h2><a id='datastreamer' href='/cookbook/4.1/recipes/datastreamer_quickstart/'>DataStreamer</a></h2>

A DataStreamer is a plot type designed for streaming datasets with a fixed length display and even X spacing between Y data points. As new data is shifted in, old data is shifted out, and the displayed trace is always the same size.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

var streamer = plt.AddDataStreamer(length: 20);
streamer.SamplePeriod = 0.2;

for (int i = 0; i < 100; i++)
{
    double y = Math.Sin(i * .2);
    streamer.Add(y); // data remains same length as new data is shifted in
}

// Call different view methods to change the shift behavior
streamer.ViewWipeRight(); // new data overwrites old data left to right
streamer.ViewWipeLeft(); // new data overwrites old data right to left
streamer.ViewScrollRight(); // new data is inserted on the left
streamer.ViewScrollLeft(); // new data is inserted on the right

plt.SaveFig("datastreamer_quickstart.png");
```

{{< /code-sp4 >}}

<img src='../../images/datastreamer_quickstart.png' class='d-block mx-auto my-5' />



