---
Title: Alpha Channel - ScottPlot 5.0 Cookbook
Description: The Alpha channel sets transparency of a color
URL: /cookbook/5.0/ColorRecipes/ColorTransparency/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Color", "Alpha Channel"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ColorRecipes", "/cookbook/5.0/ColorRecipes/ColorTransparency"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Alpha Channel</h1>
</div>

The Alpha channel sets transparency of a color

[![](/cookbook/5.0/images/ColorTransparency.png?250322130304)](/cookbook/5.0/images/ColorTransparency.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/ColorRecipes.cs" imageUrl="/cookbook/5.0/images/ColorTransparency.png?250322130304" >}}ScottPlot.Plot myPlot = new();

var circle1 = myPlot.Add.Circle(0, 0, 1);
var circle2 = myPlot.Add.Circle(1, 0, 1);
var circle3 = myPlot.Add.Circle(2, 0, 1);

circle1.FillColor = new Color(red: 255, green: 0, blue: 0, alpha: 128);
circle2.FillColor = Colors.Green.WithAlpha(.5);
circle3.FillColor = Colors.Blue.WithAlpha(.5);

// set outline style for all circles on the plot
foreach (var circle in myPlot.GetPlottables&lt;ScottPlot.Plottables.Ellipse&gt;())
    circle.LineColor = Colors.Black;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/ColorRecipes'>Color</a> category</div>


