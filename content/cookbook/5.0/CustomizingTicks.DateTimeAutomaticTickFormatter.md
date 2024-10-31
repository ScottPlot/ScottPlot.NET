---
Title: DateTimeAutomatic Tick Formatters - ScottPlot 5.0 Cookbook
Description: Users can customize the logic used to create datetime tick labels from tick positions. 
URL: /cookbook/5.0/CustomizingTicks/DateTimeAutomaticTickFormatter/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "DateTimeAutomatic Tick Formatters"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/DateTimeAutomaticTickFormatter"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/CustomizingTicks/DateTimeAutomaticTickFormatter'>DateTimeAutomatic Tick Formatters</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/CustomizingTicks/DateTimeAutomaticTickFormatter">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/CustomizingTicks">Category: Customizing Ticks</a>
</div>

Users can customize the logic used to create datetime tick labels from tick positions. 

[![](/cookbook/5.0/images/DateTimeAutomaticTickFormatter.png?241031194635)](/cookbook/5.0/images/DateTimeAutomaticTickFormatter.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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


