---
Title: Radar Spoke Labels - ScottPlot 5.0 Cookbook
Description: Labels can be assigned to spokes to label values around the circumference of the radar plot
URL: /cookbook/5.0/Radar/RadarSpokeLabels/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radar Plot", "Radar Spoke Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Radar", "/cookbook/5.0/Radar/RadarSpokeLabels"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Radar Spoke Labels</h1>
</div>

Labels can be assigned to spokes to label values around the circumference of the radar plot

[![](/cookbook/5.0/images/RadarSpokeLabels.png?250322130304)](/cookbook/5.0/images/RadarSpokeLabels.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Radar.cs" imageUrl="/cookbook/5.0/images/RadarSpokeLabels.png?250322130304" >}}ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

var radar = myPlot.Add.Radar(values);

string[] spokeLabels = { "Wins", "Poles", "Podiums", "Points", "DNFs" };
radar.PolarAxis.SetSpokes(spokeLabels, length: 110);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Radar'>Radar Plot</a> category</div>


