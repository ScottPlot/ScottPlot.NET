---
Title: Customizing Plottables - ScottPlot 5.0 Cookbook
Description: Most methods which add items to plots return the item the was added. Save the object that is returned and set its properties to customize it.
URL: /cookbook/5.0/ScottPlotQuickstart/CustomizingPlottables/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Quickstart", "Customizing Plottables"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ScottPlotQuickstart", "/cookbook/5.0/ScottPlotQuickstart/CustomizingPlottables"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/ScottPlotQuickstart/CustomizingPlottables'>Customizing Plottables</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/ScottPlotQuickstart/CustomizingPlottables">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/ScottPlotQuickstart">Category: Quickstart</a>
</div>

Most methods which add items to plots return the item the was added. Save the object that is returned and set its properties to customize it.

[![](/cookbook/5.0/images/CustomizingPlottables.png?241029205813)](/cookbook/5.0/images/CustomizingPlottables.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// create sample data
double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };

// add a scatter plot to the plot (and save what is returned)
var myScatter = myPlot.Add.Scatter(dataX, dataY);

// customize the scatter plot
myScatter.Color = Colors.Green;
myScatter.LineWidth = 5;
myScatter.MarkerSize = 15;
myScatter.MarkerShape = MarkerShape.FilledDiamond;
myScatter.LinePattern = LinePattern.DenselyDashed;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


