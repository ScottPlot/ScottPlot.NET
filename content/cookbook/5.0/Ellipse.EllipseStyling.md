---
Title: Ellipse Styling - ScottPlot 5.0 Cookbook
Description: Ellipses styles can be extensively customized
URL: /cookbook/5.0/Ellipse/EllipseStyling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Ellipse", "Ellipse Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Ellipse", "/cookbook/5.0/Ellipse/EllipseStyling"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Ellipse Styling</h1>
</div>

Ellipses styles can be extensively customized

[![](/cookbook/5.0/images/EllipseStyling.png?241105214550)](/cookbook/5.0/images/EllipseStyling.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Ellipse.cs" imageUrl="/cookbook/5.0/images/EllipseStyling.png?241105214550" >}}ScottPlot.Plot myPlot = new();

var circle = myPlot.Add.Circle(center: Coordinates.Origin, radius: 5);
circle.LineStyle.Width = 5;
circle.LineStyle.Pattern = LinePattern.Dashed;
circle.LineStyle.Color = Colors.Green;
circle.FillStyle.Color = Colors.Navy;
circle.FillStyle.HatchColor = Colors.Red;
circle.FillStyle.Hatch = new ScottPlot.Hatches.Striped();

myPlot.Axes.SetLimits(-10, 10, -10, 10);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Ellipse'>Ellipse</a> category</div>


