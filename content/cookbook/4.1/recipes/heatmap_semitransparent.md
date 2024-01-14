---
Title: "Heatmap with Semitransparent Squares - ScottPlot 4.1 Cookbook"
Description: "The intensities of heatmaps are mapped to color, but an optional 2D array of alpha values may be provided to separately control transparency of squares."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/heatmap_semitransparent/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Heatmap with Semitransparent Squares"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_semitransparent/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_semitransparent.png"
---

<h2><a id='heatmap-with-semitransparent-squares' href='/cookbook/4.1/recipes/heatmap_semitransparent/'>Heatmap with Semitransparent Squares</a></h2>

The intensities of heatmaps are mapped to color, but an optional 2D array of alpha values may be provided to separately control transparency of squares.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double?[,] values = {
    { 1, 7, 4, 5 },
    { 9, 3, 2, 4 },
    { 1, 4, 5, 8 },
    { 7, 2, 4, 2 }
};

double?[,] opacities = {
    { 1, 1, 1, 1 },
    { 1, 0, 1, 0 },
    { 1, .75, .5, 0 },
    { 1, .8, .6, .4 }
};

var hm = plt.AddHeatmap(values);
hm.Update(values, opacity: opacities);

plt.AddColorbar(hm);

plt.SaveFig("heatmap_semitransparent.png");
```

{{< /code-sp4 >}}

<img src='../../images/heatmap_semitransparent.png' class='d-block mx-auto my-5' />


