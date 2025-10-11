---
Title: Interactive Vertical Line Segment - ScottPlot 5 Cookbook
Description: Vertical line segments can be expanded vertically by dragging the top and bottom edges, or slid horizontally by dragging the center line.
URL: /cookbook/5/InteractivePlottables/InteractiveVerticalLineSegment/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Interactive", "Interactive Vertical Line Segment"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/InteractivePlottables", "/cookbook/5/InteractivePlottables/InteractiveVerticalLineSegment"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Interactive Vertical Line Segment</h1>
</div>

Vertical line segments can be expanded vertically by dragging the top and bottom edges, or slid horizontally by dragging the center line.

[![](/cookbook/5/images/InteractiveVerticalLineSegment.png?251011113742)](/cookbook/5/images/InteractiveVerticalLineSegment.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/InteractivePlottables.cs" imageUrl="/cookbook/5/images/InteractiveVerticalLineSegment.png?251011113742" >}}ScottPlot.Plot myPlot = new();

for (int i = 1; i &lt;= 5; i++)
{
    double x = i;
    double y1 = i;
    double y2 = i * 2;
    myPlot.Add.InteractiveVerticalLineSegment(x, y1, y2);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/InteractivePlottables'>Interactive</a> category</div>


