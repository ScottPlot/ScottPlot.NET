---
Title: Tooltip Label Styling - ScottPlot 5.0 Cookbook
Description: Tooltips fonts can be customized.
URL: /cookbook/5.0/Tooltip/TooltipFont/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Tooltip", "Tooltip Label Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Tooltip", "/cookbook/5.0/Tooltip/TooltipFont"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Tooltip Label Styling</h1>
</div>

Tooltips fonts can be customized.

[![](/cookbook/5.0/images/TooltipFont.png?250822231048)](/cookbook/5.0/images/TooltipFont.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Tooltip.cs" imageUrl="/cookbook/5.0/images/TooltipFont.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] ys = Generate.Sin(50);
var plt = myPlot.Add.Signal(ys);
plt.MaximumMarkerSize = 20;

Coordinates tip = new(25, ys[25]);
Coordinates label = tip.WithDelta(8, .7);
var tooltip = myPlot.Add.Tooltip(tip, "Hello", label);
tooltip.LabelFontName = "Comic Sans MS";
tooltip.LabelFontSize = 36;
tooltip.LabelBold = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Tooltip'>Tooltip</a> category</div>


