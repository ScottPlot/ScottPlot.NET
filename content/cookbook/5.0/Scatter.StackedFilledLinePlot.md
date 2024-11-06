---
Title: Stacked Filled Line Plot - ScottPlot 5.0 Cookbook
Description: A stacked filled line plot effect can be achieved by overlapping ScatterLines that fill area.
URL: /cookbook/5.0/Scatter/StackedFilledLinePlot/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Stacked Filled Line Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/StackedFilledLinePlot"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Stacked Filled Line Plot</h1>
</div>

A stacked filled line plot effect can be achieved by overlapping ScatterLines that fill area.

[![](/cookbook/5.0/images/StackedFilledLinePlot.png?241105214550)](/cookbook/5.0/images/StackedFilledLinePlot.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/StackedFilledLinePlot.png?241105214550" >}}ScottPlot.Plot myPlot = new();

// create sample data
double[] xs = { 1, 2, 3, 4 };
double[] ys1 = { 1, 3, 1, 2 };
double[] ys2 = { 3, 7, 3, 1 };
double[] ys3 = { 5, 2, 5, 6 };

// shift each plot vertically by the sum of all plots before it
ys2 = Enumerable.Range(0, ys2.Length).Select(x =&gt; ys2[x] + ys1[x]).ToArray();
ys3 = Enumerable.Range(0, ys2.Length).Select(x =&gt; ys3[x] + ys2[x]).ToArray();

// plot the padded data points as ScatterLine
var sp3 = myPlot.Add.ScatterLine(xs, ys3, Colors.Black);
var sp2 = myPlot.Add.ScatterLine(xs, ys2, Colors.Black);
var sp1 = myPlot.Add.ScatterLine(xs, ys1, Colors.Black);

// set plot style
sp1.LineWidth = 2;
sp2.LineWidth = 2;
sp3.LineWidth = 2;
sp1.FillY = true;
sp2.FillY = true;
sp3.FillY = true;
sp1.FillYColor = Colors.Green;
sp2.FillYColor = Colors.Orange;
sp3.FillYColor = Colors.Blue;

// use tight margins so data goes to the edge of the plot
myPlot.Axes.Margins(0, 0, 0, 0.1);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Scatter'>Scatter Plot</a> category</div>


