---
Title: DateTime Axis Fixed Interval Ticks - ScottPlot 5.0 Cookbook
Description: Make ticks render at fixed intervals. Optionally make the ticks render from a custom start date, rather than using the start date of the plot (e.g. to draw ticks on the hour every hour, or on the first of every month, etc).
URL: /cookbook/5.0/AxisAndTicks/DateTimeAxisFixedIntervalTicks/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "DateTime Axis Fixed Interval Ticks"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/DateTimeAxisFixedIntervalTicks"]
Date: 2024-11-03
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>DateTime Axis Fixed Interval Ticks</h1>
</div>

Make ticks render at fixed intervals. Optionally make the ticks render from a custom start date, rather than using the start date of the plot (e.g. to draw ticks on the hour every hour, or on the first of every month, etc).

[![](/cookbook/5.0/images/DateTimeAxisFixedIntervalTicks.png?241103171511)](/cookbook/5.0/images/DateTimeAxisFixedIntervalTicks.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/AxisRecipes.cs" imageUrl="/cookbook/5.0/images/DateTimeAxisFixedIntervalTicks.png?241103171511" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/AxisAndTicks'>Axis and Ticks</a> category</div>


