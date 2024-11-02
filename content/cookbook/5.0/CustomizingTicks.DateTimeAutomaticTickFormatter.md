---
Title: DateTimeAutomatic Tick Formatters - ScottPlot 5.0 Cookbook
Description: Users can customize the logic used to create datetime tick labels from tick positions. 
URL: /cookbook/5.0/CustomizingTicks/DateTimeAutomaticTickFormatter/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "DateTimeAutomatic Tick Formatters"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/DateTimeAutomaticTickFormatter"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>DateTimeAutomatic Tick Formatters</h1>
</div>

Users can customize the logic used to create datetime tick labels from tick positions. 

[![](/cookbook/5.0/images/DateTimeAutomaticTickFormatter.png?241102170938)](/cookbook/5.0/images/DateTimeAutomaticTickFormatter.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/DateTimeAutomaticTickFormatter.png?241102170938" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/CustomizingTicks'>Customizing Ticks</a> category</div>


