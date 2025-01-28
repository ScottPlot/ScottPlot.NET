---
Title: Scatter Plot - ScottPlot 5.0 Cookbook
Description: A scatter plot can be used to display X/Y data points.
URL: /cookbook/5.0/ScottPlotQuickstart/QuickstartScatter/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Quickstart", "Scatter Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ScottPlotQuickstart", "/cookbook/5.0/ScottPlotQuickstart/QuickstartScatter"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot</h1>
</div>

A scatter plot can be used to display X/Y data points.

[![](/cookbook/5.0/images/QuickstartScatter.png?250126165944)](/cookbook/5.0/images/QuickstartScatter.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Quickstart.cs" imageUrl="/cookbook/5.0/images/QuickstartScatter.png?250126165944" >}}ScottPlot.Plot myPlot = new();

// create sample data
double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };

// add a scatter plot to the plot
myPlot.Add.Scatter(dataX, dataY);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/ScottPlotQuickstart'>Quickstart</a> category</div>


