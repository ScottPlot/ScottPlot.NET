---
Title: Polar Axis Spoke Length - ScottPlot 5.0 Cookbook
Description: The length of spokes may be customized. Spoke length is expressed as a fraction of the polar axis radius.
URL: /cookbook/5.0/PolarAxis/PolarSpokeLength/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Polar Axis", "Polar Axis Spoke Length"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/PolarAxis", "/cookbook/5.0/PolarAxis/PolarSpokeLength"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Axis Spoke Length</h1>
</div>

The length of spokes may be customized. Spoke length is expressed as a fraction of the polar axis radius.

[![](/cookbook/5.0/images/PolarSpokeLength.png?250822231048)](/cookbook/5.0/images/PolarSpokeLength.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/PolarAxis.cs" imageUrl="/cookbook/5.0/images/PolarSpokeLength.png?250822231048" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.PolarAxis(spokeLength: 1.3);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/PolarAxis'>Polar Axis</a> category</div>


