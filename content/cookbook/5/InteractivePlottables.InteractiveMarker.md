---
Title: Interactive Marker - ScottPlot 5 Cookbook
Description: Interactive markers respond to hover events and can be dragged.
URL: /cookbook/5/InteractivePlottables/InteractiveMarker/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Interactive", "Interactive Marker"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/InteractivePlottables", "/cookbook/5/InteractivePlottables/InteractiveMarker"]
Date: 2026-08-15
Version: ScottPlot 5.1.60
Version: ScottPlot 5.1.60
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Interactive Marker</h1>
</div>

Interactive markers respond to hover events and can be dragged.

[![](/cookbook/5/images/InteractiveMarker.png?260815173246)](/cookbook/5/images/InteractiveMarker.png?260815173246)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/InteractivePlottables.cs" imageUrl="/cookbook/5/images/InteractiveMarker.png?260815173246" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 10; i++)
{
    Coordinates point = Generate.RandomCoordinates();
    var marker = myPlot.Add.InteractiveMarker(point);
    marker.MarkerStyle.Shape = Generate.RandomMarkerShape();
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/InteractivePlottables'>Interactive</a> category</div>


