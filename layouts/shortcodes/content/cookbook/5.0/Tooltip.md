---
Title: Tooltip - ScottPlot 5.0 Cookbook
Description: Tooltips are annotations that point to an X/Y coordinate on the plot.
URL: /cookbook/5.0/Tooltip/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Tooltip"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Tooltip"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Tooltip</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Tooltip Quickstart</h1>
<a href='/cookbook/5.0/Tooltip/TooltipQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Tooltips are annotations that point to an X/Y coordinate on the plot.

[![](/cookbook/5.0/images/TooltipQuickstart.png?250322130304)](/cookbook/5.0/images/TooltipQuickstart.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Tooltip.cs" imageUrl="/cookbook/5.0/images/TooltipQuickstart.png?250322130304" >}}ScottPlot.Plot myPlot = new();

double[] ys = Generate.Sin(50);
var plt = myPlot.Add.Signal(ys);
plt.MaximumMarkerSize = 20;

Coordinates tip = new(25, ys[25]);
Coordinates label = tip.WithDelta(8, .7);
myPlot.Add.Tooltip(tip, "Special Point", label);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Tooltip Label Styling</h1>
<a href='/cookbook/5.0/Tooltip/TooltipFont' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Tooltips fonts can be customized.

[![](/cookbook/5.0/images/TooltipFont.png?250322130304)](/cookbook/5.0/images/TooltipFont.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Tooltip.cs" imageUrl="/cookbook/5.0/images/TooltipFont.png?250322130304" >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Tooltip Colors</h1>
<a href='/cookbook/5.0/Tooltip/TooltipColors' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
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

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Tooltip Tail Width</h1>
<a href='/cookbook/5.0/Tooltip/TooltipTailWidth' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Customizable tooltip tail width percentage. The actual width of the tail is the lesser of the length or width of the tooltip body.

[![](/cookbook/5.0/images/TooltipTailWidth.png?250322130304)](/cookbook/5.0/images/TooltipTailWidth.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Tooltip.cs" imageUrl="/cookbook/5.0/images/TooltipTailWidth.png?250322130304" >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Tooltip Angle</h1>
<a href='/cookbook/5.0/Tooltip/TooltipAngle' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The shape of tooltips automatically adjusts according to the position of the tip relative to the label.

[![](/cookbook/5.0/images/TooltipAngle.png?250322130304)](/cookbook/5.0/images/TooltipAngle.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Tooltip.cs" imageUrl="/cookbook/5.0/images/TooltipAngle.png?250322130304" >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


