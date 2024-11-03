---
Title: Callout - ScottPlot 5.0 Cookbook
Description: Callouts display a label and are connected with an arrow that marks a point on the plot.
URL: /cookbook/5.0/Callout/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Callout"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Callout"]
Date: 2024-11-03
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Callout</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Callout Quickstart</h1>
<a href='/cookbook/5.0/Callout/CalloutQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Callouts display a label and are connected with an arrow that marks a point on the plot.

[![](/cookbook/5.0/images/CalloutQuickstart.png?241103171511)](/cookbook/5.0/images/CalloutQuickstart.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Callout.cs" imageUrl="/cookbook/5.0/images/CalloutQuickstart.png?241103171511" >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


