---
Title: SignalXY Scaling - ScottPlot 5.0 Cookbook
Description: SignalXY plots can be scaled vertically according to a user-defined amount.
URL: /cookbook/5.0/SignalXY/SignalXYOffsetScaleY/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalXY Plot", "SignalXY Scaling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalXY", "/cookbook/5.0/SignalXY/SignalXYOffsetScaleY"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SignalXY Scaling</h1>
</div>

SignalXY plots can be scaled vertically according to a user-defined amount.

[![](/cookbook/5.0/images/SignalXYOffsetScaleY.png?241112193154)](/cookbook/5.0/images/SignalXYOffsetScaleY.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5.0/images/SignalXYOffsetScaleY.png?241112193154" >}}ScottPlot.Plot myPlot = new();

// plot values between -1 and 1
double[] values = ScottPlot.Generate.Sin(51);
double[] xs = ScottPlot.Generate.Consecutive(51);
var signalXY = myPlot.Add.SignalXY(xs, values);

// increase the vertical scaling
signalXY.Data.YScale = 500;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/SignalXY'>SignalXY Plot</a> category</div>


