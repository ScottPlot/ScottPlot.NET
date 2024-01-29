---
Title: Axis Lines - ScottPlot 5.0 Cookbook
Description: Axis lines indicate a position on an axis.
URL: /cookbook/5.0/AxisLines/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis Lines"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisLines"]
Date: 2024-01-29
Version: ScottPlot 5.0.21
Version: ScottPlot 5.0.21
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Axis Lines


<h2><a href='/cookbook/5.0/AxisLines/AxisLineQuickstart'>Axis Lines</a></h2>

Axis lines are vertical or horizontal lines that span an entire axis.

[![](/cookbook/5.0/images/AxisLineQuickstart.png?240128210832)](/cookbook/5.0/images/AxisLineQuickstart.png?240128210832)

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

Axis lines have labels that can be used to display arbitrary on the axes they are attached to.

[![](/cookbook/5.0/images/AxisLineLabel.png?240128210832)](/cookbook/5.0/images/AxisLineLabel.png?240128210832)

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

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/AxisLines/AxisLineStyle'>Axis Line Style</a></h2>

Axis lines have extensive customization options.

[![](/cookbook/5.0/images/AxisLineStyle.png?240128210832)](/cookbook/5.0/images/AxisLineStyle.png?240128210832)

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
hl2.Label.FontSize = 24;
hl2.Label.BackColor = Colors.Blue;
hl2.Label.ForeColor = Colors.Yellow;
hl2.LinePattern = LinePattern.DenselyDashed;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

