---
Title: "Quickstart - ScottPlot 4.1 Cookbook"
Description: "A vector field can be useful to show data explained by differential equations"
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/vectorfield_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Vector Field", "Quickstart"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-vector-field", "/cookbook/4.1/recipes/vectorfield_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/vectorfield_quickstart.png"
---

<h2><a id='quickstart' href='/cookbook/4.1/recipes/vectorfield_quickstart/'>Quickstart</a></h2>

A vector field can be useful to show data explained by differential equations

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

plt.AddVectorField(vectors, xPositions, yPositions);

plt.SaveFig("vectorField_quickstart.png");
```

<img src='../../images/vectorfield_quickstart.png' class='d-block mx-auto my-5' />


