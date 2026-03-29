---
Title: Radar Legend - ScottPlot 5 Cookbook
Description: Collections of radar values (radar series) can be labeled so they appear in the legend
URL: /cookbook/5/Radar/RadarLegend/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Radar Plot", "Radar Legend"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Radar", "/cookbook/5/Radar/RadarLegend"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Radar Legend</h1>
</div>

Collections of radar values (radar series) can be labeled so they appear in the legend

[![](/cookbook/5/images/RadarLegend.png?260329072039)](/cookbook/5/images/RadarLegend.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Radar.cs" imageUrl="/cookbook/5/images/RadarLegend.png?260329072039" >}}ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

var radar = myPlot.Add.Radar(values);
radar.Series[0].LegendText = "Sebastian";
radar.Series[1].LegendText = "Fernando";

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Radar'>Radar Plot</a> category</div>


