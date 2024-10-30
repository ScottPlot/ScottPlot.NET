---
Title: Vector Field Colormap - ScottPlot 5.0 Cookbook
Description: Vector field arrows can be colored according to their magnitude.
URL: /cookbook/5.0/VectorField/VectorFieldColormap/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Vector Field", "Vector Field Colormap"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/VectorField", "/cookbook/5.0/VectorField/VectorFieldColormap"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/VectorField/VectorFieldColormap'>Vector Field Colormap</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/VectorField/VectorFieldColormap">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/VectorField">Category: Vector Field</a>
</div>

Vector field arrows can be colored according to their magnitude.

[![](/cookbook/5.0/images/VectorFieldColormap.png?241029205813)](/cookbook/5.0/images/VectorFieldColormap.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

RootedCoordinateVector[] vectors = Generate.SampleVectors();
var vf = myPlot.Add.VectorField(vectors);
vf.Colormap = new ScottPlot.Colormaps.Turbo();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


