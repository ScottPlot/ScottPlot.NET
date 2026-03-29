---
Title: Tooltip Colors - ScottPlot 5 Cookbook
Description: Tooltips border and fill styles can be customized.
URL: /cookbook/5/Tooltip/TooltipColors/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Tooltip", "Tooltip Colors"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Tooltip", "/cookbook/5/Tooltip/TooltipColors"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Tooltip Colors</h1>
</div>

Tooltips border and fill styles can be customized.

[![](/cookbook/5/images/TooltipColors.png?260329072039)](/cookbook/5/images/TooltipColors.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Tooltip.cs" imageUrl="/cookbook/5/images/TooltipColors.png?260329072039" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Tooltip'>Tooltip</a> category</div>


