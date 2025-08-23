---
Title: Creating Colors - ScottPlot 5.0 Cookbook
Description: ScottPlot.Colors can be constructed from RGB values (0-255), HTML style hexadecimal color codes (00-FF), or System.Drawing.Color objects.
URL: /cookbook/5.0/ColorRecipes/ColorHex/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Color", "Creating Colors"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ColorRecipes", "/cookbook/5.0/ColorRecipes/ColorHex"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Creating Colors</h1>
</div>

ScottPlot.Colors can be constructed from RGB values (0-255), HTML style hexadecimal color codes (00-FF), or System.Drawing.Color objects.

[![](/cookbook/5.0/images/ColorHex.png?250822231048)](/cookbook/5.0/images/ColorHex.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/ColorRecipes.cs" imageUrl="/cookbook/5.0/images/ColorHex.png?250822231048" >}}ScottPlot.Plot myPlot = new();

var circle1 = myPlot.Add.Circle(0, 0, 1);
var circle2 = myPlot.Add.Circle(1, 0, 1);
var circle3 = myPlot.Add.Circle(2, 0, 1);

circle1.FillColor = new Color(red: 255, green: 0, blue: 0);
circle2.FillColor = new Color(System.Drawing.Color.Green);
circle3.FillColor = new Color("#0000FF");

// set outline style for all circles on the plot
foreach (var circle in myPlot.GetPlottables&lt;ScottPlot.Plottables.Ellipse&gt;())
    circle.LineColor = Colors.Black;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/ColorRecipes'>Color</a> category</div>


