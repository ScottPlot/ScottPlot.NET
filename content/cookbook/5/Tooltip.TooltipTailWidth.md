---
Title: Tooltip Tail Width - ScottPlot 5 Cookbook
Description: Customizable tooltip tail width percentage. The actual width of the tail is the lesser of the length or width of the tooltip body.
URL: /cookbook/5/Tooltip/TooltipTailWidth/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Tooltip", "Tooltip Tail Width"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Tooltip", "/cookbook/5/Tooltip/TooltipTailWidth"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Tooltip Tail Width</h1>
</div>

Customizable tooltip tail width percentage. The actual width of the tail is the lesser of the length or width of the tooltip body.

[![](/cookbook/5/images/TooltipTailWidth.png?260329072039)](/cookbook/5/images/TooltipTailWidth.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Tooltip.cs" imageUrl="/cookbook/5/images/TooltipTailWidth.png?260329072039" >}}ScottPlot.Plot myPlot = new();

double[] widthFraction = [0.3, 0.5, 0.7, 1.0];

for (int i = 0; i &lt; widthFraction.Length; i++)
{

    Coordinates tip = new(0, i * 2);
    Coordinates label = tip.WithDelta(2, 1);
    var tooltip = myPlot.Add.Tooltip(tip, $"Width={widthFraction[i]}", label);
    tooltip.TailWidthPercentage = widthFraction[i];
}

myPlot.Axes.SetLimits(-3, 7, -1, 9);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Tooltip'>Tooltip</a> category</div>


