---
Title: Interactive Horizontal Line - ScottPlot 5 Cookbook
Description: An interactive horizontal line has a Y position and extends to infinity along the X axis.
URL: /cookbook/5/InteractivePlottables/InteractiveHorizontalLine/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Interactive", "Interactive Horizontal Line"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/InteractivePlottables", "/cookbook/5/InteractivePlottables/InteractiveHorizontalLine"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Interactive Horizontal Line</h1>
</div>

An interactive horizontal line has a Y position and extends to infinity along the X axis.

[![](/cookbook/5/images/InteractiveHorizontalLine.png?260329072039)](/cookbook/5/images/InteractiveHorizontalLine.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/InteractivePlottables.cs" imageUrl="/cookbook/5/images/InteractiveHorizontalLine.png?260329072039" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 5; i++)
{
    double x = Generate.RandomNumber();
    myPlot.Add.InteractiveHorizontalLine(x);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/InteractivePlottables'>Interactive</a> category</div>


