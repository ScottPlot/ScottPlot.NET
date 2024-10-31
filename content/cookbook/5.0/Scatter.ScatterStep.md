---
Title: Step Plot - ScottPlot 5.0 Cookbook
Description: Scatter plots can be created using a step plot display where points are connected with right angles instead of diagnal lines. The direction of the steps can be customized.
URL: /cookbook/5.0/Scatter/ScatterStep/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Step Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterStep"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Scatter/ScatterStep'>Step Plot</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Scatter/ScatterStep">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Scatter">Category: Scatter Plot</a>
</div>

Scatter plots can be created using a step plot display where points are connected with right angles instead of diagnal lines. The direction of the steps can be customized.

[![](/cookbook/5.0/images/ScatterStep.png?241031194635)](/cookbook/5.0/images/ScatterStep.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


