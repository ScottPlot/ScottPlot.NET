---
Title: "Angle and Magnitude - ScottPlot 4.1 Cookbook"
Description: "This example demonstrates how to define vectors according to a given angle and magnitude."
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/vectorfield_anglemag/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Vector Field", "Angle and Magnitude"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-vector-field", "/cookbook/4.1/recipes/vectorfield_anglemag/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/vectorfield_anglemag.png"
---

<h2><a href='/cookbook/4.1/recipes/vectorfield_anglemag/'>Angle and Magnitude</a></h2>

This example demonstrates how to define vectors according to a given angle and magnitude.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Range(-5, 6);
double[] ys = DataGen.Range(-5, 6);
Vector2[,] vectors = new Vector2[xs.Length, ys.Length];

for (int i = 0; i < xs.Length; i++)
{
    for (int j = 0; j < ys.Length; j++)
    {
        double slope = -xs[i];
        double magnitude = Math.Abs(xs[i]);
        double angle = Math.Atan(slope);

        vectors[i, j] = new Vector2(Math.Cos(angle) * magnitude, Math.Sin(angle) * magnitude);
    }
}

plt.AddVectorField(vectors, xs, ys);

plt.SaveFig("vectorField_angleMag.png");
```

<img src='../../images/vectorfield_anglemag.png' class='d-block mx-auto my-5' />


