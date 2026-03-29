---
Title: Interactive Vertical Line - ScottPlot 5 Cookbook
Description: An interactive vertical line has an X position and extends to infinity along the Y axis.
URL: /cookbook/5/InteractivePlottables/InteractiveVerticalLine/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Interactive", "Interactive Vertical Line"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/InteractivePlottables", "/cookbook/5/InteractivePlottables/InteractiveVerticalLine"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Interactive Vertical Line</h1>
</div>

An interactive vertical line has an X position and extends to infinity along the Y axis.

[![](/cookbook/5/images/InteractiveVerticalLine.png?260329072039)](/cookbook/5/images/InteractiveVerticalLine.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/InteractivePlottables.cs" imageUrl="/cookbook/5/images/InteractiveVerticalLine.png?260329072039" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 5; i++)
{
    double x = Generate.RandomNumber();
    myPlot.Add.InteractiveVerticalLine(x);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/InteractivePlottables'>Interactive</a> category</div>


