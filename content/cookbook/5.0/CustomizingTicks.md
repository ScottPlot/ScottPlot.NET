---
Title: Customizing Ticks - ScottPlot 5.0 Cookbook
Description: Advanced customization of tick marks and tick labels
URL: /cookbook/5.0/CustomizingTicks/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks"]
Date: 2024-04-25
Version: ScottPlot 5.0.28
Version: ScottPlot 5.0.28
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Customizing Ticks


<h2><a href='/cookbook/5.0/CustomizingTicks/CustomTickFormatter'>Custom Tick Formatters</a></h2>

Users can customize the logic used to create tick labels from tick positions. Old versions of ScottPlot achieved this using a ManualTickPositions method.

[![](/cookbook/5.0/images/CustomTickFormatter.png?240425082609)](/cookbook/5.0/images/CustomTickFormatter.png?240425082609)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(100, 1, -50);
myPlot.Add.Scatter(xs, Generate.Sin(100));
myPlot.Add.Scatter(xs, Generate.Cos(100));

// create a static function containing the string formatting logic
static string CustomFormatter(double position)
{
    if (position == 0)
        return "0";
    else if (position > 0)
        return $"+{position}";
    else
        return $"({-position})";
}

// create a custom tick generator using your custom label formatter
ScottPlot.TickGenerators.NumericAutomatic myTickGenerator = new()
{
    LabelFormatter = CustomFormatter
};

// tell an axis to use the custom tick generator
myPlot.Axes.Bottom.TickGenerator = myTickGenerator;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/CustomizingTicks/AltTickGen'>Custom Tick Generators</a></h2>

Tick generators determine where ticks are to be placed and also contain logic for generating tick labels from tick positions. Alternative tick generators can be created and assigned to axes. Some common tick generators are provided with ScottPlot, and users also have the option create their own.

[![](/cookbook/5.0/images/AltTickGen.png?240425082609)](/cookbook/5.0/images/AltTickGen.png?240425082609)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericFixedInterval(11);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/CustomizingTicks/CustomTicks'>Custom Tick Positions</a></h2>

Users can define ticks to be placed at specific locations.

[![](/cookbook/5.0/images/CustomTicks.png?240425082609)](/cookbook/5.0/images/CustomTicks.png?240425082609)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// display sample data
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// create a manual tick generator and add ticks
ScottPlot.TickGenerators.NumericManual ticks = new();

// add major ticks with their labels
ticks.AddMajor(0, "zero");
ticks.AddMajor(20, "twenty");
ticks.AddMajor(50, "fifty");

// add minor ticks
ticks.AddMinor(22);
ticks.AddMinor(25);
ticks.AddMinor(32);
ticks.AddMinor(35);
ticks.AddMinor(42);
ticks.AddMinor(45);

// tell the horizontal axis to use the custom tick generator
myPlot.Axes.Bottom.TickGenerator = ticks;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/CustomizingTicks/RotatedTicks'>Rotated Tick Labels</a></h2>

Users can customize tick label rotation.

[![](/cookbook/5.0/images/RotatedTicks.png?240425082609)](/cookbook/5.0/images/RotatedTicks.png?240425082609)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Axes.Bottom.TickLabelStyle.Rotation = -45;
myPlot.Axes.Bottom.TickLabelStyle.OffsetY = -8;
myPlot.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleRight;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/CustomizingTicks/RotatedTicksLongLabels'>Rotated Tick with Long Labels</a></h2>

The axis size can be increased to accommodate rotated or long tick labels.

[![](/cookbook/5.0/images/RotatedTicksLongLabels.png?240425082609)](/cookbook/5.0/images/RotatedTicksLongLabels.png?240425082609)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// create a bar plot
double[] values = { 5, 10, 7, 13, 25, 60 };
myPlot.Add.Bars(values);
myPlot.Axes.Margins(bottom: 0);

// create a tick for each bar
Tick[] ticks =
{
    new(0, "First Long Title"),
    new(1, "Second Long Title"),
    new(2, "Third Long Title"),
    new(3, "Fourth Long Title"),
    new(4, "Fifth Long Title"),
    new(5, "Sixth Long Title")
};
myPlot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
myPlot.Axes.Bottom.TickLabelStyle.Rotation = 45;
myPlot.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleLeft;

// determine the width of the largest tick label
float largestLabelWidth = 0;
foreach (Tick tick in ticks)
{
    PixelSize size = myPlot.Axes.Bottom.TickLabelStyle.Measure(tick.Label);
    largestLabelWidth = Math.Max(largestLabelWidth, size.Width);
}

// ensure axis panels do not get smaller than the largest label
myPlot.Axes.Bottom.MinimumSize = largestLabelWidth;
myPlot.Axes.Right.MinimumSize = largestLabelWidth;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/CustomizingTicks/DisableGridLines'>Disable Grid Lines</a></h2>

Users can disable grid lines for specific axes.

[![](/cookbook/5.0/images/DisableGridLines.png?240425082609)](/cookbook/5.0/images/DisableGridLines.png?240425082609)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Grid.XAxisStyle.IsVisible = true;
myPlot.Grid.YAxisStyle.IsVisible = false;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/CustomizingTicks/MinimumTickSpacing'>Minimum Tick Spacing</a></h2>

