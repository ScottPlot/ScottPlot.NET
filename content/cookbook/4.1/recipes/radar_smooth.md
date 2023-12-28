---
Title: "Smooth Radar - ScottPlot 4.1 Cookbook"
Description: "The Smooth field controls whether radar areas are drawn with smooth or straight lines."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/radar_smooth/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radar Chart", "Smooth Radar"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radar", "/cookbook/4.1/recipes/radar_smooth/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radar_smooth.png"
---

<h2><a id='smooth-radar' href='/cookbook/4.1/recipes/radar_smooth/'>Smooth Radar</a></h2>

The Smooth field controls whether radar areas are drawn with smooth or straight lines.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[,] values = {
        { 78, 83, 84, 76, 43 },
        { 100, 50, 70, 60, 90 }
    };

var radarPlot = plt.AddRadar(values);
radarPlot.Smooth = true;

plt.SaveFig("radar_smooth.png");
```

<img src='../../images/radar_smooth.png' class='d-block mx-auto my-5' />


