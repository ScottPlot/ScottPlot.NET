---
Title: Smith Chart - ScottPlot 5.0 Cookbook
Description: Create a Smith chart axis and add it to the plot to display impedance of RF signals using a horizontal axis indicating resistance and vertical axis indicating reactance.
URL: /cookbook/5.0/SmithChart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Smith Chart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SmithChart"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Smith Chart</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Smith Chart Quickstart</h1>
<a href='/cookbook/5.0/SmithChart/SmithChartQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Add a Smith chart to the plot and use its methods to translate impedance to Cartesian coordinates that can be used for placing other plot components.

[![](/cookbook/5.0/images/SmithChartQuickstart.png?250322130304)](/cookbook/5.0/images/SmithChartQuickstart.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SmithChart.cs" imageUrl="/cookbook/5.0/images/SmithChartQuickstart.png?250322130304" >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


