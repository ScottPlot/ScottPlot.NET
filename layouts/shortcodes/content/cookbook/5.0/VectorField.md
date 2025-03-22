---
Title: Vector Field - ScottPlot 5.0 Cookbook
Description: Vector fields display a collection of vectors rooted at points in coordinate space
URL: /cookbook/5.0/VectorField/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Vector Field"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/VectorField"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Vector Field</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Vector Field Quickstart</h1>
<a href='/cookbook/5.0/VectorField/VectorFieldQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Vectors (representing a magnitude and direction) can be placed at specific points in coordinate space to display as a vector field.

[![](/cookbook/5.0/images/VectorFieldQuickstart.png?250322130304)](/cookbook/5.0/images/VectorFieldQuickstart.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/VectorField.cs" imageUrl="/cookbook/5.0/images/VectorFieldQuickstart.png?250322130304" >}}ScottPlot.Plot myPlot = new();

// generate a grid of positions
double[] xs = Generate.Consecutive(10);
double[] ys = Generate.Consecutive(10);

// create a collection of vectors
List&lt;RootedCoordinateVector&gt; vectors = new();
for (int i = 0; i &lt; xs.Length; i++)
{
    for (int j = 0; j &lt; ys.Length; j++)
    {
        // point on the grid
        Coordinates pt = new(xs[i], ys[j]);

        // direction &amp; magnitude
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



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Vector Field Colormap</h1>
<a href='/cookbook/5.0/VectorField/VectorFieldColormap' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Vector field arrows can be colored according to their magnitude.

[![](/cookbook/5.0/images/VectorFieldColormap.png?250322130304)](/cookbook/5.0/images/VectorFieldColormap.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/VectorField.cs" imageUrl="/cookbook/5.0/images/VectorFieldColormap.png?250322130304" >}}ScottPlot.Plot myPlot = new();

RootedCoordinateVector[] vectors = Generate.SampleVectors();
var vf = myPlot.Add.VectorField(vectors);
vf.Colormap = new ScottPlot.Colormaps.Turbo();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Vector Field Arrow Length</h1>
<a href='/cookbook/5.0/VectorField/VectorFieldArrowLength' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Length of arrows in a vector field may be customized by defining length (in pixel units) to display the longest vector.

[![](/cookbook/5.0/images/VectorFieldArrowLength.png?250322130304)](/cookbook/5.0/images/VectorFieldArrowLength.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/VectorField.cs" imageUrl="/cookbook/5.0/images/VectorFieldArrowLength.png?250322130304" >}}ScottPlot.Plot myPlot = new();

RootedCoordinateVector[] vectors = Generate.SampleVectors();
var vf = myPlot.Add.VectorField(vectors);
vf.MaximumArrowLength = 15;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


