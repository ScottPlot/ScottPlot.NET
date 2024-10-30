---
Title: Box Plot Quickstart - ScottPlot 5.0 Cookbook
Description: Box plots can be created individually and added to the plot.
URL: /cookbook/5.0/Box/BoxPlotQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Box Plot", "Box Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Box", "/cookbook/5.0/Box/BoxPlotQuickstart"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Box/BoxPlotQuickstart'>Box Plot Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Box/BoxPlotQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Box">Category: Box Plot</a>
</div>

Box plots can be created individually and added to the plot.

[![](/cookbook/5.0/images/BoxPlotQuickstart.png?241029205813)](/cookbook/5.0/images/BoxPlotQuickstart.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

ScottPlot.Box box = new()
{
    Position = 5,
    BoxMin = 81,
    BoxMax = 93,
    WhiskerMin = 76,
    WhiskerMax = 107,
    BoxMiddle = 84,
};

myPlot.Add.Box(box);

myPlot.Axes.SetLimits(0, 10, 70, 110);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


