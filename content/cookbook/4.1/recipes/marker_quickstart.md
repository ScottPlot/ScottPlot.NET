---
Title: "Marker - ScottPlot 4.1 Cookbook"
Description: "You can place individual markers anywhere on the plot. "
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/marker_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Marker", "Marker"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-marker", "/cookbook/4.1/recipes/marker_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/marker_quickstart.png"
---

<h2><a id='marker' href='/cookbook/4.1/recipes/marker_quickstart/'>Marker</a></h2>

You can place individual markers anywhere on the plot. 

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

var colormap = ScottPlot.Drawing.Colormap.Turbo;
Random rand = new(0);
for (int i = 0; i < 100; i++)
{
    plt.AddMarker(
        x: rand.NextDouble(),
        y: rand.NextDouble(),
        size: 5 + rand.NextDouble() * 20,
        shape: Marker.Random(rand),
        color: colormap.RandomColor(rand));
}

plt.SaveFig("marker_quickstart.png");
```

{{< /code-sp4 >}}

<img src='../../images/marker_quickstart.png' class='d-block mx-auto my-5' />


