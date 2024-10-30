---
Title: Bar with Value Labels (horizontal) - ScottPlot 5.0 Cookbook
Description: Set the `Label` property of bars to have text displayed beside (left or right) of each bar.
URL: /cookbook/5.0/Bar/BarValuesHorizontal/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Bar with Value Labels (horizontal)"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarValuesHorizontal"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Bar/BarValuesHorizontal'>Bar with Value Labels (horizontal)</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Bar/BarValuesHorizontal">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Bar">Category: Bar Plot</a>
</div>

Set the `Label` property of bars to have text displayed beside (left or right) of each bar.

[![](/cookbook/5.0/images/BarValuesHorizontal.png?241029205813)](/cookbook/5.0/images/BarValuesHorizontal.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] values = { -20, 10, 7, 13 };

// set the label for each bar
var barPlot = myPlot.Add.Bars(values);
foreach (var bar in barPlot.Bars)
{
    bar.Label = "Label " + bar.Value.ToString();
}

// customize label style
barPlot.ValueLabelStyle.Bold = true;
barPlot.ValueLabelStyle.FontSize = 18;
barPlot.Horizontal = true;

// add extra margin to account for label
myPlot.Axes.SetLimitsX(-45, 35);
myPlot.Add.VerticalLine(0, 1, Colors.Black);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


