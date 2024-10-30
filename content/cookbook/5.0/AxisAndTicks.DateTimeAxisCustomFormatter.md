---
Title: Custom DateTime Label Format - ScottPlot 5.0 Cookbook
Description: Users can provide their own logic for customizing DateTime tick labels
URL: /cookbook/5.0/AxisAndTicks/DateTimeAxisCustomFormatter/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "Custom DateTime Label Format"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/DateTimeAxisCustomFormatter"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/AxisAndTicks/DateTimeAxisCustomFormatter'>Custom DateTime Label Format</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/AxisAndTicks/DateTimeAxisCustomFormatter">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/AxisAndTicks">Category: Axis and Ticks</a>
</div>

Users can provide their own logic for customizing DateTime tick labels

[![](/cookbook/5.0/images/DateTimeAxisCustomFormatter.png?241029205813)](/cookbook/5.0/images/DateTimeAxisCustomFormatter.png?241029205813)

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


