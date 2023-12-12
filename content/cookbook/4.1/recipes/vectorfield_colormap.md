---
Title: "Custom Colormap - ScottPlot 4.1 Cookbook"
Description: "A colormap can be supplied to color arrows according to their magnitude"
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/vectorfield_colormap/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Vector Field", "Custom Colormap"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-vector-field", "/cookbook/4.1/recipes/vectorfield_colormap/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/vectorfield_colormap.png"
---

<h2><a id='custom-colormap' href='/cookbook/4.1/recipes/vectorfield_colormap/'>Custom Colormap</a></h2>

A colormap can be supplied to color arrows according to their magnitude

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Range(-5, 5, .5);
double[] ys = DataGen.Range(-5, 5, .5);
Vector2[,] vectors = new Vector2[xs.Length, ys.Length];
double r = 0.5;


for (int i = 0; i < xs.Length; i++)
{
    for (int j = 0; j < ys.Length; j++)
    {
        double x = ys[j];
        double y = -9.81 / r * Math.Sin(xs[i]);

        vectors[i, j] = new Vector2(x, y);
    }
}

plt.AddVectorField(vectors, xs, ys, colormap: Drawing.Colormap.Turbo);
plt.XLabel("θ");
plt.YLabel("dθ/dt");

plt.SaveFig("vectorField_colormap.png");
```

<img src='../../images/vectorfield_colormap.png' class='d-block mx-auto my-5' />


