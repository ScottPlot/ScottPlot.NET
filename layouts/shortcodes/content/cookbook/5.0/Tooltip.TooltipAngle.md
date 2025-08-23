---
Title: Tooltip Angle - ScottPlot 5.0 Cookbook
Description: The shape of tooltips automatically adjusts according to the position of the tip relative to the label.
URL: /cookbook/5.0/Tooltip/TooltipAngle/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Tooltip", "Tooltip Angle"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Tooltip", "/cookbook/5.0/Tooltip/TooltipAngle"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Tooltip Angle</h1>
</div>

The shape of tooltips automatically adjusts according to the position of the tip relative to the label.

[![](/cookbook/5.0/images/TooltipAngle.png?250822231048)](/cookbook/5.0/images/TooltipAngle.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Tooltip.cs" imageUrl="/cookbook/5.0/images/TooltipAngle.png?250822231048" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 360; i += 30)
{
    Coordinates tip = new(0, 0);
    PolarCoordinates polar = new(1, Angle.FromDegrees(i));
    Coordinates label = polar.ToCartesian();
    var tooltip = myPlot.Add.Tooltip(tip, $"{i}º", label);
    tooltip.FillColor = Colormap.Default.GetColor(i, 360).Lighten(0.5);
    tooltip.LineColor = Colormap.Default.GetColor(i, 360);
    tooltip.LineWidth = 2;
    tooltip.LabelBold = true;
    tooltip.LabelFontColor = Colormap.Default.GetColor(i, 360).Darken(0.5);
}

myPlot.Axes.SetLimits(-1.5, 1.5, -1.5, 1.5);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Tooltip'>Tooltip</a> category</div>


