---
Title: Radar Plot with Multiple Series - ScottPlot 5.0 Cookbook
Description: A single radar chart can be used to display values from multiple series using a 2D array
URL: /cookbook/5.0/Radar/RadarMultipleQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radar Plot", "Radar Plot with Multiple Series"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Radar", "/cookbook/5.0/Radar/RadarMultipleQuickstart"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Radar/RadarMultipleQuickstart'>Radar Plot with Multiple Series</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Radar/RadarMultipleQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Radar">Category: Radar Plot</a>
</div>

A single radar chart can be used to display values from multiple series using a 2D array

[![](/cookbook/5.0/images/RadarMultipleQuickstart.png?241029205813)](/cookbook/5.0/images/RadarMultipleQuickstart.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

myPlot.Add.Radar(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


