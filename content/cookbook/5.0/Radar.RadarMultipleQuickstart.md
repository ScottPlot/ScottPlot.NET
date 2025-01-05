---
Title: Radar Plot with Multiple Series - ScottPlot 5.0 Cookbook
Description: A single radar chart can be used to display values from multiple series using a 2D array
URL: /cookbook/5.0/Radar/RadarMultipleQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radar Plot", "Radar Plot with Multiple Series"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Radar", "/cookbook/5.0/Radar/RadarMultipleQuickstart"]
Date: 2025-01-05
Version: ScottPlot 5.0.48
Version: ScottPlot 5.0.48
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Radar Plot with Multiple Series</h1>
</div>

A single radar chart can be used to display values from multiple series using a 2D array

[![](/cookbook/5.0/images/RadarMultipleQuickstart.png?250105183901)](/cookbook/5.0/images/RadarMultipleQuickstart.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Radar.cs" imageUrl="/cookbook/5.0/images/RadarMultipleQuickstart.png?250105183901" >}}ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

myPlot.Add.Radar(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Radar'>Radar Plot</a> category</div>


