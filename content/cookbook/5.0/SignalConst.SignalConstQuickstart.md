---
Title: SignalConst Quickstart - ScottPlot 5.0 Cookbook
Description: SignalConst can display data with millions of points at high framerates, ideal for interactive manipulation of large datasets.
URL: /cookbook/5.0/SignalConst/SignalConstQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalConst", "SignalConst Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalConst", "/cookbook/5.0/SignalConst/SignalConstQuickstart"]
Date: 2024-11-03
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SignalConst Quickstart</h1>
</div>

SignalConst can display data with millions of points at high framerates, ideal for interactive manipulation of large datasets.

[![](/cookbook/5.0/images/SignalConstQuickstart.png?241103171511)](/cookbook/5.0/images/SignalConstQuickstart.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalConst.cs" imageUrl="/cookbook/5.0/images/SignalConstQuickstart.png?241103171511" >}}ScottPlot.Plot myPlot = new();

double[] data = Generate.RandomWalk(1_000_000);
myPlot.Add.SignalConst(data);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/SignalConst'>SignalConst</a> category</div>


