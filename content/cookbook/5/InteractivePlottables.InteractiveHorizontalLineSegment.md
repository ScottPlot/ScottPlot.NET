---
Title: Interactive Horizontal Line Segment - ScottPlot 5 Cookbook
Description: Horizontal line segments can be expanded horizontally by dragging the left and right edges, or slid vertically by dragging the center line.
URL: /cookbook/5/InteractivePlottables/InteractiveHorizontalLineSegment/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Interactive", "Interactive Horizontal Line Segment"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/InteractivePlottables", "/cookbook/5/InteractivePlottables/InteractiveHorizontalLineSegment"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Interactive Horizontal Line Segment</h1>
</div>

Horizontal line segments can be expanded horizontally by dragging the left and right edges, or slid vertically by dragging the center line.

[![](/cookbook/5/images/InteractiveHorizontalLineSegment.png?251011113742)](/cookbook/5/images/InteractiveHorizontalLineSegment.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/InteractivePlottables.cs" imageUrl="/cookbook/5/images/InteractiveHorizontalLineSegment.png?251011113742" >}}ScottPlot.Plot myPlot = new();

for (int i = 1; i &lt;= 5; i++)
{
    double y = i;
    double x1 = i;
    double x2 = i * 2;
    myPlot.Add.InteractiveHorizontalLineSegment(x1, x2, y);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/InteractivePlottables'>Interactive</a> category</div>


