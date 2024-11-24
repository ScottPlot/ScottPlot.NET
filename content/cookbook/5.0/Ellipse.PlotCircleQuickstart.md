---
Title: Circle Quickstart - ScottPlot 5.0 Cookbook
Description: Circles can be added to plots. Circles are really Ellipses with the same X and Y radius. Note that circles appear as ellipses unless the plot has a square coordinate system.
URL: /cookbook/5.0/Ellipse/PlotCircleQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Ellipse", "Circle Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Ellipse", "/cookbook/5.0/Ellipse/PlotCircleQuickstart"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Circle Quickstart</h1>
</div>

Circles can be added to plots. Circles are really Ellipses with the same X and Y radius. Note that circles appear as ellipses unless the plot has a square coordinate system.

[![](/cookbook/5.0/images/PlotCircleQuickstart.png?241124170640)](/cookbook/5.0/images/PlotCircleQuickstart.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Ellipse.cs" imageUrl="/cookbook/5.0/images/PlotCircleQuickstart.png?241124170640" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Ellipse'>Ellipse</a> category</div>


