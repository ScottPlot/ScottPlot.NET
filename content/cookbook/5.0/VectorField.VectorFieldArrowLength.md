---
Title: Vector Field Arrow Length - ScottPlot 5.0 Cookbook
Description: Length of arrows in a vector field may be customized by defining length (in pixel units) to display the longest vector.
URL: /cookbook/5.0/VectorField/VectorFieldArrowLength/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Vector Field", "Vector Field Arrow Length"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/VectorField", "/cookbook/5.0/VectorField/VectorFieldArrowLength"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Vector Field Arrow Length</h1>
</div>

Length of arrows in a vector field may be customized by defining length (in pixel units) to display the longest vector.

[![](/cookbook/5.0/images/VectorFieldArrowLength.png?241112193154)](/cookbook/5.0/images/VectorFieldArrowLength.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/VectorField.cs" imageUrl="/cookbook/5.0/images/VectorFieldArrowLength.png?241112193154" >}}ScottPlot.Plot myPlot = new();

RootedCoordinateVector[] vectors = Generate.SampleVectors();
var vf = myPlot.Add.VectorField(vectors);
vf.MaximumArrowLength = 15;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/VectorField'>Vector Field</a> category</div>


