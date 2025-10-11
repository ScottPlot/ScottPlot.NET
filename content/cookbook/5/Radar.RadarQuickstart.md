---
Title: Radar Plot Quickstart - ScottPlot 5 Cookbook
Description: A radar chart can be created from a single array of values.
URL: /cookbook/5/Radar/RadarQuickstart/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Radar Plot", "Radar Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Radar", "/cookbook/5/Radar/RadarQuickstart"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Radar Plot Quickstart</h1>
</div>

A radar chart can be created from a single array of values.

[![](/cookbook/5/images/RadarQuickstart.png?251011113742)](/cookbook/5/images/RadarQuickstart.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Radar.cs" imageUrl="/cookbook/5/images/RadarQuickstart.png?251011113742" >}}ScottPlot.Plot myPlot = new();

double[] values = { 78, 83, 84, 76, 43 };
myPlot.Add.Radar(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Radar'>Radar Plot</a> category</div>


