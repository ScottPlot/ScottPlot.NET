---
Title: Customizing Ticks - ScottPlot 5.0 Cookbook
Description: Advanced customization of tick marks and tick labels
URL: /cookbook/5.0/CustomizingTicks/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks"]
Date: 2024-11-03
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Customizing Ticks</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Custom Tick Formatters</h1>
<a href='/cookbook/5.0/CustomizingTicks/CustomTickFormatter' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Users can customize the logic used to create tick labels from tick positions. Old versions of ScottPlot achieved this using a ManualTickPositions method.

[![](/cookbook/5.0/images/CustomTickFormatter.png?241103171511)](/cookbook/5.0/images/CustomTickFormatter.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/CustomTickFormatter.png?241103171511" >}}ScottPlot.Plot myPlot = new();

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
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>DateTimeAutomatic Tick Formatters</h1>
<a href='/cookbook/5.0/CustomizingTicks/DateTimeAutomaticTickFormatter' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Users can customize the logic used to create datetime tick labels from tick positions. 

[![](/cookbook/5.0/images/DateTimeAutomaticTickFormatter.png?241103171511)](/cookbook/5.0/images/DateTimeAutomaticTickFormatter.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/DateTimeAutomaticTickFormatter.png?241103171511" >}}ScottPlot.Plot myPlot = new();

// plot data using DateTime values on the horizontal axis
DateTime[] xs = Generate.ConsecutiveHours(100);
double[] ys = Generate.RandomWalk(100);
myPlot.Add.Scatter(xs, ys);

// setup the bottom axis to use DateTime ticks
var axis = myPlot.Axes.DateTimeTicksBottom();

// create a custom formatter to return a string with
// date only when zoomed out and time only when zoomed in
static string CustomFormatter(DateTime dt)
{
    bool isMidnight = dt is { Hour: 0, Minute: 0, Second: 0 };
    return isMidnight
        ? DateOnly.FromDateTime(dt).ToString()
        : TimeOnly.FromDateTime(dt).ToString();
}

// apply our custom tick formatter
DateTimeAutomatic tickGen = (DateTimeAutomatic)axis.TickGenerator;
tickGen.LabelFormatter = CustomFormatter;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Custom Tick Generators</h1>
<a href='/cookbook/5.0/CustomizingTicks/AltTickGen' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Tick generators determine where ticks are to be placed and also contain logic for generating tick labels from tick positions. Alternative tick generators can be created and assigned to axes. Some common tick generators are provided with ScottPlot, and users also have the option create their own.

[![](/cookbook/5.0/images/AltTickGen.png?241103171511)](/cookbook/5.0/images/AltTickGen.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/AltTickGen.png?241103171511" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericFixedInterval(11);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SetTicks Shortcut</h1>
<a href='/cookbook/5.0/CustomizingTicks/SetTicks' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The default axes have a SetTicks() helper method which replaces the default tick generator with a manual tick generator pre-loaded with the provided ticks.

[![](/cookbook/5.0/images/SetTicks.png?241103171511)](/cookbook/5.0/images/SetTicks.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/SetTicks.png?241103171511" >}}ScottPlot.Plot myPlot = new();

// display sample data
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// use manually defined ticks
double[] tickPositions = { 10, 25, 40 };
string[] tickLabels = { "Alpha", "Beta", "Gamma" };
myPlot.Axes.Bottom.SetTicks(tickPositions, tickLabels);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Custom Tick Positions</h1>
<a href='/cookbook/5.0/CustomizingTicks/CustomTicks' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Users desiring more control over major and minor tick positions and labels can instantiate a manual tick generator, set it up as desired, then assign it to the axis being customized

[![](/cookbook/5.0/images/CustomTicks.png?241103171511)](/cookbook/5.0/images/CustomTicks.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/CustomTicks.png?241103171511" >}}ScottPlot.Plot myPlot = new();

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
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Rotated Tick Labels</h1>
<a href='/cookbook/5.0/CustomizingTicks/RotatedTicks' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Users can customize tick label rotation.

[![](/cookbook/5.0/images/RotatedTicks.png?241103171511)](/cookbook/5.0/images/RotatedTicks.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/RotatedTicks.png?241103171511" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Axes.Bottom.TickLabelStyle.Rotation = -45;
myPlot.Axes.Bottom.TickLabelStyle.Alignment = Alignment.MiddleRight;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Rotated Tick with Long Labels</h1>
<a href='/cookbook/5.0/CustomizingTicks/RotatedTicksLongLabels' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The axis size can be increased to accommodate rotated or long tick labels.

[![](/cookbook/5.0/images/RotatedTicksLongLabels.png?241103171511)](/cookbook/5.0/images/RotatedTicksLongLabels.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/RotatedTicksLongLabels.png?241103171511" >}}ScottPlot.Plot myPlot = new();

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
using SKPaint paint = new();
foreach (Tick tick in ticks)
{
    PixelSize size = myPlot.Axes.Bottom.TickLabelStyle.Measure(tick.Label, paint).Size;
    largestLabelWidth = Math.Max(largestLabelWidth, size.Width);
}

// ensure axis panels do not get smaller than the largest label
myPlot.Axes.Bottom.MinimumSize = largestLabelWidth;
myPlot.Axes.Right.MinimumSize = largestLabelWidth;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Disable Grid Lines</h1>
<a href='/cookbook/5.0/CustomizingTicks/DisableGridLines' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Users can disable grid lines for specific axes.

[![](/cookbook/5.0/images/DisableGridLines.png?241103171511)](/cookbook/5.0/images/DisableGridLines.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/DisableGridLines.png?241103171511" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Grid.XAxisStyle.IsVisible = true;
myPlot.Grid.YAxisStyle.IsVisible = false;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Minimum Tick Spacing</h1>
<a href='/cookbook/5.0/CustomizingTicks/MinimumTickSpacing' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Space between ticks can be increased by setting a value to indicate the minimum distance between tick labels (in pixels).

[![](/cookbook/5.0/images/MinimumTickSpacing.png?241103171511)](/cookbook/5.0/images/MinimumTickSpacing.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/MinimumTickSpacing.png?241103171511" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

ScottPlot.TickGenerators.NumericAutomatic tickGenX = new();
tickGenX.MinimumTickSpacing = 50;
myPlot.Axes.Bottom.TickGenerator = tickGenX;

ScottPlot.TickGenerators.NumericAutomatic tickGenY = new();
tickGenY.MinimumTickSpacing = 25;
myPlot.Axes.Left.TickGenerator = tickGenY;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Tick Density</h1>
<a href='/cookbook/5.0/CustomizingTicks/TickDensity' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Tick density can be adjusted as a fraction of the default value. Unlike MinimumTickSpacing, this strategy is aware of the size of tick labels and adjusts accordingly.

[![](/cookbook/5.0/images/TickDensity.png?241103171511)](/cookbook/5.0/images/TickDensity.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/TickDensity.png?241103171511" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

ScottPlot.TickGenerators.NumericAutomatic tickGenX = new();
tickGenX.TickDensity = 0.2;
myPlot.Axes.Bottom.TickGenerator = tickGenX;

ScottPlot.TickGenerators.NumericAutomatic tickGenY = new();
tickGenY.TickDensity = 0.2;
myPlot.Axes.Left.TickGenerator = tickGenY;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Tick Count</h1>
<a href='/cookbook/5.0/CustomizingTicks/TickCount' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A target number of ticks can be provided and the automatic tick generator will attempt to place that number of ticks. This strategy allows tick density to decrease as the image size increases.

[![](/cookbook/5.0/images/TickCount.png?241103171511)](/cookbook/5.0/images/TickCount.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/TickCount.png?241103171511" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

ScottPlot.TickGenerators.NumericAutomatic tickGenX = new();
tickGenX.TargetTickCount = 3;
myPlot.Axes.Bottom.TickGenerator = tickGenX;

ScottPlot.TickGenerators.NumericAutomatic tickGenY = new();
tickGenY.TargetTickCount = 3;
myPlot.Axes.Left.TickGenerator = tickGenY;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Minor Tick Density</h1>
<a href='/cookbook/5.0/CustomizingTicks/StandardMinorTickDistribution' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Minor tick marks are automatically generated at intervals between major tick marks. By default they are evenly spaced, but their density may be customized.

[![](/cookbook/5.0/images/StandardMinorTickDistribution.png?241103171511)](/cookbook/5.0/images/StandardMinorTickDistribution.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/StandardMinorTickDistribution.png?241103171511" >}}ScottPlot.Plot myPlot = new();

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
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Log Scale Tick Marks</h1>
<a href='/cookbook/5.0/CustomizingTicks/LogScaleTicks' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The appearance of logarithmic scaling can be achieved by log-scaling the data to be displayed then customizing the minor ticks and grid.

[![](/cookbook/5.0/images/LogScaleTicks.png?241103171511)](/cookbook/5.0/images/LogScaleTicks.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/LogScaleTicks.png?241103171511" >}}ScottPlot.Plot myPlot = new();

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
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


