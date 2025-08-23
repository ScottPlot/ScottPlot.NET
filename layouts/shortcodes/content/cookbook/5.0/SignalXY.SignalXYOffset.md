---
Title: SignalXY Offset - ScottPlot 5.0 Cookbook
Description: A fixed offset can be applied to SignalXY plots.
URL: /cookbook/5.0/SignalXY/SignalXYOffset/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalXY Plot", "SignalXY Offset"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalXY", "/cookbook/5.0/SignalXY/SignalXYOffset"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SignalXY Offset</h1>
</div>

A fixed offset can be applied to SignalXY plots.

[![](/cookbook/5.0/images/SignalXYOffset.png?250822231048)](/cookbook/5.0/images/SignalXYOffset.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5.0/images/SignalXYOffset.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(1000);
double[] ys = Generate.Sin(1000);

var sig1 = myPlot.Add.SignalXY(xs, ys);

var sig2 = myPlot.Add.SignalXY(xs, ys);
sig2.Data.XOffset = 250;
sig2.Data.YOffset = .5;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/SignalXY'>SignalXY Plot</a> category</div>


