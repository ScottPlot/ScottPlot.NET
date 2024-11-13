---
Title: Radar with Straight Lines - ScottPlot 5.0 Cookbook
Description: Radial ticks may be rendered using straight lines instead of circles
URL: /cookbook/5.0/Radar/RadarStraightLines/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radar Plot", "Radar with Straight Lines"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Radar", "/cookbook/5.0/Radar/RadarStraightLines"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Radar with Straight Lines</h1>
</div>

Radial ticks may be rendered using straight lines instead of circles

[![](/cookbook/5.0/images/RadarStraightLines.png?241112193154)](/cookbook/5.0/images/RadarStraightLines.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Radar.cs" imageUrl="/cookbook/5.0/images/RadarStraightLines.png?241112193154" >}}ScottPlot.Plot myPlot = new();

double[] values = { 78, 83, 100, 76, 43 };
var radar = myPlot.Add.Radar(values);
radar.PolarAxis.StraightLines = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Radar'>Radar Plot</a> category</div>


