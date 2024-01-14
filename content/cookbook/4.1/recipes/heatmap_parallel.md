---
Title: "Parallel Processing - ScottPlot 4.1 Cookbook"
Description: "Heatmaps have opt-in parallel processing which may improve performance when calling Update() for large datasets."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/heatmap_parallel/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Heatmap", "Parallel Processing"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-heatmap", "/cookbook/4.1/recipes/heatmap_parallel/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/heatmap_parallel.png"
---

<h2><a id='parallel-processing' href='/cookbook/4.1/recipes/heatmap_parallel/'>Parallel Processing</a></h2>

Heatmaps have opt-in parallel processing which may improve performance when calling Update() for large datasets.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[,] data = Generate.Sin2D(width: 1_000, height: 1_000);
var hm = plt.AddHeatmap(data, lockScales: false);

// opt into parallel processing
hm.UseParallel = true;

plt.SaveFig("heatmap_parallel.png");
```

{{< /code-sp4 >}}

<img src='../../images/heatmap_parallel.png' class='d-block mx-auto my-5' />


