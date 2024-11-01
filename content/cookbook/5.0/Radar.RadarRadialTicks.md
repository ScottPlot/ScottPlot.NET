---
Title: Radar Radial Tick Labels - ScottPlot 5.0 Cookbook
Description: Radar radial tick positions and labels may be defined by the user
URL: /cookbook/5.0/Radar/RadarRadialTicks/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radar Plot", "Radar Radial Tick Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Radar", "/cookbook/5.0/Radar/RadarRadialTicks"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Radar Radial Tick Labels</h1>
</div>

Radar radial tick positions and labels may be defined by the user

[![](/cookbook/5.0/images/RadarRadialTicks.png?241101192719)](/cookbook/5.0/images/RadarRadialTicks.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

var radar = myPlot.Add.Radar(values);

double[] tickPositions = { 25, 50, 75, 100 };
string[] tickLabels = tickPositions.Select(x => x.ToString()).ToArray();
radar.PolarAxis.SetCircles(tickPositions, tickLabels);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Radar'>Radar Plot</a> category</div>


