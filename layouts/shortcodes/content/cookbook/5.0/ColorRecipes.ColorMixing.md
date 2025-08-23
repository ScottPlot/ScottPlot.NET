---
Title: Color Mixing - ScottPlot 5.0 Cookbook
Description: Colors have a MixWith() method that can be used to blend two colors
URL: /cookbook/5.0/ColorRecipes/ColorMixing/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Color", "Color Mixing"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ColorRecipes", "/cookbook/5.0/ColorRecipes/ColorMixing"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Color Mixing</h1>
</div>

Colors have a MixWith() method that can be used to blend two colors

[![](/cookbook/5.0/images/ColorMixing.png?250822231048)](/cookbook/5.0/images/ColorMixing.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/ColorRecipes.cs" imageUrl="/cookbook/5.0/images/ColorMixing.png?250822231048" >}}ScottPlot.Plot myPlot = new();

Color color1 = Colors.Blue;
Color color2 = Colors.Green;

for (int i = 0; i &lt; 10; i++)
{
    var circle = myPlot.Add.Circle(i, 0, 1);
    double fraction = (double)i / 10;
    circle.FillColor = color1.MixedWith(color2, fraction);
    circle.LineColor = Colors.Black;
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/ColorRecipes'>Color</a> category</div>


