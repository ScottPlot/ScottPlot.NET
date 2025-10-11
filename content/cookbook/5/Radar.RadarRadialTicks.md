---
Title: Radar Radial Tick Labels - ScottPlot 5 Cookbook
Description: Radar radial tick positions and labels may be defined by the user
URL: /cookbook/5/Radar/RadarRadialTicks/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Radar Plot", "Radar Radial Tick Labels"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Radar", "/cookbook/5/Radar/RadarRadialTicks"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Radar Radial Tick Labels</h1>
</div>

Radar radial tick positions and labels may be defined by the user

[![](/cookbook/5/images/RadarRadialTicks.png?251011113742)](/cookbook/5/images/RadarRadialTicks.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Radar.cs" imageUrl="/cookbook/5/images/RadarRadialTicks.png?251011113742" >}}ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

var radar = myPlot.Add.Radar(values);

double[] tickPositions = { 25, 50, 75, 100 };
string[] tickLabels = tickPositions.Select(x =&gt; x.ToString()).ToArray();
radar.PolarAxis.SetCircles(tickPositions, tickLabels);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Radar'>Radar Plot</a> category</div>


