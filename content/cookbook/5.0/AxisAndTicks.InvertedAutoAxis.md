---
Title: Inverted Auto-Axis - ScottPlot 5.0 Cookbook
Description: Customize the logic for the automatic axis scaler to ensure that axis limits for a particular axis are always inverted when autoscaled.
URL: /cookbook/5.0/AxisAndTicks/InvertedAutoAxis/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis and Ticks", "Inverted Auto-Axis"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisAndTicks", "/cookbook/5.0/AxisAndTicks/InvertedAutoAxis"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Inverted Auto-Axis</h1>
</div>

Customize the logic for the automatic axis scaler to ensure that axis limits for a particular axis are always inverted when autoscaled.

[![](/cookbook/5.0/images/InvertedAutoAxis.png?241105214550)](/cookbook/5.0/images/InvertedAutoAxis.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/AxisRecipes.cs" imageUrl="/cookbook/5.0/images/InvertedAutoAxis.png?241105214550" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Axes.AutoScaler.InvertedY = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/AxisAndTicks'>Axis and Ticks</a> category</div>


