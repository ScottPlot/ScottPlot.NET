---
Title: Axis Lines - ScottPlot 5.0 Cookbook
Description: Axis lines indicate a position on an axis.
URL: /cookbook/5.0/AxisLines/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis Lines"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisLines"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Axis Lines</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis Lines</h1>
<a href='/cookbook/5.0/AxisLines/AxisLineQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Axis lines are vertical or horizontal lines that span an entire axis.

[![](/cookbook/5.0/images/AxisLineQuickstart.png?250126165944)](/cookbook/5.0/images/AxisLineQuickstart.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/AxisLines.cs" imageUrl="/cookbook/5.0/images/AxisLineQuickstart.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Add.VerticalLine(24);
myPlot.Add.HorizontalLine(0.73);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis Line Label</h1>
<a href='/cookbook/5.0/AxisLines/AxisLineLabel' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Axis lines have labels that can be used to display arbitrary text on the axes they are attached to.

[![](/cookbook/5.0/images/AxisLineLabel.png?250126165944)](/cookbook/5.0/images/AxisLineLabel.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/AxisLines.cs" imageUrl="/cookbook/5.0/images/AxisLineLabel.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// by default labels are drawn on the same side as the axis label

var axLine1 = myPlot.Add.VerticalLine(24);
axLine1.Text = "Line 1";

var axLine2 = myPlot.Add.HorizontalLine(0.75);
axLine2.Text = "Line 2";

// labels may be drawn on the side opposite of the axis label

var axLine3 = myPlot.Add.VerticalLine(37);
axLine3.Text = "Line 3";
axLine3.LabelOppositeAxis = true;

var axLine4 = myPlot.Add.HorizontalLine(-.75);
axLine4.Text = "Line 4";
axLine4.LabelOppositeAxis = true;

// extra padding on the right and top ensures labels have room
myPlot.Axes.Right.MinimumSize = 30;
myPlot.Axes.Top.MinimumSize = 30;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis Line Label Positioning</h1>
<a href='/cookbook/5.0/AxisLines/AxisLineLabelPositioning' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Axis line labels can have custom positioning, including rotation and alignment.

[![](/cookbook/5.0/images/AxisLineLabelPositioning.png?250126165944)](/cookbook/5.0/images/AxisLineLabelPositioning.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/AxisLines.cs" imageUrl="/cookbook/5.0/images/AxisLineLabelPositioning.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

var axLine1 = myPlot.Add.VerticalLine(42);
axLine1.Text = "Line 1";
axLine1.LabelRotation = -90;
axLine1.LabelAlignment = Alignment.MiddleRight;

var axLine2 = myPlot.Add.HorizontalLine(0.75);
axLine2.Text = "Line 2";
axLine2.LabelRotation = 0;
axLine2.LabelAlignment = Alignment.MiddleRight;

var axLine3 = myPlot.Add.VerticalLine(20);
axLine3.Text = "Line 3";
axLine3.LabelRotation = -45;
axLine3.LabelAlignment = Alignment.UpperRight;

// extra padding on the bottom and left for the rotated labels
myPlot.Axes.Bottom.MinimumSize = 60;
myPlot.Axes.Left.MinimumSize = 60;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis Line Style</h1>
<a href='/cookbook/5.0/AxisLines/AxisLineStyle' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Axis lines have extensive customization options.

[![](/cookbook/5.0/images/AxisLineStyle.png?250126165944)](/cookbook/5.0/images/AxisLineStyle.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/AxisLines.cs" imageUrl="/cookbook/5.0/images/AxisLineStyle.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

var vl1 = myPlot.Add.VerticalLine(24);
vl1.LineWidth = 3;
vl1.Color = Colors.Magenta;

var hl1 = myPlot.Add.HorizontalLine(0.75);
hl1.LineWidth = 2;
hl1.Color = Colors.Green;
hl1.LinePattern = LinePattern.Dashed;

var hl2 = myPlot.Add.HorizontalLine(-.23);
hl2.LineColor = Colors.Navy;
hl2.LineWidth = 5;
hl2.Text = "Hello";
hl2.LabelFontSize = 24;
hl2.LabelBackgroundColor = Colors.Blue;
hl2.LabelFontColor = Colors.Yellow;
hl2.LinePattern = LinePattern.DenselyDashed;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis Line In Legend</h1>
<a href='/cookbook/5.0/AxisLines/AxisLineInLegend' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Axis lines will be added to the legend if their Text property is set unless their ExcludeFromLegend property is true.

[![](/cookbook/5.0/images/AxisLineInLegend.png?250126165944)](/cookbook/5.0/images/AxisLineInLegend.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/AxisLines.cs" imageUrl="/cookbook/5.0/images/AxisLineInLegend.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

var axLine1 = myPlot.Add.VerticalLine(24);
axLine1.Text = "Line 1";

var axLine2 = myPlot.Add.HorizontalLine(0.75);

var axLine3 = myPlot.Add.VerticalLine(37);
axLine3.Text = "Line 3";
axLine3.ExcludeFromLegend = true;

var axLine4 = myPlot.Add.HorizontalLine(0.25);
axLine4.Text = "Line 4";

var axLine5 = myPlot.Add.HorizontalLine(-.75);
axLine5.Text = "Line 5";
axLine5.ExcludeFromLegend = true;

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Ignore When Autoscaling</h1>
<a href='/cookbook/5.0/AxisLines/AxisLineIgnoreLimits' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Calling Plot.Axes.AutoScale() or middle-clicking the plot will set the axis limits to fit the data. By default the position of axis lines and spans are included in automatic axis limit calculations, but a flag can be set to ignore certain plottables when automatically scaling the plot.

[![](/cookbook/5.0/images/AxisLineIgnoreLimits.png?250126165944)](/cookbook/5.0/images/AxisLineIgnoreLimits.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/AxisLines.cs" imageUrl="/cookbook/5.0/images/AxisLineIgnoreLimits.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

var hline = myPlot.Add.HorizontalLine(0.23);
hline.IsDraggable = true;
hline.EnableAutoscale = false;

var hSpan = myPlot.Add.HorizontalSpan(-10, 20);
hSpan.IsDraggable = true;
hSpan.EnableAutoscale = false;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis Line with Limits</h1>
<a href='/cookbook/5.0/AxisLines/AxisLineLimits' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Axis lines extend infinitely in both directions by default, but upper and lower limits may be specified to limit the dimensions of axis lines.

[![](/cookbook/5.0/images/AxisLineLimits.png?250126165944)](/cookbook/5.0/images/AxisLineLimits.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/AxisLines.cs" imageUrl="/cookbook/5.0/images/AxisLineLimits.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

var vLine = myPlot.Add.VerticalLine(24);
vLine.Minimum = -.5;
vLine.Maximum = 0.5;

var hLine = myPlot.Add.HorizontalLine(0.73);
hLine.Minimum = 10;
hLine.Maximum = 40;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


