---
Title: Circle Quickstart - ScottPlot 5 Cookbook
Description: Circles can be added to plots. Circles are really Ellipses with the same X and Y radius. Note that circles appear as ellipses unless the plot has a square coordinate system.
URL: /cookbook/5/Ellipse/PlotCircleQuickstart/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Ellipse", "Circle Quickstart"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Ellipse", "/cookbook/5/Ellipse/PlotCircleQuickstart"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Circle Quickstart</h1>
</div>

Circles can be added to plots. Circles are really Ellipses with the same X and Y radius. Note that circles appear as ellipses unless the plot has a square coordinate system.

[![](/cookbook/5/images/PlotCircleQuickstart.png?251011113742)](/cookbook/5/images/PlotCircleQuickstart.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Ellipse.cs" imageUrl="/cookbook/5/images/PlotCircleQuickstart.png?251011113742" >}}ScottPlot.Plot myPlot = new();

Random rand = new(0);
for (int i = 0; i &lt; 5; i++)
{
    myPlot.Add.Circle(
        xCenter: rand.Next(-10, 10),
        yCenter: rand.Next(-10, 10),
        radius: rand.Next(1, 7));
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Ellipse'>Ellipse</a> category</div>


