---
Title: Smith Chart Quickstart - ScottPlot 5.0 Cookbook
Description: Add a Smith chart to the plot and use its methods to translate impedance to Cartesian coordinates that can be used for placing other plot components.
URL: /cookbook/5.0/SmithChart/SmithChartQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Smith Chart", "Smith Chart Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SmithChart", "/cookbook/5.0/SmithChart/SmithChartQuickstart"]
Date: 2025-01-13
Version: ScottPlot 5.0.53
Version: ScottPlot 5.0.53
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Smith Chart Quickstart</h1>
</div>

Add a Smith chart to the plot and use its methods to translate impedance to Cartesian coordinates that can be used for placing other plot components.

[![](/cookbook/5.0/images/SmithChartQuickstart.png?250112204022)](/cookbook/5.0/images/SmithChartQuickstart.png?250112204022)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SmithChart.cs" imageUrl="/cookbook/5.0/images/SmithChartQuickstart.png?250112204022" >}}ScottPlot.Plot myPlot = new();

var smith = myPlot.Add.SmithChartAxis();

// translate an impedance location on the Smith chart to a 2D location on the plot
double resistance = 0.2;
double reactance = -0.5;
Coordinates location = smith.GetCoordinates(resistance, reactance);

// use that location to add traditional plot components
myPlot.Add.Marker(location, MarkerShape.FilledCircle, size: 15, Colors.Red);
var txt = myPlot.Add.Text("0.2 - j 0.5", location);
txt.LabelStyle.FontSize = 24;
txt.LabelStyle.Bold = true;
txt.LabelStyle.ForeColor = Colors.Red;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/SmithChart'>Smith Chart</a> category</div>


