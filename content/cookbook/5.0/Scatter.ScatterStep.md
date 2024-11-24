---
Title: Step Plot - ScottPlot 5.0 Cookbook
Description: Scatter plots can be created using a step plot display where points are connected with right angles instead of diagnal lines. The direction of the steps can be customized.
URL: /cookbook/5.0/Scatter/ScatterStep/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Step Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterStep"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Step Plot</h1>
</div>

Scatter plots can be created using a step plot display where points are connected with right angles instead of diagnal lines. The direction of the steps can be customized.

[![](/cookbook/5.0/images/ScatterStep.png?241124170640)](/cookbook/5.0/images/ScatterStep.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterStep.png?241124170640" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(20);
double[] ys1 = Generate.Consecutive(20, first: 10);
double[] ys2 = Generate.Consecutive(20, first: 5);
double[] ys3 = Generate.Consecutive(20, first: 0);

var sp1 = myPlot.Add.Scatter(xs, ys1);
sp1.ConnectStyle = ConnectStyle.Straight;
sp1.LegendText = "Straight";

var sp2 = myPlot.Add.Scatter(xs, ys2);
sp2.ConnectStyle = ConnectStyle.StepHorizontal;
sp2.LegendText = "StepHorizontal";

var sp3 = myPlot.Add.Scatter(xs, ys3);
sp3.ConnectStyle = ConnectStyle.StepVertical;
sp3.LegendText = "StepVertical";

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Scatter'>Scatter Plot</a> category</div>


