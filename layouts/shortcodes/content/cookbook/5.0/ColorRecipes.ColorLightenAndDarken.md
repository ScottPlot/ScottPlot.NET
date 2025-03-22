---
Title: Color Lighten and Darken - ScottPlot 5.0 Cookbook
Description: Helper methods make it easy to lighten or darken colors.
URL: /cookbook/5.0/ColorRecipes/ColorLightenAndDarken/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Color", "Color Lighten and Darken"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ColorRecipes", "/cookbook/5.0/ColorRecipes/ColorLightenAndDarken"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Color Lighten and Darken</h1>
</div>

Helper methods make it easy to lighten or darken colors.

[![](/cookbook/5.0/images/ColorLightenAndDarken.png?250322130304)](/cookbook/5.0/images/ColorLightenAndDarken.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/ColorRecipes.cs" imageUrl="/cookbook/5.0/images/ColorLightenAndDarken.png?250322130304" >}}ScottPlot.Plot myPlot = new();

Color color1 = Colors.Blue;
Color color2 = Colors.Blue;

for (int i = 0; i &lt; 10; i++)
{
    var circle1 = myPlot.Add.Circle(i, 3, 1);
    var circle2 = myPlot.Add.Circle(i, 0, 1);
    circle1.FillColor = color1;
    circle2.FillColor = color2;
    color1 = color1.Lighten(.2);
    color2 = color2.Darken(.2);
}

// set outline style for all circles on the plot
foreach (var circle in myPlot.GetPlottables&lt;ScottPlot.Plottables.Ellipse&gt;())
    circle.LineColor = Colors.Black;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/ColorRecipes'>Color</a> category</div>


