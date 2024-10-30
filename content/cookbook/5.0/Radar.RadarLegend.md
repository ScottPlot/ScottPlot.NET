---
Title: Radar Legend - ScottPlot 5.0 Cookbook
Description: Collections of radar values (radar series) can be labeled so they appear in the legend
URL: /cookbook/5.0/Radar/RadarLegend/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radar Plot", "Radar Legend"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Radar", "/cookbook/5.0/Radar/RadarLegend"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Radar/RadarLegend'>Radar Legend</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Radar/RadarLegend">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Radar">Category: Radar Plot</a>
</div>

Collections of radar values (radar series) can be labeled so they appear in the legend

[![](/cookbook/5.0/images/RadarLegend.png?241029205813)](/cookbook/5.0/images/RadarLegend.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

var radar = myPlot.Add.Radar(values);
radar.Series[0].LegendText = "Sebastian";
radar.Series[1].LegendText = "Fernando";

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


