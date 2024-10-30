---
Title: Bar with Value Labels - ScottPlot 5.0 Cookbook
Description: Set the `Label` property of bars to have text displayed above each bar.
URL: /cookbook/5.0/Bar/BarValues/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Bar with Value Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarValues"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Bar/BarValues'>Bar with Value Labels</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Bar/BarValues">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Bar">Category: Bar Plot</a>
</div>

Set the `Label` property of bars to have text displayed above each bar.

[![](/cookbook/5.0/images/BarValues.png?241029205813)](/cookbook/5.0/images/BarValues.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] values = { 5, 10, 7, 13 };
var barPlot = myPlot.Add.Bars(values);

// define the content of labels
foreach (var bar in barPlot.Bars)
{
    bar.Label = bar.Value.ToString();
}

// customize label style
barPlot.ValueLabelStyle.Bold = true;
barPlot.ValueLabelStyle.FontSize = 18;

myPlot.Axes.Margins(bottom: 0, top: .2);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


