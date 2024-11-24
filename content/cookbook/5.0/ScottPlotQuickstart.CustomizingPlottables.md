---
Title: Customizing Plottables - ScottPlot 5.0 Cookbook
Description: Most methods which add items to plots return the item the was added. Save the object that is returned and set its properties to customize it.
URL: /cookbook/5.0/ScottPlotQuickstart/CustomizingPlottables/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Quickstart", "Customizing Plottables"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ScottPlotQuickstart", "/cookbook/5.0/ScottPlotQuickstart/CustomizingPlottables"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Customizing Plottables</h1>
</div>

Most methods which add items to plots return the item the was added. Save the object that is returned and set its properties to customize it.

[![](/cookbook/5.0/images/CustomizingPlottables.png?241124170640)](/cookbook/5.0/images/CustomizingPlottables.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Quickstart.cs" imageUrl="/cookbook/5.0/images/CustomizingPlottables.png?241124170640" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/ScottPlotQuickstart'>Quickstart</a> category</div>