Space between ticks can be increased by setting a value to indicate the minimum distance between tick labels (in pixels).

[![](/cookbook/5.0/images/MinimumTickSpacing.png?240425082609)](/cookbook/5.0/images/MinimumTickSpacing.png?240425082609)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

ScottPlot.TickGenerators.NumericAutomatic tickGenX = new();
tickGenX.MinimumTickSpacing = 50;
myPlot.Axes.Bottom.TickGenerator = tickGenX;

ScottPlot.TickGenerators.NumericAutomatic tickGenY = new();
tickGenY.MinimumTickSpacing = 25;
myPlot.Axes.Left.TickGenerator = tickGenY;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/CustomizingTicks/TickDensity'>Tick Density</a></h2>

Tick density can be adjusted as a fraction of the default value. Unlike MinimumTickSpacing, this strategy is aware of the size of tick labels and adjusts accordingly.

[![](/cookbook/5.0/images/TickDensity.png?240425082609)](/cookbook/5.0/images/TickDensity.png?240425082609)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

ScottPlot.TickGenerators.NumericAutomatic tickGenX = new();
tickGenX.TickDensity = 0.2;
myPlot.Axes.Bottom.TickGenerator = tickGenX;

ScottPlot.TickGenerators.NumericAutomatic tickGenY = new();
tickGenY.TickDensity = 0.2;
myPlot.Axes.Left.TickGenerator = tickGenY;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/CustomizingTicks/TickCount'>Tick Count</a></h2>

A target number of ticks can be provided and the automatic tick generator will attempt to place that number of ticks. This strategy allows tick density to decrease as the image size increases.

[![](/cookbook/5.0/images/TickCount.png?240425082609)](/cookbook/5.0/images/TickCount.png?240425082609)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

ScottPlot.TickGenerators.NumericAutomatic tickGenX = new();
tickGenX.TargetTickCount = 3;
myPlot.Axes.Bottom.TickGenerator = tickGenX;

ScottPlot.TickGenerators.NumericAutomatic tickGenY = new();
tickGenY.TargetTickCount = 3;
myPlot.Axes.Left.TickGenerator = tickGenY;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/CustomizingTicks/StandardMinorTickDistribution'>Minor Tick Density</a></h2>

Minor tick marks are automatically generated at intervals between major tick marks. By default they are evenly spaced, but their density may be customized.

[![](/cookbook/5.0/images/StandardMinorTickDistribution.png?240425082609)](/cookbook/5.0/images/StandardMinorTickDistribution.png?240425082609)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// plot sample data
double[] xs = Generate.Consecutive(100);
double[] ys = Generate.NoisyExponential(100);
var sp = myPlot.Add.Scatter(xs, ys);
sp.LineWidth = 0;

// create a minor tick generator with 10 minor ticks per major tick
ScottPlot.TickGenerators.EvenlySpacedMinorTickGenerator minorTickGen = new(10);

// create a numeric tick generator that uses our custom minor tick generator
ScottPlot.TickGenerators.NumericAutomatic tickGen = new();
tickGen.MinorTickGenerator = minorTickGen;

// tell the left axis to use our custom tick generator
myPlot.Axes.Left.TickGenerator = tickGen;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/CustomizingTicks/LogScaleTicks'>Log Scale Tick Marks</a></h2>

The appearance of logarithmic scaling can be achieved by log-scaling the data to be displayed then customizing the minor ticks and grid.

[![](/cookbook/5.0/images/LogScaleTicks.png?240425082609)](/cookbook/5.0/images/LogScaleTicks.png?240425082609)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// start with original data
double[] xs = Generate.Consecutive(100);
double[] ys = Generate.NoisyExponential(100);

// log-scale the data and account for negative values
double[] logYs = ys.Select(Math.Log10).ToArray();

// add log-scaled data to the plot
var sp = myPlot.Add.Scatter(xs, logYs);
sp.LineWidth = 0;

// create a minor tick generator that places log-distributed minor ticks
ScottPlot.TickGenerators.LogMinorTickGenerator minorTickGen = new();

// create a numeric tick generator that uses our custom minor tick generator
ScottPlot.TickGenerators.NumericAutomatic tickGen = new();
tickGen.MinorTickGenerator = minorTickGen;

// create a custom tick formatter to set the label text for each tick
static string LogTickLabelFormatter(double y) => $"{Math.Pow(10, y):N0}";

// tell our major tick generator to only show major ticks that are whole integers
tickGen.IntegerTicksOnly = true;

// tell our custom tick generator to use our new label formatter
tickGen.LabelFormatter = LogTickLabelFormatter;

// tell the left axis to use our custom tick generator
myPlot.Axes.Left.TickGenerator = tickGen;

// show grid lines for minor ticks
myPlot.Grid.MajorLineColor = Colors.Black.WithOpacity(.15);
myPlot.Grid.MinorLineColor = Colors.Black.WithOpacity(.05);
myPlot.Grid.MinorLineWidth = 1;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

