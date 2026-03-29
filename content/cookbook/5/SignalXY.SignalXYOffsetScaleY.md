---
Title: SignalXY Scaling - ScottPlot 5 Cookbook
Description: SignalXY plots can be scaled vertically according to a user-defined amount.
URL: /cookbook/5/SignalXY/SignalXYOffsetScaleY/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "SignalXY Plot", "SignalXY Scaling"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/SignalXY", "/cookbook/5/SignalXY/SignalXYOffsetScaleY"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SignalXY Scaling</h1>
</div>

SignalXY plots can be scaled vertically according to a user-defined amount.

[![](/cookbook/5/images/SignalXYOffsetScaleY.png?260329072039)](/cookbook/5/images/SignalXYOffsetScaleY.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5/images/SignalXYOffsetScaleY.png?260329072039" >}}ScottPlot.Plot myPlot = new();

// plot values between -1 and 1
double[] values = ScottPlot.Generate.Sin(51);
double[] xs = ScottPlot.Generate.Consecutive(51);
var signalXY = myPlot.Add.SignalXY(xs, values);

// increase the vertical scaling
signalXY.Data.YScale = 500;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/SignalXY'>SignalXY Plot</a> category</div>


