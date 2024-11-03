---
Title: Vector Field Colormap - ScottPlot 5.0 Cookbook
Description: Vector field arrows can be colored according to their magnitude.
URL: /cookbook/5.0/VectorField/VectorFieldColormap/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Vector Field", "Vector Field Colormap"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/VectorField", "/cookbook/5.0/VectorField/VectorFieldColormap"]
Date: 2024-11-03
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Vector Field Colormap</h1>
</div>

Vector field arrows can be colored according to their magnitude.

[![](/cookbook/5.0/images/VectorFieldColormap.png?241103171511)](/cookbook/5.0/images/VectorFieldColormap.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/VectorField.cs" imageUrl="/cookbook/5.0/images/VectorFieldColormap.png?241103171511" >}}ScottPlot.Plot myPlot = new();

RootedCoordinateVector[] vectors = Generate.SampleVectors();
var vf = myPlot.Add.VectorField(vectors);
vf.Colormap = new ScottPlot.Colormaps.Turbo();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/VectorField'>Vector Field</a> category</div>


