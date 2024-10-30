---
Title: Callout Quickstart - ScottPlot 5.0 Cookbook
Description: Callouts display a label and are connected with an arrow that marks a point on the plot.
URL: /cookbook/5.0/Callout/CalloutQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Callout", "Callout Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Callout", "/cookbook/5.0/Callout/CalloutQuickstart"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Callout/CalloutQuickstart'>Callout Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Callout/CalloutQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Callout">Category: Callout</a>
</div>

Callouts display a label and are connected with an arrow that marks a point on the plot.

[![](/cookbook/5.0/images/CalloutQuickstart.png?241029205813)](/cookbook/5.0/images/CalloutQuickstart.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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


