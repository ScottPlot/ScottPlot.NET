---
Title: Radar with Straight Lines - ScottPlot 5 Cookbook
Description: Radial ticks may be rendered using straight lines instead of circles
URL: /cookbook/5/Radar/RadarStraightLines/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Radar Plot", "Radar with Straight Lines"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Radar", "/cookbook/5/Radar/RadarStraightLines"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Radar with Straight Lines</h1>
</div>

Radial ticks may be rendered using straight lines instead of circles

[![](/cookbook/5/images/RadarStraightLines.png?251011113742)](/cookbook/5/images/RadarStraightLines.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Radar.cs" imageUrl="/cookbook/5/images/RadarStraightLines.png?251011113742" >}}ScottPlot.Plot myPlot = new();

double[] values = { 78, 83, 100, 76, 43 };
var radar = myPlot.Add.Radar(values);
radar.PolarAxis.StraightLines = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Radar'>Radar Plot</a> category</div>


