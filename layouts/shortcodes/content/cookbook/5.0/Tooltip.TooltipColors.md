---
Title: Tooltip Colors - ScottPlot 5.0 Cookbook
Description: Tooltips border and fill styles can be customized.
URL: /cookbook/5.0/Tooltip/TooltipColors/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Tooltip", "Tooltip Colors"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Tooltip", "/cookbook/5.0/Tooltip/TooltipColors"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Tooltip Colors</h1>
</div>

Tooltips border and fill styles can be customized.

[![](/cookbook/5.0/images/TooltipColors.png?250322130304)](/cookbook/5.0/images/TooltipColors.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Tooltip.cs" imageUrl="/cookbook/5.0/images/TooltipColors.png?250322130304" >}}ScottPlot.Plot myPlot = new();

double[] ys = Generate.Sin(50);
var plt = myPlot.Add.Signal(ys);
plt.MaximumMarkerSize = 20;

Coordinates tip = new(25, ys[25]);
Coordinates label = tip.WithDelta(8, .7);
var tooltip = myPlot.Add.Tooltip(tip, "Special Point", label);
tooltip.FillColor = Colors.Blue;
tooltip.LineColor = Colors.Navy;
tooltip.LineWidth = 3;
tooltip.LabelFontColor = Colors.Yellow;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Tooltip'>Tooltip</a> category</div>


