---
Title: Custom Tick DateTimes - ScottPlot 5 Cookbook
Description: Users may define custom ticks using DateTime units
URL: /cookbook/5/CustomizingTicks/CustomTicksDateTime/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Customizing Ticks", "Custom Tick DateTimes"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/CustomizingTicks", "/cookbook/5/CustomizingTicks/CustomTicksDateTime"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Custom Tick DateTimes</h1>
</div>

Users may define custom ticks using DateTime units

[![](/cookbook/5/images/CustomTicksDateTime.png?260329072039)](/cookbook/5/images/CustomTicksDateTime.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5/images/CustomTicksDateTime.png?260329072039" >}}ScottPlot.Plot myPlot = new();

DateTime[] dates = Generate.ConsecutiveDays(100);
double[] values = Generate.RandomWalk(100);
myPlot.Add.Scatter(dates, values);

// create a manual DateTime tick generator and add ticks
ScottPlot.TickGenerators.DateTimeManual ticks = new();

// add ticks for Mondays only
foreach (DateTime date in dates)
{
    if (date.DayOfWeek == DayOfWeek.Monday)
    {
        string label = date.DayOfYear.ToString();
        ticks.AddMajor(date, label);
    }
}

// tell the horizontal axis to use the custom tick generator
myPlot.Axes.Bottom.TickGenerator = ticks;

// style the plot
myPlot.Title("Monday Ticks");
myPlot.XLabel("Day of the Year");

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/CustomizingTicks'>Customizing Ticks</a> category</div>


