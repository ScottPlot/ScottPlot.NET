---
Title: Legend Outside the Plot - ScottPlot 5.0 Cookbook
Description: Use the ShowLegend() overload that accepts an Edge to display the legend outside the data area.
URL: /cookbook/5.0/Legend/LegendOutside/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Legends", "Legend Outside the Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend", "/cookbook/5.0/Legend/LegendOutside"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Legend/LegendOutside'>Legend Outside the Plot</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Legend/LegendOutside">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Legend">Category: Legends</a>
</div>

Use the ShowLegend() overload that accepts an Edge to display the legend outside the data area.

[![](/cookbook/5.0/images/LegendOutside.png?241031194635)](/cookbook/5.0/images/LegendOutside.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin());
var sig2 = myPlot.Add.Signal(Generate.Cos());

sig1.LegendText = "Sine";
sig2.LegendText = "Cosine";

myPlot.ShowLegend(Edge.Right);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


