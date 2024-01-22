---
Title: "Polar Coordinates - ScottPlot 4.1 Cookbook"
Description: "A helper function converts radius and theta arrays into Cartesian coordinates suitable for plotting with traditioanl plot types."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/asis_polar/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Advanced Axis Features", "Polar Coordinates"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/advanced-axis-features", "/cookbook/4.1/recipes/asis_polar/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/asis_polar.png"
---

<h2><a id='polar-coordinates' href='/cookbook/4.1/recipes/asis_polar/'>Polar Coordinates</a></h2>

A helper function converts radius and theta arrays into Cartesian coordinates suitable for plotting with traditioanl plot types.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

// create data with polar coordinates
int count = 400;
double step = 0.01;

double[] rs = new double[count];
double[] thetas = new double[count];

for (int i = 0; i < rs.Length; i++)
{
    rs[i] = 1 + i * step;
    thetas[i] = i * 2 * Math.PI * step;
}

// convert polar data to Cartesian data
(double[] xs, double[] ys) = ScottPlot.Tools.ConvertPolarCoordinates(rs, thetas);

// plot the Cartesian data
plt.AddScatter(xs, ys);

// decorate the plot
plt.Title("Scatter Plot of Polar Data");
plt.AxisScaleLock(true);

plt.SaveFig("asis_polar.png");
```

{{< /code-sp4 >}}

<img src='../../images/asis_polar.png' class='d-block mx-auto my-5' />


