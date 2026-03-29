---
Title: Vector Field Quickstart - ScottPlot 5 Cookbook
Description: Vectors (representing a magnitude and direction) can be placed at specific points in coordinate space to display as a vector field.
URL: /cookbook/5/VectorField/VectorFieldQuickstart/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Vector Field", "Vector Field Quickstart"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/VectorField", "/cookbook/5/VectorField/VectorFieldQuickstart"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Vector Field Quickstart</h1>
</div>

Vectors (representing a magnitude and direction) can be placed at specific points in coordinate space to display as a vector field.

[![](/cookbook/5/images/VectorFieldQuickstart.png?260329072039)](/cookbook/5/images/VectorFieldQuickstart.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/VectorField.cs" imageUrl="/cookbook/5/images/VectorFieldQuickstart.png?260329072039" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/VectorField'>Vector Field</a> category</div>


