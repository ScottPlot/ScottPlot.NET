---
Title: "Scale Limits - ScottPlot 4.1 Cookbook"
Description: "Heatmap colormap scale can use a defined min/max value."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/heatmap_limitscale/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Scale Limits"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_limitscale/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_limitscale.png"
---

<h2><a id='scale-limits' href='/cookbook/4.1/recipes/heatmap_limitscale/'>Scale Limits</a></h2>

Heatmap colormap scale can use a defined min/max value.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[,] intensities = new double[100, 100];
for (int x = 0; x < 100; x++)
    for (int y = 0; y < 100; y++)
        intensities[x, y] = (Math.Sin(x * .2) + Math.Cos(y * .2)) * 100;

// scale the colors between 0 and 200
var hm = plt.AddHeatmap(intensities);
hm.Update(intensities, min: 0, max: 200);

// add a colorbar with custom ticks
var cb = plt.AddColorbar(hm);
double[] tickPositions = ScottPlot.DataGen.Range(0, 200, 25, true);
string[] tickLabels = tickPositions.Select(x => x.ToString()).ToArray();
cb.SetTicks(tickPositions, tickLabels, min: 0, max: 200);

plt.SaveFig("heatmap_limitScale.png");
```

<img src='../../images/heatmap_limitscale.png' class='d-block mx-auto my-5' />


