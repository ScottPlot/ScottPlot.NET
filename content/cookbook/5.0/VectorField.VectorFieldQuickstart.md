---
Title: Vector Field Quickstart - ScottPlot 5.0 Cookbook
Description: Vectors (representing a magnitude and direction) can be placed at specific points in coordinate space to display as a vector field.
URL: /cookbook/5.0/VectorField/VectorFieldQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Vector Field", "Vector Field Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/VectorField", "/cookbook/5.0/VectorField/VectorFieldQuickstart"]
Date: 2024-06-29
Version: ScottPlot 5.0.36
Version: ScottPlot 5.0.36
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Vector Field Quickstart


Vectors (representing a magnitude and direction) can be placed at specific points in coordinate space to display as a vector field.

[![](/cookbook/5.0/images/VectorFieldQuickstart.png?240629072232)](/cookbook/5.0/images/VectorFieldQuickstart.png?240629072232)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

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

```

{{< /code-sp5 >}}

<a href='https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/VectorField.cs'><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="mb-1 bi bi-github" viewBox="0 0 16 16">
  <path d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27s1.36.09 2 .27c1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.01 8.01 0 0 0 16 8c0-4.42-3.58-8-8-8"/>
</svg> Edit on GitHub</a>

