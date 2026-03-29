---
Title: Polar Axis Spoke Length - ScottPlot 5 Cookbook
Description: The length of spokes may be customized. Spoke length is expressed as a fraction of the polar axis radius.
URL: /cookbook/5/PolarAxis/PolarSpokeLength/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Polar Axis", "Polar Axis Spoke Length"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/PolarAxis", "/cookbook/5/PolarAxis/PolarSpokeLength"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis Spoke Length</h1>
</div>

The length of spokes may be customized. Spoke length is expressed as a fraction of the polar axis radius.

[![](/cookbook/5/images/PolarSpokeLength.png?260329072039)](/cookbook/5/images/PolarSpokeLength.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/PolarAxis.cs" imageUrl="/cookbook/5/images/PolarSpokeLength.png?260329072039" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.PolarAxis(spokeLength: 1.3);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/PolarAxis'>Polar Axis</a> category</div>


