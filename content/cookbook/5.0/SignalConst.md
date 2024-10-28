---
Title: SignalConst - ScottPlot 5.0 Cookbook
Description: SignalConst is a type of signal plot which contains immutable data points and occupies more memory but offers greater performance for extremely large datasets. It is rarely needed, but best use for plotting data containing millions of points.
URL: /cookbook/5.0/SignalConst/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalConst"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalConst"]
Date: 2024-10-28
Version: ScottPlot 5.0.41
Version: ScottPlot 5.0.41
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# SignalConst


<h2><a href='/cookbook/5.0/SignalConst/SignalConstQuickstart'>SignalConst Quickstart</a></h2>

SignalConst can display data with millions of points at high framerates, ideal for interactive manipulation of large datasets.

[![](/cookbook/5.0/images/SignalConstQuickstart.png?241027220842)](/cookbook/5.0/images/SignalConstQuickstart.png?241027220842)

{{< recipe-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

double[] data = Generate.RandomWalk(1_000_000);
myPlot.Add.SignalConst(data);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>

