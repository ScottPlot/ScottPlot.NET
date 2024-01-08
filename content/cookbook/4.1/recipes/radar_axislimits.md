---
Title: "Defined Axis Limits - ScottPlot 4.1 Cookbook"
Description: "Radar charts with independent axis limits use scales fitted to the data by default, but scaling can be controlled by defining the maximum value for each axis."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/radar_axislimits/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radar Chart", "Defined Axis Limits"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radar", "/cookbook/4.1/recipes/radar_axislimits/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radar_axislimits.png"
---

<h2><a id='defined-axis-limits' href='/cookbook/4.1/recipes/radar_axislimits/'>Defined Axis Limits</a></h2>

Radar charts with independent axis limits use scales fitted to the data by default, but scaling can be controlled by defining the maximum value for each axis.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[,] values = {
    { 5, 3, 10, 15, 3, 2, 256 },
    { 5, 2, 10, 10, 1, 4, 252 },
};

double[] maxValues = { 13, 15, 17, 15, 10, 10, 413 };

var radar = plt.AddRadar(values, independentAxes: true, maxValues: maxValues);
radar.CategoryLabels = new string[] { "Wins", "Poles", "Podiums", "Points Finishes", "DNFs", "Fastest Laps", "Points" };
radar.GroupLabels = new string[] { "Sebastian Vettel", "Fernando Alonso" };

// customize the plot
plt.Title("2010 Formula One World Championship");
plt.Legend();

/* Data represents the 2010 Formula One World Championship
 * https://en.wikipedia.org/wiki/2010_Formula_One_World_Championship
 * Note: Alonso did not finish (DNF) in the Malaysian GP, but was included 
 * here because he completed >90% of the race distance.
 *
 * Max values are based on https://en.wikipedia.org/wiki/List_of_Formula_One_World_Drivers%27_Champions.
 */

plt.SaveFig("radar_axisLimits.png");
```

<img src='../../images/radar_axislimits.png' class='d-block mx-auto my-5' />


