---
Title: Vector Field - ScottPlot 5.0 Cookbook
Description: Vector fields display a collection of vectors rooted at points in coordinate space
URL: /cookbook/5.0/VectorField/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Vector Field"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/VectorField"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Vector Field</h1>


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/VectorField/VectorFieldQuickstart'>Vector Field Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/VectorField/VectorFieldQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/VectorField">Category: Vector Field</a>
</div>

Vectors (representing a magnitude and direction) can be placed at specific points in coordinate space to display as a vector field.

[![](/cookbook/5.0/images/VectorFieldQuickstart.png?241031194635)](/cookbook/5.0/images/VectorFieldQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// generate a grid of positions
double[] xs = Generate.Consecutive(10);
double[] ys = Generate.Consecutive(10);

// create a collection of vectors
List<RootedCoordinateVector> vectors = new();
for (int i = 0; i < xs.Length; i++)
{
    for (int j = 0; j < ys.Length; j++)
    {
        // point on the grid
        Coordinates pt = new(xs[i], ys[j]);

        // direction & magnitude
        float dX = (float)ys[j];
        float dY = -9.81f / 0.5f * (float)Math.Sin(xs[i]);
        System.Numerics.Vector2 v = new(dX, dY);

        // add to the collection
        RootedCoordinateVector vector = new(pt, v);
        vectors.Add(vector);
    }
}

// plot the collection of rooted vectors as a vector field
myPlot.Add.VectorField(vectors);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/VectorField/VectorFieldColormap'>Vector Field Colormap</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/VectorField/VectorFieldColormap">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/VectorField">Category: Vector Field</a>
</div>

Vector field arrows can be colored according to their magnitude.

[![](/cookbook/5.0/images/VectorFieldColormap.png?241031194635)](/cookbook/5.0/images/VectorFieldColormap.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

RootedCoordinateVector[] vectors = Generate.SampleVectors();
var vf = myPlot.Add.VectorField(vectors);
vf.Colormap = new ScottPlot.Colormaps.Turbo();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


