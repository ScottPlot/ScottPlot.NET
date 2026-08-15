---
Title: Interactive Trend Line - ScottPlot 5 Cookbook
Description: Interactive trend lines extend infinitely in both directions and can be repositioned by dragging either control point.
URL: /cookbook/5/InteractivePlottables/InteractiveTrendLine/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Interactive", "Interactive Trend Line"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/InteractivePlottables", "/cookbook/5/InteractivePlottables/InteractiveTrendLine"]
Date: 2026-08-15
Version: ScottPlot 5.1.60
Version: ScottPlot 5.1.60
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Interactive Trend Line</h1>
</div>

Interactive trend lines extend infinitely in both directions and can be repositioned by dragging either control point.

[![](/cookbook/5/images/InteractiveTrendLine.png?260815173246)](/cookbook/5/images/InteractiveTrendLine.png?260815173246)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/InteractivePlottables.cs" imageUrl="/cookbook/5/images/InteractiveTrendLine.png?260815173246" >}}ScottPlot.Plot myPlot = new();

CoordinateLine line = new(1, 2, 9, 7);
myPlot.Add.InteractiveTrendLine(line);
myPlot.Axes.SetLimits(0, 10, 0, 10);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/InteractivePlottables'>Interactive</a> category</div>


