---
Title: Radar Spoke Labels - ScottPlot 5.0 Cookbook
Description: Labels can be assigned to spokes to label values around the circumference of the radar plot
URL: /cookbook/5.0/Radar/RadarSpokeLabels/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radar Plot", "Radar Spoke Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Radar", "/cookbook/5.0/Radar/RadarSpokeLabels"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Radar/RadarSpokeLabels'>Radar Spoke Labels</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Radar/RadarSpokeLabels">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Radar">Category: Radar Plot</a>
</div>

Labels can be assigned to spokes to label values around the circumference of the radar plot

[![](/cookbook/5.0/images/RadarSpokeLabels.png?241031194635)](/cookbook/5.0/images/RadarSpokeLabels.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

var radar = myPlot.Add.Radar(values);

string[] spokeLabels = { "Wins", "Poles", "Podiums", "Points", "DNFs" };
radar.PolarAxis.SetSpokes(spokeLabels, length: 110);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


