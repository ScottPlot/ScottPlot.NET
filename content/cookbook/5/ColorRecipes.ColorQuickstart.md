---
Title: Color Quickstart - ScottPlot 5 Cookbook
Description: ScottPlot.Colors contains many colors
URL: /cookbook/5/ColorRecipes/ColorQuickstart/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Color", "Color Quickstart"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/ColorRecipes", "/cookbook/5/ColorRecipes/ColorQuickstart"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Color Quickstart</h1>
</div>

ScottPlot.Colors contains many colors

[![](/cookbook/5/images/ColorQuickstart.png?260329072039)](/cookbook/5/images/ColorQuickstart.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/ColorRecipes.cs" imageUrl="/cookbook/5/images/ColorQuickstart.png?260329072039" >}}ScottPlot.Plot myPlot = new();

var circle1 = myPlot.Add.Circle(0, 0, 1);
var circle2 = myPlot.Add.Circle(1, 0, 1);
var circle3 = myPlot.Add.Circle(2, 0, 1);

circle1.FillColor = Colors.Red;
circle2.FillColor = Colors.Green;
circle3.FillColor = Colors.Blue;

// set outline style for all circles on the plot
foreach (var circle in myPlot.GetPlottables&lt;ScottPlot.Plottables.Ellipse&gt;())
    circle.LineColor = Colors.Black;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/ColorRecipes'>Color</a> category</div>


