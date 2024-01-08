---
Title: "Plotting DateTime Data - ScottPlot 4.1 Cookbook"
Description: "This example shows how to display DateTime data on the horizontal axis. Use DateTime.ToOADate() to convert DateTime[] to double[], plot the data,  then tell the axis to format tick labels as dates."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/ticks_datetime/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Axis and Ticks", "Plotting DateTime Data"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/axis-and-ticks", "/cookbook/4.1/recipes/ticks_datetime/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/ticks_datetime.png"
---

<h2><a id='plotting-datetime-data' href='/cookbook/4.1/recipes/ticks_datetime/'>Plotting DateTime Data</a></h2>

This example shows how to display DateTime data on the horizontal axis. Use DateTime.ToOADate() to convert DateTime[] to double[], plot the data,  then tell the axis to format tick labels as dates.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

// create data sample data
DateTime[] myDates = new DateTime[100];
for (int i = 0; i < myDates.Length; i++)
    myDates[i] = new DateTime(1985, 9, 24).AddDays(7 * i);

// Convert DateTime[] to double[] before plotting
double[] xs = myDates.Select(x => x.ToOADate()).ToArray();
double[] ys = DataGen.RandomWalk(myDates.Length);
plt.AddScatter(xs, ys);

// Then tell the axis to display tick labels using a time format
plt.XAxis.DateTimeFormat(true);

plt.SaveFig("ticks_dateTime.png");
```

<img src='../../images/ticks_datetime.png' class='d-block mx-auto my-5' />


