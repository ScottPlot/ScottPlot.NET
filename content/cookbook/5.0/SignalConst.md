---
Title: SignalConst - ScottPlot 5.0 Cookbook
Description: SignalConst is a type of signal plot which contains immutable data points and occupies more memory but offers greater performance for extremely large datasets. It is rarely needed, but best use for plotting data containing millions of points.
URL: /cookbook/5.0/SignalConst/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalConst"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalConst"]
Date: 2025-01-05
Version: ScottPlot 5.0.48
Version: ScottPlot 5.0.48
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>SignalConst</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SignalConst Quickstart</h1>
<a href='/cookbook/5.0/SignalConst/SignalConstQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

SignalConst can display data with millions of points at high framerates, ideal for interactive manipulation of large datasets.

[![](/cookbook/5.0/images/SignalConstQuickstart.png?250105183901)](/cookbook/5.0/images/SignalConstQuickstart.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalConst.cs" imageUrl="/cookbook/5.0/images/SignalConstQuickstart.png?250105183901" >}}ScottPlot.Plot myPlot = new();

double[] data = Generate.RandomWalk(1_000_000);
myPlot.Add.SignalConst(data);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


