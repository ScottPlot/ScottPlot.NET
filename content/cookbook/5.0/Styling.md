---
Title: Styling Plots - ScottPlot 5.0 Cookbook
Description: How to customize appearance of plots
URL: /cookbook/5.0/Styling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling"]
Date: 2024-03-24
Version: ScottPlot 5.0.23
Version: ScottPlot 5.0.23
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Styling Plots


<h2><a href='/cookbook/5.0/Styling/StyleClass'>Style Helper Functions</a></h2>

Plots contain many objects which can be customized individually by assigning to their public properties, but helper methods exist in the Plot's Style object that make it easier to customize many items at once using a simpler API.

[![](/cookbook/5.0/images/StyleClass.png?240324174053)](/cookbook/5.0/images/StyleClass.png?240324174053)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

// visible items have public properties that can be customized
myPlot.Axes.Bottom.Label.Text = "Horizontal Axis";
myPlot.Axes.Left.Label.Text = "Vertical Axis";
myPlot.Axes.Title.Label.Text = "Plot Title";

// some items must be styled directly
myPlot.Grid.MajorLineColor = Color.FromHex("#0e3d54");
myPlot.FigureBackground.Color = Color.FromHex("#07263b");
myPlot.DataBackground.Color = Color.FromHex("#0b3049");

// the Style object contains helper methods to style many items at once
myPlot.Axes.Color(Color.FromHex("#a0acb5"));

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Styling/AxisCustom'>Axis Customization</a></h2>

Axis labels, tick marks, and frame can all be customized.

[![](/cookbook/5.0/images/AxisCustom.png?240324174053)](/cookbook/5.0/images/AxisCustom.png?240324174053)

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
myPlot.Axes.Bottom.FrameLineStyle.Color = Colors.Blue;
myPlot.Axes.Bottom.FrameLineStyle.Width = 3;

myPlot.Axes.Right.FrameLineStyle.Width = 0;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Styling/Palette'>Palettes</a></h2>

A palette is a set of colors, and the Plot's palette defines the default colors to use when adding new plottables. ScottPlot comes with many standard palettes, but users may also create their own.

[![](/cookbook/5.0/images/Palette.png?240324174053)](/cookbook/5.0/images/Palette.png?240324174053)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// change the default palette used when adding new plottables
myPlot.Add.Palette = new ScottPlot.Palettes.Nord();

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

[![](/cookbook/5.0/images/Markers.png?240324174053)](/cookbook/5.0/images/Markers.png?240324174053)

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

[![](/cookbook/5.0/images/MarkerNames.png?240324174053)](/cookbook/5.0/images/MarkerNames.png?240324174053)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

MarkerShape[] markerShapes = Enum.GetValues<MarkerShape>().ToArray();
ScottPlot.Palettes.Category20 palette = new();

for (int i = 0; i < markerShapes.Length; i++)
{
    var mp = myPlot.Add.Marker(x: i, y: 0);
    mp.MarkerStyle.Shape = markerShapes[i];
    mp.MarkerStyle.Size = 10;
    mp.MarkerStyle.Outline.Width = 1.5f;
    mp.MarkerStyle.Outline.Color = palette.GetColor(i);
    mp.MarkerStyle.Fill.Color = palette.GetColor(i).WithAlpha(.5);

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

[![](/cookbook/5.0/images/LineStyles.png?240324174053)](/cookbook/5.0/images/LineStyles.png?240324174053)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

LinePattern[] linePatterns = Enum.GetValues<LinePattern>().ToArray();

for (int i = 0; i < linePatterns.Length; i++)
{
    LinePattern pattern = linePatterns[i];

    var line = myPlot.Add.Line(0, -i, 1, -i);
    line.LinePattern = pattern;
    line.LineWidth = 2;
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

[![](/cookbook/5.0/images/Scaling.png?240324174053)](/cookbook/5.0/images/Scaling.png?240324174053)

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


<h2><a href='/cookbook/5.0/Styling/DarkMode'>Dark Mode</a></h2>

Plots can be created using dark mode by setting the colors of major plot components to ones consistent with a dark theme.

[![](/cookbook/5.0/images/DarkMode.png?240324174053)](/cookbook/5.0/images/DarkMode.png?240324174053)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// set the color palette used when coloring new items added to the plot
myPlot.Add.Palette = new ScottPlot.Palettes.Penumbra();

// add things to the plot
for (int i = 0; i < 5; i++)
{
    var sig = myPlot.Add.Signal(Generate.Sin(51, phase: -.05 * i));
    sig.LineWidth = 3;
    sig.Label = $"Line {i + 1}";
}
myPlot.XLabel("Horizontal Axis");
myPlot.YLabel("Vertical Axis");
myPlot.Title("ScottPlot 5 in Dark Mode");
myPlot.ShowLegend();

// change figure colors
myPlot.Axes.Color(Color.FromHex("#d7d7d7"));
myPlot.Grid.MajorLineColor = Color.FromHex("#404040");
myPlot.FigureBackground.Color = Color.FromHex("#181818");
myPlot.DataBackground.Color = Color.FromHex("#1f1f1f");
myPlot.Legend.BackgroundFill.Color = Color.FromHex("#404040");
myPlot.Legend.Font.Color = Color.FromHex("#d7d7d7");
myPlot.Legend.OutlineStyle.Color = Color.FromHex("#d7d7d7");

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

