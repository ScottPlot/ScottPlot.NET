---
Title: Partial SignalXY Rendering - ScottPlot 5.0 Cookbook
Description: Even if a SignalXY plot references a large array of data, rendering can be limited to a range of values. If set,only the range of data between the minimum and maximum render indexes will be displayed.
URL: /cookbook/5.0/SignalXY/SignalXYRenderIndexes/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalXY Plot", "Partial SignalXY Rendering"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalXY", "/cookbook/5.0/SignalXY/SignalXYRenderIndexes"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Partial SignalXY Rendering</h1>
</div>

Even if a SignalXY plot references a large array of data, rendering can be limited to a range of values. If set,only the range of data between the minimum and maximum render indexes will be displayed.

[![](/cookbook/5.0/images/SignalXYRenderIndexes.png?241124170640)](/cookbook/5.0/images/SignalXYRenderIndexes.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5.0/images/SignalXYRenderIndexes.png?241124170640" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(1000);
double[] ys = Generate.RandomWalk(1000);

var sigAll = myPlot.Add.SignalXY(xs, ys);
sigAll.LegendText = "Full";
sigAll.Data.YOffset = 80;

var sigLeft = myPlot.Add.SignalXY(xs, ys);
sigLeft.LegendText = "Left";
sigLeft.Data.YOffset = 60;
sigLeft.Data.MaximumIndex = 700;

var sigRight = myPlot.Add.SignalXY(xs, ys);
sigRight.LegendText = "Right";
sigRight.Data.YOffset = 40;
sigRight.Data.MinimumIndex = 300;

var sigMid = myPlot.Add.SignalXY(xs, ys);
sigMid.LegendText = "Mid";
sigMid.Data.YOffset = 20;
sigMid.Data.MinimumIndex = 300;
sigMid.Data.MaximumIndex = 700;

myPlot.ShowLegend(Alignment.UpperRight);
myPlot.Axes.Margins(top: .5);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/SignalXY'>SignalXY Plot</a> category</div>


