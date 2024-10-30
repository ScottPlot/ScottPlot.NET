---
Title: Donut from Slices - ScottPlot 5.0 Cookbook
Description: A donut chart is a pie chart with an open center. Donut charts can be created from a collection of slices.
URL: /cookbook/5.0/Pie/PieDonut/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Pie", "Donut from Slices"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Pie", "/cookbook/5.0/Pie/PieDonut"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Pie/PieDonut'>Donut from Slices</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Pie/PieDonut">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Pie">Category: Pie</a>
</div>

A donut chart is a pie chart with an open center. Donut charts can be created from a collection of slices.

[![](/cookbook/5.0/images/PieDonut.png?241029205813)](/cookbook/5.0/images/PieDonut.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

List<PieSlice> slices = new()
{
    new PieSlice() { Value = 5, FillColor = Colors.Red, Label = "Red" },
    new PieSlice() { Value = 2, FillColor = Colors.Orange, Label = "Orange" },
    new PieSlice() { Value = 8, FillColor = Colors.Gold, Label = "Yellow" },
    new PieSlice() { Value = 4, FillColor = Colors.Green, Label = "Green" },
    new PieSlice() { Value = 8, FillColor = Colors.Blue, Label = "Blue" },
};

var pie = myPlot.Add.Pie(slices);
pie.DonutFraction = .5;

myPlot.ShowLegend();

// hide unnecessary plot components
myPlot.Axes.Frameless();
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


