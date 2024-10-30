---
Title: Radar with Straight Lines - ScottPlot 5.0 Cookbook
Description: Radial ticks may be rendered using straight lines instead of circles
URL: /cookbook/5.0/Radar/RadarStraightLines/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radar Plot", "Radar with Straight Lines"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Radar", "/cookbook/5.0/Radar/RadarStraightLines"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Radar/RadarStraightLines'>Radar with Straight Lines</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Radar/RadarStraightLines">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Radar">Category: Radar Plot</a>
</div>

Radial ticks may be rendered using straight lines instead of circles

[![](/cookbook/5.0/images/RadarStraightLines.png?241029205813)](/cookbook/5.0/images/RadarStraightLines.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] values = { 78, 83, 100, 76, 43 };
var radar = myPlot.Add.Radar(values);
radar.PolarAxis.StraightLines = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


