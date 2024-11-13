---
Title: Legend Outside the Plot - ScottPlot 5.0 Cookbook
Description: Use the ShowLegend() overload that accepts an Edge to display the legend outside the data area.
URL: /cookbook/5.0/Legend/LegendOutside/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Legends", "Legend Outside the Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend", "/cookbook/5.0/Legend/LegendOutside"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Legend Outside the Plot</h1>
</div>

Use the ShowLegend() overload that accepts an Edge to display the legend outside the data area.

[![](/cookbook/5.0/images/LegendOutside.png?241112193154)](/cookbook/5.0/images/LegendOutside.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5.0/images/LegendOutside.png?241112193154" >}}ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin());
var sig2 = myPlot.Add.Signal(Generate.Cos());

sig1.LegendText = "Sine";
sig2.LegendText = "Cosine";

myPlot.ShowLegend(Edge.Right);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Legend'>Legends</a> category</div>


