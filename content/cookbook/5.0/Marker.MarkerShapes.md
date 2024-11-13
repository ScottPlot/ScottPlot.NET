---
Title: Marker Shapes - ScottPlot 5.0 Cookbook
Description: Standard marker shapes are provided, but advanced users are able to create their own as well.
URL: /cookbook/5.0/Marker/MarkerShapes/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Marker", "Marker Shapes"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Marker", "/cookbook/5.0/Marker/MarkerShapes"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Marker Shapes</h1>
</div>

Standard marker shapes are provided, but advanced users are able to create their own as well.

[![](/cookbook/5.0/images/MarkerShapes.png?241112193154)](/cookbook/5.0/images/MarkerShapes.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Marker.cs" imageUrl="/cookbook/5.0/images/MarkerShapes.png?241112193154" >}}ScottPlot.Plot myPlot = new();

MarkerShape[] markerShapes = Enum.GetValues&lt;MarkerShape&gt;().ToArray();
ScottPlot.Palettes.Category20 palette = new();

for (int i = 0; i &lt; markerShapes.Length; i++)
{
    var mp = myPlot.Add.Marker(x: i, y: 0);
    mp.MarkerStyle.Shape = markerShapes[i];
    mp.MarkerStyle.Size = 10;

    // markers made from filled shapes have can be customized
    mp.MarkerStyle.FillColor = palette.GetColor(i).WithAlpha(.5);

    // markers made from filled shapes have optional outlines
    mp.MarkerStyle.OutlineColor = palette.GetColor(i);
    mp.MarkerStyle.OutlineWidth = 2;

    // markers created from lines can be customized
    mp.MarkerStyle.LineWidth = 2f;
    mp.MarkerStyle.LineColor = palette.GetColor(i);

    var txt = myPlot.Add.Text(markerShapes[i].ToString(), i, 0.15);
    txt.LabelRotation = -90;
    txt.LabelAlignment = Alignment.MiddleLeft;
    txt.LabelFontColor = Colors.Black;
}

myPlot.Title("Marker Names");
myPlot.Axes.SetLimits(-1, markerShapes.Length, -1, 4);
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Marker'>Marker</a> category</div>


