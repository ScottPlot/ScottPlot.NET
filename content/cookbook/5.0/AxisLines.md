---
Title: Axis Lines - ScottPlot 5.0 Cookbook
Description: Axis lines indicate a position on an axis.
URL: /cookbook/5.0/AxisLines/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis Lines"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisLines"]
Date: 2024-06-29
Version: ScottPlot 5.0.36
Version: ScottPlot 5.0.36
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Axis Lines


<h2><a href='/cookbook/5.0/AxisLines/AxisLineQuickstart'>Axis Lines</a></h2>

Axis lines are vertical or horizontal lines that span an entire axis.

[![](/cookbook/5.0/images/AxisLineQuickstart.png?240629072232)](/cookbook/5.0/images/AxisLineQuickstart.png?240629072232)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Add.VerticalLine(24);
myPlot.Add.HorizontalLine(0.73);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AxisLines/AxisLineLabel'>Axis Line Label</a></h2>

Axis lines have labels that can be used to display arbitrary text on the axes they are attached to.

[![](/cookbook/5.0/images/AxisLineLabel.png?240629072232)](/cookbook/5.0/images/AxisLineLabel.png?240629072232)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

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

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AxisLines/AxisLineLabelPositioning'>Axis Line Label Positioning</a></h2>

Axis line labels can have custom positioning, including rotation and alignment.

[![](/cookbook/5.0/images/AxisLineLabelPositioning.png?240629072232)](/cookbook/5.0/images/AxisLineLabelPositioning.png?240629072232)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

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

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AxisLines/AxisLineStyle'>Axis Line Style</a></h2>

Axis lines have extensive customization options.

[![](/cookbook/5.0/images/AxisLineStyle.png?240629072232)](/cookbook/5.0/images/AxisLineStyle.png?240629072232)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

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

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AxisLines/AxisLineInLegend'>Axis Line In Legend</a></h2>

Axis lines will be added to the legend if their Text property is set unless their ExcludeFromLegend property is true.

[![](/cookbook/5.0/images/AxisLineInLegend.png?240629072232)](/cookbook/5.0/images/AxisLineInLegend.png?240629072232)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

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

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

