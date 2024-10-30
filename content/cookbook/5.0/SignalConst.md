---
Title: SignalConst - ScottPlot 5.0 Cookbook
Description: SignalConst is a type of signal plot which contains immutable data points and occupies more memory but offers greater performance for extremely large datasets. It is rarely needed, but best use for plotting data containing millions of points.
URL: /cookbook/5.0/SignalConst/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalConst"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalConst"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>SignalConst</h1>


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/SignalConst/SignalConstQuickstart'>SignalConst Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/SignalConst/SignalConstQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/SignalConst">Category: SignalConst</a>
</div>

SignalConst can display data with millions of points at high framerates, ideal for interactive manipulation of large datasets.

[![](/cookbook/5.0/images/SignalConstQuickstart.png?241029205813)](/cookbook/5.0/images/SignalConstQuickstart.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] data = Generate.RandomWalk(1_000_000);
myPlot.Add.SignalConst(data);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


