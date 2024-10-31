---
Title: Radar Plot Quickstart - ScottPlot 5.0 Cookbook
Description: A radar chart can be created from a single array of values.
URL: /cookbook/5.0/Radar/RadarQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radar Plot", "Radar Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Radar", "/cookbook/5.0/Radar/RadarQuickstart"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Radar/RadarQuickstart'>Radar Plot Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Radar/RadarQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Radar">Category: Radar Plot</a>
</div>

A radar chart can be created from a single array of values.

[![](/cookbook/5.0/images/RadarQuickstart.png?241031194635)](/cookbook/5.0/images/RadarQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] values = { 78, 83, 84, 76, 43 };
myPlot.Add.Radar(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


