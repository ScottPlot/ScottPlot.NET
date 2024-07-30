---
Title: DateTime Axis Fixed Interval Ticks - ScottPlot 5.0 Cookbook
Description: Make ticks render at fixed intervals. Optionally make the ticks render from a custom start date, rather than using the start date of the plot (e.g. to draw ticks on the hour every hour, or on the first of every month, etc).
URL: /cookbook/5.0/DateTimeAxes/DateTimeAxisFixedIntervalTicks/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "DateTime Axes", "DateTime Axis Fixed Interval Ticks"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/DateTimeAxes", "/cookbook/5.0/DateTimeAxes/DateTimeAxisFixedIntervalTicks"]
Date: 2024-07-30
Version: ScottPlot 5.0.37
Version: ScottPlot 5.0.37
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# DateTime Axis Fixed Interval Ticks


Make ticks render at fixed intervals. Optionally make the ticks render from a custom start date, rather than using the start date of the plot (e.g. to draw ticks on the hour every hour, or on the first of every month, etc).

[![](/cookbook/5.0/images/DateTimeAxisFixedIntervalTicks.png?240729212327)](/cookbook/5.0/images/DateTimeAxisFixedIntervalTicks.png?240729212327)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

// Plot 24 hours sample DateTime data (1 point every minute)
DateTime[] dates = Generate.ConsecutiveMinutes(24 * 60, new DateTime(2000, 1, 1, 2, 12, 0));
double[] ys = Generate.RandomWalk(24 * 60);
myPlot.Add.Scatter(dates, ys);
var dtAx = myPlot.Axes.DateTimeTicksBottom();

// Create fixed-intervals ticks, major ticks every 6 hours, minor ticks every hour
dtAx.TickGenerator = new DateTimeFixedInterval(
    new Hour(), 6,
    new Hour(), 1,
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

```

{{< /code-sp5 >}}

<a href='https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Axis/DateTimeAxes.cs'><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="mb-1 bi bi-github" viewBox="0 0 16 16">
  <path d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27s1.36.09 2 .27c1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.01 8.01 0 0 0 16 8c0-4.42-3.58-8-8-8"/>
</svg> Edit on GitHub</a>

