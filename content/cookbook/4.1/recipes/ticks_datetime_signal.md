---
Title: "Plotting DateTime Data on a Signal Plot - ScottPlot 4.1 Cookbook"
Description: "DateTime can be displayed on the horizontal axis of a signal plot by using the sample rate to set the time interval per data point, and then setting the OffsetX to the desired start date."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/ticks_datetime_signal/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis and Ticks", "Plotting DateTime Data on a Signal Plot"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/axis-and-ticks", "/cookbook/4.1/recipes/ticks_datetime_signal/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ticks_datetime_signal.png"
---

<h2><a id='plotting-datetime-data-on-a-signal-plot' href='/cookbook/4.1/recipes/ticks_datetime_signal/'>Plotting DateTime Data on a Signal Plot</a></h2>

DateTime can be displayed on the horizontal axis of a signal plot by using the sample rate to set the time interval per data point, and then setting the OffsetX to the desired start date.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

// create data sample data
double[] ys = DataGen.RandomWalk(100);

TimeSpan ts = TimeSpan.FromSeconds(1); // time between data points
double sampleRate = (double)TimeSpan.TicksPerDay / ts.Ticks;
var signalPlot = plt.AddSignal(ys, sampleRate);

// Then tell the axis to display tick labels using a time format
plt.XAxis.DateTimeFormat(true);

// Set start date
signalPlot.OffsetX = new DateTime(1985, 10, 1).ToOADate();

plt.SaveFig("ticks_dateTime_signal.png");
```

<img src='../../images/ticks_datetime_signal.png' class='d-block mx-auto my-5' />


