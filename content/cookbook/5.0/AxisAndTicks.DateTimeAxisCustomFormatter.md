---
Title: Custom DateTime Label Format - ScottPlot 5.0 Cookbook
Description: Users can provide their own logic for customizing DateTime tick labels
URL: /cookbook/5.0/AxisAndTicks/DateTimeAxisCustomFormatter/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "Custom DateTime Label Format"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/DateTimeAxisCustomFormatter"]
Date: 2024-11-03
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Custom DateTime Label Format</h1>
</div>

Users can provide their own logic for customizing DateTime tick labels

[![](/cookbook/5.0/images/DateTimeAxisCustomFormatter.png?241103171511)](/cookbook/5.0/images/DateTimeAxisCustomFormatter.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/AxisRecipes.cs" imageUrl="/cookbook/5.0/images/DateTimeAxisCustomFormatter.png?241103171511" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/AxisAndTicks'>Axis and Ticks</a> category</div>


