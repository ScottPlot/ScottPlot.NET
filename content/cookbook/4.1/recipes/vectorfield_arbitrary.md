---
Title: "Arbitrary Vectors - ScottPlot 4.1 Cookbook"
Description: "Vectors can be placed arbitrarily in coordiante space (they are not required to be in a grid)"
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/vectorfield_arbitrary/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Vector Field", "Arbitrary Vectors"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-vector-field", "/cookbook/4.1/recipes/vectorfield_arbitrary/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/vectorfield_arbitrary.png"
---

<h2><a id='arbitrary-vectors' href='/cookbook/4.1/recipes/vectorfield_arbitrary/'>Arbitrary Vectors</a></h2>

Vectors can be placed arbitrarily in coordiante space (they are not required to be in a grid)

```cs
var plt = new ScottPlot.Plot(600, 400);

// Create a vector field list and add it to the plot
var field = plt.AddVectorFieldList();

// Optionally color arrows using a colormap and custom scaling function
field.Colormap = Colormap.Turbo;
field.ColormapScaler = (magnitude) => magnitude * 5;

// Additional arrow styling options are here
field.ArrowStyle.ScaledArrowheads = true;
field.ArrowStyle.Anchor = ArrowAnchor.Base;
field.ArrowStyle.LineWidth = 3;
field.ArrowStyle.MarkerSize = 10;
field.ArrowStyle.MarkerShape = MarkerShape.filledDiamond;

// Generate random vectors
Random rand = new(0);
int pointCount = 20;
for (int i = 0; i < pointCount + 1; i++)
{
    double x = i / (double)pointCount;
    double y = Math.Sin(i * 2 * Math.PI / pointCount);
    Coordinate coordinate = new(x, y);

    double dX = i / (double)pointCount * .15;
    double dY = i / (double)pointCount * .15;
    CoordinateVector vector = new(dX, dY);

    var rootedVector = (coordinate, vector);
    field.RootedVectors.Add(rootedVector);
}

plt.SaveFig("vectorField_arbitrary.png");
```

<img src='../../images/vectorfield_arbitrary.png' class='d-block mx-auto my-5' />


