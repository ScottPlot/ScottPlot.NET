---
Title: SignalXY DateTime Axis - ScottPlot 5.0 Cookbook
Description: SignalXY plots can display unevenly spaced time series data using a DateTime horizontal axis.
URL: /cookbook/5.0/SignalXY/SignalXYDateTime/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalXY Plot", "SignalXY DateTime Axis"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalXY", "/cookbook/5.0/SignalXY/SignalXYDateTime"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SignalXY DateTime Axis</h1>
</div>

SignalXY plots can display unevenly spaced time series data using a DateTime horizontal axis.

[![](/cookbook/5.0/images/SignalXYDateTime.png?250822231048)](/cookbook/5.0/images/SignalXYDateTime.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5.0/images/SignalXYDateTime.png?250822231048" >}}ScottPlot.Plot myPlot = new();

DateTime start = new(2024, 01, 01);
DateTime[] xs = Generate.ConsecutiveDays(100, start);

double[] ys = Generate.RandomWalk(100);

myPlot.Add.SignalXY(xs, ys);
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/SignalXY'>SignalXY Plot</a> category</div>


