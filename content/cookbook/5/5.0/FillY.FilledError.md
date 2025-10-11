---
Title: Filled Error - ScottPlot 5.0 Cookbook
Description: A line plot with shaded error range may be achieved by layering a FillY beneath a ScatterLine.
URL: /cookbook/5.0/FillY/FilledError/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "FillY plot", "Filled Error"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/FillY", "/cookbook/5.0/FillY/FilledError"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Filled Error</h1>
</div>

A line plot with shaded error range may be achieved by layering a FillY beneath a ScatterLine.

[![](/cookbook/5.0/images/FilledError.png?250126165944)](/cookbook/5.0/images/FilledError.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/FillY.cs" imageUrl="/cookbook/5.0/images/FilledError.png?250126165944" >}}ScottPlot.Plot myPlot = new();

// create sample Y values
double[] xs = Generate.Range(0, Math.PI, 0.05);
double[] ys = xs.Select(x =&gt; Math.Sin(x) + Generate.RandomNumber(0.1)).ToArray();

// create sample error data
double[] yErr = ys.Select(x =&gt; x * Generate.RandomNumber(0.5) + 0.05).ToArray();

// calculate Y ± error
double[] yErrNeg = Enumerable.Range(0, ys.Length).Select(x =&gt; ys[x] - yErr[x]).ToArray();
double[] yErrPos = Enumerable.Range(0, ys.Length).Select(x =&gt; ys[x] + yErr[x]).ToArray();

// add a shaded area between the error limits
var errFill = myPlot.Add.FillY(xs, yErrNeg, yErrPos);
errFill.LineWidth = 0;
errFill.FillColor = Colors.Blue.WithAlpha(0.2);
errFill.LegendText = "Error";

// add the Y values as a line plot
var meanLine = myPlot.Add.ScatterLine(xs, ys);
meanLine.LineColor = Colors.Blue;
meanLine.LineWidth = 2;
meanLine.LegendText = "Mean";

// configure the location of the legend
myPlot.Legend.Alignment = Alignment.UpperRight;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/FillY'>FillY plot</a> category</div>


