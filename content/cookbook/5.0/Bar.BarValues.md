---
Title: Bar with Value Labels - ScottPlot 5.0 Cookbook
Description: Set the `Label` property of bars to have text displayed above each bar.
URL: /cookbook/5.0/Bar/BarValues/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Bar with Value Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarValues"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Bar with Value Labels</h1>
</div>

Set the `Label` property of bars to have text displayed above each bar.

[![](/cookbook/5.0/images/BarValues.png?241102170938)](/cookbook/5.0/images/BarValues.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Bar.cs" imageUrl="/cookbook/5.0/images/BarValues.png?241102170938" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Bar'>Bar Plot</a> category</div>


