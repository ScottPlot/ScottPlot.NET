---
Title: "Radar - ScottPlot 4.1 Cookbook"
Description: "A radar chart concisely displays multiple values. Radar plots are also called a spider charts or star charts."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/radar_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radar Chart", "Radar"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radar", "/cookbook/4.1/recipes/radar_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radar_quickstart.png"
---

<h2><a id='radar' href='/cookbook/4.1/recipes/radar_quickstart/'>Radar</a></h2>

A radar chart concisely displays multiple values. Radar plots are also called a spider charts or star charts.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

plt.AddRadar(values);

// improve plot styling
plt.Frameless();
plt.Grid(enable: false);

plt.SaveFig("radar_quickstart.png");
```

<img src='../../images/radar_quickstart.png' class='d-block mx-auto my-5' />


