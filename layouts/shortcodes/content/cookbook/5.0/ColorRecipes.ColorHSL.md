---
Title: Color HSL - ScottPlot 5.0 Cookbook
Description: Colors may be generated from HSL (hue, saturation, luminosity) values.
URL: /cookbook/5.0/ColorRecipes/ColorHSL/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Color", "Color HSL"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ColorRecipes", "/cookbook/5.0/ColorRecipes/ColorHSL"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Color HSL</h1>
</div>

Colors may be generated from HSL (hue, saturation, luminosity) values.

[![](/cookbook/5.0/images/ColorHSL.png?250322130304)](/cookbook/5.0/images/ColorHSL.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/ColorRecipes.cs" imageUrl="/cookbook/5.0/images/ColorHSL.png?250322130304" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 10; i++)
{
    var circle = myPlot.Add.Circle(i, 0, 1);
    float fraction = (float)i / 10;
    circle.FillColor = Color.FromHSL(hue: fraction, saturation: 1, luminosity: .5f);
    circle.LineColor = Colors.Black;
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/ColorRecipes'>Color</a> category</div>


