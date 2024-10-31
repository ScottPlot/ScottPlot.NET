---
Title: Scatter Plot - ScottPlot 5.0 Cookbook
Description: A scatter plot can be used to display X/Y data points.
URL: /cookbook/5.0/ScottPlotQuickstart/QuickstartScatter/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Quickstart", "Scatter Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ScottPlotQuickstart", "/cookbook/5.0/ScottPlotQuickstart/QuickstartScatter"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/ScottPlotQuickstart/QuickstartScatter'>Scatter Plot</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/ScottPlotQuickstart/QuickstartScatter">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/ScottPlotQuickstart">Category: Quickstart</a>
</div>

A scatter plot can be used to display X/Y data points.

[![](/cookbook/5.0/images/QuickstartScatter.png?241031194635)](/cookbook/5.0/images/QuickstartScatter.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// create sample data
double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };

// add a scatter plot to the plot
myPlot.Add.Scatter(dataX, dataY);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


