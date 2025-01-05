---
Title: Callout Quickstart - ScottPlot 5.0 Cookbook
Description: Callouts display a label and are connected with an arrow that marks a point on the plot.
URL: /cookbook/5.0/Callout/CalloutQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Callout", "Callout Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Callout", "/cookbook/5.0/Callout/CalloutQuickstart"]
Date: 2025-01-05
Version: ScottPlot 5.0.48
Version: ScottPlot 5.0.48
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Callout Quickstart</h1>
</div>

Callouts display a label and are connected with an arrow that marks a point on the plot.

[![](/cookbook/5.0/images/CalloutQuickstart.png?250105183901)](/cookbook/5.0/images/CalloutQuickstart.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Callout.cs" imageUrl="/cookbook/5.0/images/CalloutQuickstart.png?250105183901" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(15);
double[] ys = Generate.Sin(15);
myPlot.Add.Scatter(xs, ys);

myPlot.Add.Callout("Hello",
    textLocation: new(7.5, .8),
    tipLocation: new(xs[6], ys[6]));

myPlot.Add.Callout("World",
    textLocation: new(10, 0),
    tipLocation: new(xs[13], ys[13]));

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Callout'>Callout</a> category</div>


