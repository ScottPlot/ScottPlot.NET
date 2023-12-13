---
Title: "Scaled Arrowheads - ScottPlot 4.1 Cookbook"
Description: "Use a slower drawing method that draws tips that are proportional to the length of the arrows."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/vectorfield_fancytips/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Vector Field", "Scaled Arrowheads"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-vector-field", "/cookbook/4.1/recipes/vectorfield_fancytips/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/vectorfield_fancytips.png"
---

<h2><a id='scaled-arrowheads' href='/cookbook/4.1/recipes/vectorfield_fancytips/'>Scaled Arrowheads</a></h2>

Use a slower drawing method that draws tips that are proportional to the length of the arrows.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] xPositions = DataGen.Range(0, 10);
double[] yPositions = DataGen.Range(0, 10);
Vector2[,] vectors = new Vector2[xPositions.Length, yPositions.Length];

for (int x = 0; x < xPositions.Length; x++)
    for (int y = 0; y < yPositions.Length; y++)
        vectors[x, y] = new Vector2(
  x: Math.Sin(xPositions[x]),
  y: Math.Sin(yPositions[y]));

var vf = plt.AddVectorField(vectors, xPositions, yPositions);
vf.ScaledArrowheads = true;
vf.Anchor = ArrowAnchor.Base;
vf.MarkerSize = 3;

plt.SaveFig("vectorField_fancytips.png");
```

<img src='../../images/vectorfield_fancytips.png' class='d-block mx-auto my-5' />


