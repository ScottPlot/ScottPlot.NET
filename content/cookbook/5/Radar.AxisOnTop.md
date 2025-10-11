---
Title: Axis on Top of Data - ScottPlot 5 Cookbook
Description: Radar charts can be customized so the axis is rendered on top of the data
URL: /cookbook/5/Radar/AxisOnTop/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Radar Plot", "Axis on Top of Data"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Radar", "/cookbook/5/Radar/AxisOnTop"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis on Top of Data</h1>
</div>

Radar charts can be customized so the axis is rendered on top of the data

[![](/cookbook/5/images/AxisOnTop.png?251011113742)](/cookbook/5/images/AxisOnTop.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Radar.cs" imageUrl="/cookbook/5/images/AxisOnTop.png?251011113742" >}}ScottPlot.Plot myPlot = new();

double[] values = { 78, 83, 100, 76, 43 };
var radar = myPlot.Add.Radar(values);

// make the shape opaque
radar.Series[0].FillColor = Colors.RebeccaPurple;

// render the axis above the data
radar.IsAxisAboveData = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Radar'>Radar Plot</a> category</div>


