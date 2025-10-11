---
Title: Circle with Locked Scale - ScottPlot 5 Cookbook
Description: For circles to always appear circular, the coordinate system must be forced to always display square-shaped pixels. This can be achieved by enabling the axis scale lock.
URL: /cookbook/5/Ellipse/CircleWithLockedScale/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Ellipse", "Circle with Locked Scale"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Ellipse", "/cookbook/5/Ellipse/CircleWithLockedScale"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Circle with Locked Scale</h1>
</div>

For circles to always appear circular, the coordinate system must be forced to always display square-shaped pixels. This can be achieved by enabling the axis scale lock.

[![](/cookbook/5/images/CircleWithLockedScale.png?251011113742)](/cookbook/5/images/CircleWithLockedScale.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Ellipse.cs" imageUrl="/cookbook/5/images/CircleWithLockedScale.png?251011113742" >}}ScottPlot.Plot myPlot = new();

Random rand = new(0);
for (int i = 0; i &lt; 5; i++)
{
    myPlot.Add.Circle(
        xCenter: rand.Next(-10, 10),
        yCenter: rand.Next(-10, 10),
        radius: rand.Next(1, 7));
}

// force pixels to have a 1:1 scale ratio
myPlot.Axes.SquareUnits();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Ellipse'>Ellipse</a> category</div>


