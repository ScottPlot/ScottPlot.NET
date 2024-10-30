---
Title: Bars with Labeled Ticks - ScottPlot 5.0 Cookbook
Description: Bars can be labeled by manually specifying axis tick mark positions and labels.
URL: /cookbook/5.0/Bar/BarTickLabels/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Bars with Labeled Ticks"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarTickLabels"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Bar/BarTickLabels'>Bars with Labeled Ticks</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Bar/BarTickLabels">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Bar">Category: Bar Plot</a>
</div>

Bars can be labeled by manually specifying axis tick mark positions and labels.

[![](/cookbook/5.0/images/BarTickLabels.png?241029205813)](/cookbook/5.0/images/BarTickLabels.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Bar(position: 1, value: 5, error: 1);
myPlot.Add.Bar(position: 2, value: 7, error: 2);
myPlot.Add.Bar(position: 3, value: 6, error: 1);
myPlot.Add.Bar(position: 4, value: 8, error: 2);

Tick[] ticks =
{
    new(1, "Apple"),
    new(2, "Orange"),
    new(3, "Pear"),
    new(4, "Banana"),
};

myPlot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
myPlot.Axes.Bottom.MajorTickStyle.Length = 0;
myPlot.HideGrid();

// tell the plot to autoscale with no padding beneath the bars
myPlot.Axes.Margins(bottom: 0);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


