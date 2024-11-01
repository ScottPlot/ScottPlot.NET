---
Title: Axis and Ticks - ScottPlot 5.0 Cookbook
Description: Examples of common customizations for axis labels and ticks
URL: /cookbook/5.0/AxisAndTicks/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Axis and Ticks</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Set Axis Limits</h1>
<a href='/cookbook/5.0/AxisAndTicks/SetAxisLimits' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Axis Limits can be set by the user.

[![](/cookbook/5.0/images/SetAxisLimits.png?241101192719)](/cookbook/5.0/images/SetAxisLimits.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.Axes.SetLimits(-100, 150, -5, 5);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Read Axis Limits</h1>
<a href='/cookbook/5.0/AxisAndTicks/GetAxisLimits' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Use GetLimits() to obtain the current axis limits.

[![](/cookbook/5.0/images/GetAxisLimits.png?241101192719)](/cookbook/5.0/images/GetAxisLimits.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

AxisLimits limits = myPlot.Axes.GetLimits();
double xMin = limits.Left;
double xMax = limits.Right;
double yMin = limits.Bottom;
double yMax = limits.Top;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>AutoScale Axis Limits to Fit Data</h1>
<a href='/cookbook/5.0/AxisAndTicks/AutoScale' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The axis limits can be automatically adjusted to fit the data. Optional arguments allow users to define the amount of whitespace around the edges of the data.In older versions of ScottPlot this functionality was achieved by a method named AxisAuto().

[![](/cookbook/5.0/images/AutoScale.png?241101192719)](/cookbook/5.0/images/AutoScale.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

// set limits that do not fit the data
myPlot.Axes.SetLimits(-100, 150, -5, 5);

// reset limits to fit the data
myPlot.Axes.AutoScale();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Inverted Axis</h1>
<a href='/cookbook/5.0/AxisAndTicks/InvertedAxis' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Users can display data on an inverted axis by setting axis limits setting the lower edge to a value more positive than the upper edge.

[![](/cookbook/5.0/images/InvertedAxis.png?241101192719)](/cookbook/5.0/images/InvertedAxis.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Axes.SetLimitsY(bottom: 1.5, top: -1.5);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Inverted Auto-Axis</h1>
<a href='/cookbook/5.0/AxisAndTicks/InvertedAutoAxis' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Customize the logic for the automatic axis scaler to ensure that axis limits for a particular axis are always inverted when autoscaled.

[![](/cookbook/5.0/images/InvertedAutoAxis.png?241101192719)](/cookbook/5.0/images/InvertedAutoAxis.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Axes.AutoScaler.InvertedY = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Square Axis Units</h1>
<a href='/cookbook/5.0/AxisAndTicks/SquareAxisUnits' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Axis rules can be put in place which force the vertical scale (units per pixel) to match the horizontal scale so circles always appear as circles and not stretched ellipses.

[![](/cookbook/5.0/images/SquareAxisUnits.png?241101192719)](/cookbook/5.0/images/SquareAxisUnits.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Circle(0, 0, 10);

// force pixels to have a 1:1 scale ratio
myPlot.Axes.SquareUnits();

// even if you try to "stretch" the axis, it will adjust the axis limits automatically
myPlot.Axes.SetLimits(-10, 10, -20, 20);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis with Subtitle</h1>
<a href='/cookbook/5.0/AxisAndTicks/ExperimentalAxisWithSubtitle' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Users can create their own fully custom axes to replace the default ones (as demonstrated in the demo app). Some experimental axes are available for users who may be interested in alternative axis display styles.

[![](/cookbook/5.0/images/ExperimentalAxisWithSubtitle.png?241101192719)](/cookbook/5.0/images/ExperimentalAxisWithSubtitle.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// Plot some sample data
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// Instantiate a custom axis and customize it as desired
ScottPlot.AxisPanels.Experimental.LeftAxisWithSubtitle customAxisY = new()
{
    LabelText = "My Custom Y Axis",
    SubLabelText = "It comes with a subtitle for the axis"
};

// Remove the default Y axis and add the custom one to the plot
myPlot.Axes.Remove(myPlot.Axes.Left);
myPlot.Axes.AddLeftAxis(customAxisY);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis AntiAliasing</h1>
<a href='/cookbook/5.0/AxisAndTicks/AxisAntiAliasing' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

To improve crispness of straight vertical and horizontal lines, Anti-aliasing is disabled by default for axis frames, tick marks, and grid lines. Anti-aliasing can be enabled for all these objects by calling the AntiAlias helper method.

[![](/cookbook/5.0/images/AxisAntiAliasing.png?241101192719)](/cookbook/5.0/images/AxisAntiAliasing.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };
myPlot.Add.Scatter(dataX, dataY);

myPlot.Axes.AntiAlias(true);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Hide Axis and Turn frame lines on/off</h1>
<a href='/cookbook/5.0/AxisAndTicks/HideAxis' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Demonstrates how to hide axis ticks and turn frame lines on and off.

[![](/cookbook/5.0/images/HideAxis.png?241101192719)](/cookbook/5.0/images/HideAxis.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// Hide axis label and tick
myPlot.Axes.Bottom.TickLabelStyle.IsVisible = false;
myPlot.Axes.Bottom.MajorTickStyle.Length = 0;
myPlot.Axes.Bottom.MinorTickStyle.Length = 0;

// Hide axis edge line
myPlot.Axes.Bottom.FrameLineStyle.Width = 0;
myPlot.Axes.Right.FrameLineStyle.Width = 0;
myPlot.Axes.Top.FrameLineStyle.Width = 0;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>DateTime Axis Quickstart</h1>
<a href='/cookbook/5.0/AxisAndTicks/DateTimeAxisQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Axis tick labels can be displayed using a time format.

[![](/cookbook/5.0/images/DateTimeAxisQuickstart.png?241101192719)](/cookbook/5.0/images/DateTimeAxisQuickstart.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// plot data using DateTime units
DateTime[] dates = Generate.ConsecutiveDays(100);
double[] ys = Generate.RandomWalk(100);
myPlot.Add.Scatter(dates, ys);

// tell the plot to display dates on the bottom axis
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>DateTime Axis Values</h1>
<a href='/cookbook/5.0/AxisAndTicks/DateTimeAxisMixed' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

DateTime axes are achieved using Microsoft's DateTime.ToOADate() and DateTime.FromOADate() methods to convert between dates and numeric values. Advanced users who wish to display data on DateTime axes may prefer to work with collections of doubles rather than collections of DateTimes.

[![](/cookbook/5.0/images/DateTimeAxisMixed.png?241101192719)](/cookbook/5.0/images/DateTimeAxisMixed.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// create an array of DateTimes one hour apart
int numberOfHours = 24;
DateTime[] dateTimes = new DateTime[numberOfHours];
DateTime startDateTime = new(2024, 1, 1);
TimeSpan deltaTimeSpan = TimeSpan.FromHours(1);
for (int i = 0; i < numberOfHours; i++)
{
    dateTimes[i] = startDateTime + i * deltaTimeSpan;
}

// create an array of doubles representing the same DateTimes one hour apart
double[] dateDoubles = new double[numberOfHours];
double startDouble = startDateTime.ToOADate(); // days since 1900
double deltaDouble = 1.0 / 24.0; // an hour is 1/24 of a day
for (int i = 0; i < numberOfHours; i++)
{
    dateDoubles[i] = startDouble + i * deltaDouble;
}

// now both arrays represent the same dates
myPlot.Add.Scatter(dateTimes, Generate.Sin(numberOfHours));
myPlot.Add.Scatter(dateDoubles, Generate.Cos(numberOfHours));
myPlot.Axes.DateTimeTicksBottom();

// add padding on the right to make room for wide tick labels
myPlot.Axes.Right.MinimumSize = 50;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Custom DateTime Label Format</h1>
<a href='/cookbook/5.0/AxisAndTicks/DateTimeAxisCustomFormatter' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Users can provide their own logic for customizing DateTime tick labels

[![](/cookbook/5.0/images/DateTimeAxisCustomFormatter.png?241101192719)](/cookbook/5.0/images/DateTimeAxisCustomFormatter.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// plot sample DateTime data
DateTime[] dates = Generate.ConsecutiveDays(100);
double[] ys = Generate.RandomWalk(100);
myPlot.Add.Scatter(dates, ys);
myPlot.Axes.DateTimeTicksBottom();

// add logic into the RenderStarting event to customize tick labels
myPlot.RenderManager.RenderStarting += (s, e) =>
{
    Tick[] ticks = myPlot.Axes.Bottom.TickGenerator.Ticks;
    for (int i = 0; i < ticks.Length; i++)
    {
        DateTime dt = DateTime.FromOADate(ticks[i].Position);
        string label = $"{dt:MMM} '{dt:yy}";
        ticks[i] = new Tick(ticks[i].Position, label);
    }
};

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>DateTime Axis Fixed Interval Ticks</h1>
<a href='/cookbook/5.0/AxisAndTicks/DateTimeAxisFixedIntervalTicks' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Make ticks render at fixed intervals. Optionally make the ticks render from a custom start date, rather than using the start date of the plot (e.g. to draw ticks on the hour every hour, or on the first of every month, etc).

[![](/cookbook/5.0/images/DateTimeAxisFixedIntervalTicks.png?241101192719)](/cookbook/5.0/images/DateTimeAxisFixedIntervalTicks.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// Plot 24 hours sample DateTime data (1 point every minute)
DateTime[] dates = Generate.ConsecutiveMinutes(24 * 60, new DateTime(2000, 1, 1, 2, 12, 0));
double[] ys = Generate.RandomWalk(24 * 60);
myPlot.Add.Scatter(dates, ys);
var dtAx = myPlot.Axes.DateTimeTicksBottom();

// Create fixed-intervals ticks, major ticks every 6 hours, minor ticks every hour
dtAx.TickGenerator = new ScottPlot.TickGenerators.DateTimeFixedInterval(
    new ScottPlot.TickGenerators.TimeUnits.Hour(), 6,
    new ScottPlot.TickGenerators.TimeUnits.Hour(), 1,
    // Here we provide a delegate to override when the ticks start. In this case, we want the majors to be
    // 00:00, 06:00, 12:00, etc. and the minors to be on the hour, every hour, so we start at midnight.
    // If you do not provide this delegate, the ticks will start at whatever the Min on the x-axis is.
    // The major ticks might end up as 1:30am, 7:30am, etc, and the tick positions will be fixed on the plot
    // when it is panned around.
    dt => new DateTime(dt.Year, dt.Month, dt.Day));

// Customise gridlines to make the ticks easier to see
myPlot.Grid.XAxisStyle.MajorLineStyle.Color = Colors.Black.WithOpacity();
myPlot.Grid.XAxisStyle.MajorLineStyle.Width = 2;

myPlot.Grid.XAxisStyle.MinorLineStyle.Color = Colors.Gray.WithOpacity(0.25);
myPlot.Grid.XAxisStyle.MinorLineStyle.Width = 1;
myPlot.Grid.XAxisStyle.MinorLineStyle.Pattern = LinePattern.DenselyDashed;

// Remove labels on minor ticks, otherwise there is a lot of tick label overlap
myPlot.RenderManager.RenderStarting += (s, e) =>
{
    Tick[] ticks = myPlot.Axes.Bottom.TickGenerator.Ticks;
    for (int i = 0; i < ticks.Length; i++)
    {
        if (ticks[i].IsMajor)
        {
            continue;
        }

        ticks[i] = new Tick(ticks[i].Position, "", ticks[i].IsMajor);
    }
};

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


