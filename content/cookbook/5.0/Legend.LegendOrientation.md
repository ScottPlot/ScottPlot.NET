---
Title: Legend Orientation - ScottPlot 5.0 Cookbook
Description: Legend items may be arranged horizontally instead of vertically
URL: /cookbook/5.0/Legend/LegendOrientation/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Legends", "Legend Orientation"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend", "/cookbook/5.0/Legend/LegendOrientation"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Legend/LegendOrientation'>Legend Orientation</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Legend/LegendOrientation">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Legend">Category: Legends</a>
</div>

Legend items may be arranged horizontally instead of vertically

[![](/cookbook/5.0/images/LegendOrientation.png?241029205813)](/cookbook/5.0/images/LegendOrientation.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin(51, phase: .2));
var sig2 = myPlot.Add.Signal(Generate.Sin(51, phase: .4));
var sig3 = myPlot.Add.Signal(Generate.Sin(51, phase: .6));

sig1.LegendText = "Signal 1";
sig2.LegendText = "Signal 2";
sig3.LegendText = "Signal 3";

myPlot.ShowLegend(Alignment.UpperLeft, Orientation.Horizontal);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


