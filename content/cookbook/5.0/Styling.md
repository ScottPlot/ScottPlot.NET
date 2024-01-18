---
Title: Styling Plots - ScottPlot 5.0 Cookbook
Description: How to customize plots
URL: /cookbook/5.0/Styling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling"]
Date: 2024-01-18
Version: ScottPlot 5.0.18
Version: ScottPlot 5.0.18
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Styling Plots


<h2><a href='/cookbook/5.0/Styling/StyleClass'>Style Helper Functions</a></h2>

Plots contain many objects which can be customized individually by assigining to their public properties, but helper methods exist in the Plot's Style object that make it easier to customzie many items at once using a simpler API.

[![](/cookbook/5.0/images/StyleClass.png)](/cookbook/5.0/images/StyleClass.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

// visible items have public properties that can be customized
myPlot.Axes.Bottom.Label.Text = "Horizontal Axis";
myPlot.Axes.Left.Label.Text = "Vertical Axis";
myPlot.Axes.Title.Label.Text = "Plot Title";

// the Style object contains helper methods to easily style many items at once
myPlot.Style.Background(figure: Color.FromHex("#07263b"), data: Color.FromHex("#0b3049"));
myPlot.Style.ColorAxes(Color.FromHex("#a0acb5"));
myPlot.Style.ColorGrids(Color.FromHex("#0e3d54"));

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Styling/AxisCustom'>Axis Customization</a></h2>

Axis labels, tick marks, and frame can all be customized.

[![](/cookbook/5.0/images/AxisCustom.png)](/cookbook/5.0/images/AxisCustom.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.Axes.Title.Label.Text = "Plot Title";
myPlot.Axes.Title.Label.ForeColor = Colors.RebeccaPurple;
myPlot.Axes.Title.Label.FontSize = 32;
myPlot.Axes.Title.Label.FontName = Fonts.Serif;
myPlot.Axes.Title.Label.Rotation = -5;
myPlot.Axes.Title.Label.Bold = false;

myPlot.Axes.Left.Label.Text = "Vertical Axis";
myPlot.Axes.Left.Label.ForeColor = Colors.Magenta;
myPlot.Axes.Left.Label.Italic = true;

myPlot.Axes.Bottom.Label.Text = "Horizontal Axis";
myPlot.Axes.Bottom.Label.Bold = false;
myPlot.Axes.Bottom.Label.FontName = Fonts.Monospace;

myPlot.Axes.Bottom.MajorTickStyle.Length = 10;
myPlot.Axes.Bottom.MajorTickStyle.Width = 3;
myPlot.Axes.Bottom.MajorTickStyle.Color = Colors.Magenta;
myPlot.Axes.Bottom.MinorTickStyle.Length = 5;
myPlot.Axes.Bottom.MinorTickStyle.Width = 0.5f;
myPlot.Axes.Bottom.MinorTickStyle.Color = Colors.Green;
myPlot.Axes.Bottom.FrameLineStyle.Color = Colors.LightBlue;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Styling/Palette'>Palettes</a></h2>

A palette is a set of colors, and the Plot's palette defines the default colors to use when adding new plottables. ScottPlot comes with many standard palettes, but users may also create their own.

[![](/cookbook/5.0/images/Palette.png)](/cookbook/5.0/images/Palette.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Palette = new ScottPlot.Palettes.Nord();

for (int i = 0; i < 5; i++)
{
    double[] data = Generate.Sin(100, phase: -i / 20.0f);
    var sig = myPlot.Add.Signal(data);
    sig.LineWidth = 3;
}

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Styling/Markers'>Markers</a></h2>

Many plot types have a MarkerStyle which can be customized.

[![](/cookbook/5.0/images/Markers.png)](/cookbook/5.0/images/Markers.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

MarkerShape[] markerShapes = Enum.GetValues<MarkerShape>().ToArray();

for (int i = 0; i < markerShapes.Length; i++)
{
    double[] xs = Generate.Consecutive(20);
    double[] ys = Generate.Sin(20, offset: markerShapes.Length - i);
    var scatter = myPlot.Add.Scatter(xs, ys);
    scatter.MarkerStyle.Shape = markerShapes[i];
    scatter.MarkerStyle.Size = 10;
}

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Styling/MarkerNames'>Marker Names</a></h2>

Markers can be referred to by their name.

[![](/cookbook/5.0/images/MarkerNames.png)](/cookbook/5.0/images/MarkerNames.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

MarkerShape[] markerShapes = Enum.GetValues<MarkerShape>().ToArray();

for (int i = 0; i < markerShapes.Length; i++)
{
    var mp = myPlot.Add.Marker(x: i, y: 0);
    mp.MarkerStyle.Shape = markerShapes[i];
    mp.MarkerStyle.Size = 10;

    var txt = myPlot.Add.Text(markerShapes[i].ToString(), i, 0.15);
    txt.Label.Rotation = -90;
    txt.Label.Alignment = Alignment.MiddleLeft;
}

myPlot.Title("Marker Names");
myPlot.Axes.SetLimits(-1, markerShapes.Length, -1, 4);
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Styling/LineStyles'>Line Styles</a></h2>

Many plot types have a LineStyle which can be customized.

[![](/cookbook/5.0/images/LineStyles.png)](/cookbook/5.0/images/LineStyles.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

LinePattern[] linePatterns = Enum.GetValues<LinePattern>().ToArray();

for (int i = 0; i < linePatterns.Length; i++)
{
    LinePattern pattern = linePatterns[i];

    var line = myPlot.Add.Line(0, -i, 1, -i);
    line.Pattern = pattern;
    line.Width = 2;
    line.Color = Colors.Black;

    var txt = myPlot.Add.Text(pattern.ToString(), 1.1, -i);
    txt.Size = 18;
    txt.Bold = true;
    txt.Color = Colors.Black;
    txt.Label.Alignment = Alignment.MiddleLeft;
}

myPlot.Axes.Margins(right: 1);
myPlot.HideGrid();
myPlot.Layout.Frameless();

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Styling/Scaling'>Scaling</a></h2>

All components of an image can be scaled up or down in size by adjusting the ScaleFactor property. This is very useful for creating images that look nice on high DPI displays with display scaling enabled.

[![](/cookbook/5.0/images/Scaling.png)](/cookbook/5.0/images/Scaling.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.ScaleFactor = 2;
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

