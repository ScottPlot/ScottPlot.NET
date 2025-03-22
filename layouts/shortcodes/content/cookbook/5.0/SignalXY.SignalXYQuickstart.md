---
Title: SignalXY Quickstart - ScottPlot 5.0 Cookbook
Description: SignalXY plots are a high performance plot type for X/Y data where the X values are always ascending.
URL: /cookbook/5.0/SignalXY/SignalXYQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalXY Plot", "SignalXY Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalXY", "/cookbook/5.0/SignalXY/SignalXYQuickstart"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SignalXY Quickstart</h1>
</div>

SignalXY plots are a high performance plot type for X/Y data where the X values are always ascending.

[![](/cookbook/5.0/images/SignalXYQuickstart.png?250322130304)](/cookbook/5.0/images/SignalXYQuickstart.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5.0/images/SignalXYQuickstart.png?250322130304" >}}ScottPlot.Plot myPlot = new();

// generate sample data with gaps
List&lt;double&gt; xList = new();
List&lt;double&gt; yList = new();
for (int i = 0; i &lt; 5; i++)
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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/SignalXY'>SignalXY Plot</a> category</div>


