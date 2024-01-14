---
Title: "All marker shapes - ScottPlot 4.1 Cookbook"
Description: "Legend indicates names of all available marker shapes"
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/scatter_markershape/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "All marker shapes"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatter_markershape/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatter_markershape.png"
---

<h2><a id='all-marker-shapes' href='/cookbook/4.1/recipes/scatter_markershape/'>All marker shapes</a></h2>

Legend indicates names of all available marker shapes

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

int pointCount = 51;
double[] xs = DataGen.Consecutive(pointCount);

string[] markerShapeNames = Enum.GetNames(typeof(MarkerShape));
for (int i = 0; i < markerShapeNames.Length; i++)
{
    Enum.TryParse(markerShapeNames[i], out MarkerShape ms);
    double[] ys = DataGen.Sin(pointCount, 2, -i);
    var sp = plt.AddScatter(xs, ys);
    sp.LineWidth = 2;
    sp.LineColor = Color.FromArgb(50, sp.LineColor);
    sp.MarkerSize = 7;
    sp.MarkerShape = ms;
    sp.Label = ms.ToString();
}

plt.Grid(enable: false);
var legend = plt.Legend();
legend.FontSize = 10;

plt.SaveFig("scatter_markerShape.png");
```

{{< /code-sp4 >}}

<img src='../../images/scatter_markershape.png' class='d-block mx-auto my-5' />


