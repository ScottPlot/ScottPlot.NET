---
Title: Inverted Palettes - ScottPlot 5 Cookbook
Description: Palettes can be inverted. Palettes that work well on light backgrounds typically work well on dark backgrounds if they are inverted.
URL: /cookbook/5/Styling/PaletteInvert/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Styling Plots", "Inverted Palettes"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Styling", "/cookbook/5/Styling/PaletteInvert"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Inverted Palettes</h1>
</div>

Palettes can be inverted. Palettes that work well on light backgrounds typically work well on dark backgrounds if they are inverted.

[![](/cookbook/5/images/PaletteInvert.png?260329072039)](/cookbook/5/images/PaletteInvert.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5/images/PaletteInvert.png?260329072039" >}}ScottPlot.Plot myPlot = new();

var palette1 = new ScottPlot.Palettes.ColorblindFriendly();
var palette2 = palette1.Inverted();
var palette3 = palette1.InvertedHue();

for (int x = 0; x &lt; palette1.Count(); x++)
{
    CoordinateRect rect1 = CoordinateRect.UnitSquare.WithTranslation(x, 4);
    CoordinateRect rect2 = CoordinateRect.UnitSquare.WithTranslation(x, 2);
    CoordinateRect rect3 = CoordinateRect.UnitSquare.WithTranslation(x, 0);
    var shape1 = myPlot.Add.Rectangle(rect1);
    var shape2 = myPlot.Add.Rectangle(rect2);
    var shape3 = myPlot.Add.Rectangle(rect3);

    // set color using the palette
    shape1.FillColor = palette1.Colors[x];
    shape2.FillColor = palette2.Colors[x];
    shape3.FillColor = palette3.Colors[x];

    shape1.LineColor = shape1.FillColor;
    shape2.LineColor = shape2.FillColor;
    shape3.LineColor = shape3.FillColor;

}

myPlot.Add.Text("Standard", 0, 5.5);
myPlot.Add.Text("Inverted", 0, 3.5);
myPlot.Add.Text("Inverted Hue", 0, 1.5);
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Styling'>Styling Plots</a> category</div>


