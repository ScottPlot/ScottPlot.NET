---
Title: "Scaled Arrowheads - ScottPlot 4.1 Cookbook"
Description: "Use a slower drawing method that draws tips that are proportional to the length of the arrows."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/vectorfield_fancytips/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Vector Field", "Scaled Arrowheads"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-vector-field", "/cookbook/4.1/recipes/vectorfield_fancytips/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/vectorfield_fancytips.png"
---

<h2><a id='scaled-arrowheads' href='/cookbook/4.1/recipes/vectorfield_fancytips/'>Scaled Arrowheads</a></h2>

Use a slower drawing method that draws tips that are proportional to the length of the arrows.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
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

{{< /code-sp4 >}}

<img src='../../images/vectorfield_fancytips.png' class='d-block mx-auto my-5' />


