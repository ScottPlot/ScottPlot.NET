---
Title: Polar Axis Spoke Labels - ScottPlot 5.0 Cookbook
Description: Polar axis spokes may be individually labeled.
URL: /cookbook/5.0/PolarAxis/PolarSpokeLabels/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polar Axis", "Polar Axis Spoke Labels"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/PolarAxis", "/cookbook/5.0/PolarAxis/PolarSpokeLabels"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis Spoke Labels</h1>
</div>

Polar axis spokes may be individually labeled.

[![](/cookbook/5.0/images/PolarSpokeLabels.png?250322130304)](/cookbook/5.0/images/PolarSpokeLabels.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/PolarAxis.cs" imageUrl="/cookbook/5.0/images/PolarSpokeLabels.png?250322130304" >}}ScottPlot.Plot myPlot = new();

var polarAxis = myPlot.Add.PolarAxis();

string[] labels = { "alpha", "beta", "gamma", "delta", "epsilon" };
polarAxis.SetSpokes(labels, 1.1);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/PolarAxis'>Polar Axis</a> category</div>


