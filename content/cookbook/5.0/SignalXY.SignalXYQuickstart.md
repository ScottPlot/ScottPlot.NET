---
Title: SignalXY Quickstart - ScottPlot 5.0 Cookbook
Description: SignalXY plots are a high performance plot type for X/Y data where the X values are always ascending.
URL: /cookbook/5.0/SignalXY/SignalXYQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalXY Plot", "SignalXY Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalXY", "/cookbook/5.0/SignalXY/SignalXYQuickstart"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/SignalXY/SignalXYQuickstart'>SignalXY Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/SignalXY/SignalXYQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/SignalXY">Category: SignalXY Plot</a>
</div>

SignalXY plots are a high performance plot type for X/Y data where the X values are always ascending.

[![](/cookbook/5.0/images/SignalXYQuickstart.png?241031194635)](/cookbook/5.0/images/SignalXYQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// generate sample data with gaps
List<double> xList = new();
List<double> yList = new();
for (int i = 0; i < 5; i++)
{
    xList.AddRange(Generate.Consecutive(1000, first: 2000 * i));
    yList.AddRange(Generate.RandomSample(1000));
}
double[] xs = xList.ToArray();
double[] ys = yList.ToArray();

// add a SignalXY plot
myPlot.Add.SignalXY(xs, ys);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


