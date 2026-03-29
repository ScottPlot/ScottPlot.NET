---
Title: Gauge Labels in Legend - ScottPlot 5 Cookbook
Description: Radial gauge labels will appear in the legend if they are assigned. 
URL: /cookbook/5/RadialGauge/RadialGaugeLegend/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Radial gauge", "Gauge Labels in Legend"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/RadialGauge", "/cookbook/5/RadialGauge/RadialGaugeLegend"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Gauge Labels in Legend</h1>
</div>

Radial gauge labels will appear in the legend if they are assigned. 

[![](/cookbook/5/images/RadialGaugeLegend.png?260329072039)](/cookbook/5/images/RadialGaugeLegend.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/RadialGauge.cs" imageUrl="/cookbook/5/images/RadialGaugeLegend.png?260329072039" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Palette = new ScottPlot.Palettes.Nord();
double[] values = { 100, 80, 65, 45, 20 };

var radialGaugePlot = myPlot.Add.RadialGaugePlot(values);
radialGaugePlot.Labels = new string[] { "alpha", "beta", "gamma", "delta", "epsilon" };
myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/RadialGauge'>Radial gauge</a> category</div>


