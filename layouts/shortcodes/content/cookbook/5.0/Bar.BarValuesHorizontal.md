---
Title: Bar with Value Labels (horizontal) - ScottPlot 5.0 Cookbook
Description: Set the `Label` property of bars to have text displayed beside (left or right) of each bar.
URL: /cookbook/5.0/Bar/BarValuesHorizontal/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Bar with Value Labels (horizontal)"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarValuesHorizontal"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Bar with Value Labels (horizontal)</h1>
</div>

Set the `Label` property of bars to have text displayed beside (left or right) of each bar.

[![](/cookbook/5.0/images/BarValuesHorizontal.png?250322130304)](/cookbook/5.0/images/BarValuesHorizontal.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Bar.cs" imageUrl="/cookbook/5.0/images/BarValuesHorizontal.png?250322130304" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Bar'>Bar Plot</a> category</div>


