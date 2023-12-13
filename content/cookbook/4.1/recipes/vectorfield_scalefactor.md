---
Title: "Custom Scale Factor - ScottPlot 4.1 Cookbook"
Description: "A custom scale factor can adjust the length of the arrows."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/vectorfield_scalefactor/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Vector Field", "Custom Scale Factor"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-vector-field", "/cookbook/4.1/recipes/vectorfield_scalefactor/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/vectorfield_scalefactor.png"
---

<h2><a id='custom-scale-factor' href='/cookbook/4.1/recipes/vectorfield_scalefactor/'>Custom Scale Factor</a></h2>

A custom scale factor can adjust the length of the arrows.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Range(-1.5, 1.5, .25);
double[] ys = DataGen.Range(-1.5, 1.5, .25);
Vector2[,] vectors = new Vector2[xs.Length, ys.Length];

for (int i = 0; i < xs.Length; i++)
{
    for (int j = 0; j < ys.Length; j++)
    {
        double x = xs[i];
        double y = ys[j];
        var e = Math.Exp(-x * x - y * y);
        var dx = (1 - 2 * x * x) * e;
        var dy = -2 * x * y * e;

        vectors[i, j] = new Vector2(dx, dy);
    }
}

plt.AddVectorField(vectors, xs, ys, scaleFactor: 0.3);

plt.SaveFig("vectorField_scaleFactor.png");
```

<img src='../../images/vectorfield_scalefactor.png' class='d-block mx-auto my-5' />


