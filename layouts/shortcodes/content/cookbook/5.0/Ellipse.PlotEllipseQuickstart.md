---
Title: Ellipse Quickstart - ScottPlot 5.0 Cookbook
Description: Ellipses can be added to plots
URL: /cookbook/5.0/Ellipse/PlotEllipseQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Ellipse", "Ellipse Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Ellipse", "/cookbook/5.0/Ellipse/PlotEllipseQuickstart"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Ellipse Quickstart</h1>
</div>

Ellipses can be added to plots

[![](/cookbook/5.0/images/PlotEllipseQuickstart.png?250322130304)](/cookbook/5.0/images/PlotEllipseQuickstart.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Ellipse.cs" imageUrl="/cookbook/5.0/images/PlotEllipseQuickstart.png?250322130304" >}}ScottPlot.Plot myPlot = new();

Random rand = new(0);
for (int i = 0; i &lt; 5; i++)
{
    myPlot.Add.Ellipse(
        xCenter: rand.Next(-10, 10),
        yCenter: rand.Next(-10, 10),
        radiusX: rand.Next(1, 7),
        radiusY: rand.Next(1, 7));
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Ellipse'>Ellipse</a> category</div>


