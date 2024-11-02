---
Title: DateTime Axis Values - ScottPlot 5.0 Cookbook
Description: DateTime axes are achieved using Microsoft's DateTime.ToOADate() and DateTime.FromOADate() methods to convert between dates and numeric values. Advanced users who wish to display data on DateTime axes may prefer to work with collections of doubles rather than collections of DateTimes.
URL: /cookbook/5.0/AxisAndTicks/DateTimeAxisMixed/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "DateTime Axis Values"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/DateTimeAxisMixed"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>DateTime Axis Values</h1>
</div>

DateTime axes are achieved using Microsoft's DateTime.ToOADate() and DateTime.FromOADate() methods to convert between dates and numeric values. Advanced users who wish to display data on DateTime axes may prefer to work with collections of doubles rather than collections of DateTimes.

[![](/cookbook/5.0/images/DateTimeAxisMixed.png?241102170938)](/cookbook/5.0/images/DateTimeAxisMixed.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/AxisRecipes.cs" imageUrl="/cookbook/5.0/images/DateTimeAxisMixed.png?241102170938" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/AxisAndTicks'>Axis and Ticks</a> category</div>


