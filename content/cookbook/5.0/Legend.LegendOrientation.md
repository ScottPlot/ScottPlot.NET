---
Title: Legend Orientation - ScottPlot 5.0 Cookbook
Description: Legend items may be arranged horizontally instead of vertically
URL: /cookbook/5.0/Legend/LegendOrientation/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Legends", "Legend Orientation"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend", "/cookbook/5.0/Legend/LegendOrientation"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Legend Orientation</h1>
</div>

Legend items may be arranged horizontally instead of vertically

[![](/cookbook/5.0/images/LegendOrientation.png?241105214550)](/cookbook/5.0/images/LegendOrientation.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5.0/images/LegendOrientation.png?241105214550" >}}ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin(51, phase: .2));
var sig2 = myPlot.Add.Signal(Generate.Sin(51, phase: .4));
var sig3 = myPlot.Add.Signal(Generate.Sin(51, phase: .6));

sig1.LegendText = "Signal 1";
sig2.LegendText = "Signal 2";
sig3.LegendText = "Signal 3";

myPlot.ShowLegend(Alignment.UpperLeft, Orientation.Horizontal);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Legend'>Legends</a> category</div>


