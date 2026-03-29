---
Title: Signal Generic - ScottPlot 5 Cookbook
Description: Signal plots support generic data types, although double is typically the most performant.
URL: /cookbook/5/Signal/SignalGeneric/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Signal Plot", "Signal Generic"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Signal", "/cookbook/5/Signal/SignalGeneric"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Signal Generic</h1>
</div>

Signal plots support generic data types, although double is typically the most performant.

[![](/cookbook/5/images/SignalGeneric.png?260329072039)](/cookbook/5/images/SignalGeneric.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Signal.cs" imageUrl="/cookbook/5/images/SignalGeneric.png?260329072039" >}}ScottPlot.Plot myPlot = new();

int[] values = Generate.RandomIntegers(1000, -100, 100);

myPlot.Add.Signal(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Signal'>Signal Plot</a> category</div>


