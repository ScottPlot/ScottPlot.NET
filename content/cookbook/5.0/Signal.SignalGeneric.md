---
Title: Signal Generic - ScottPlot 5.0 Cookbook
Description: Signal plots support generic data types, although double is typically the most performant.
URL: /cookbook/5.0/Signal/SignalGeneric/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Signal Plot", "Signal Generic"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Signal", "/cookbook/5.0/Signal/SignalGeneric"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Signal/SignalGeneric'>Signal Generic</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Signal/SignalGeneric">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Signal">Category: Signal Plot</a>
</div>

Signal plots support generic data types, although double is typically the most performant.

[![](/cookbook/5.0/images/SignalGeneric.png?241031194635)](/cookbook/5.0/images/SignalGeneric.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

int[] values = Generate.RandomIntegers(1000, -100, 100);

myPlot.Add.Signal(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


