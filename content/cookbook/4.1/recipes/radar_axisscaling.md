---
Title: "Independent Axis Scaling - ScottPlot 4.1 Cookbook"
Description: "Axis scaling can be independent, allowing values for each category to be displayed using a different scale. When independent axis mode is enabled, axis limits are automatically adjusted to fit the range of the data."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/radar_axisscaling/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radar Chart", "Independent Axis Scaling"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radar", "/cookbook/4.1/recipes/radar_axisscaling/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radar_axisscaling.png"
---

<h2><a id='independent-axis-scaling' href='/cookbook/4.1/recipes/radar_axisscaling/'>Independent Axis Scaling</a></h2>

Axis scaling can be independent, allowing values for each category to be displayed using a different scale. When independent axis mode is enabled, axis limits are automatically adjusted to fit the range of the data.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[,] values = { { 5, 3, 10, 15, 3, 2, 256 }, { 5, 2, 10, 10, 1, 4, 252 }, };

var radar = plt.AddRadar(values, independentAxes: true);
radar.CategoryLabels = new string[] { "Wins", "Poles", "Podiums", "Points Finishes", "DNFs", "Fastest Laps", "Points" };
radar.GroupLabels = new string[] { "Sebastian Vettel", "Fernando Alonso" };

// customize the plot
plt.Title("2010 Formula One World Championship");
plt.Legend();

/* Data represents the 2010 Formula One World Championship
 * https://en.wikipedia.org/wiki/2010_Formula_One_World_Championship
 * Note: Alonso did not finish (DNF) in the Malaysian GP, but was included 
 * here because he completed >90% of the race distance.
 */

plt.SaveFig("radar_axisScaling.png");
```

{{< /code-sp4 >}}

<img src='../../images/radar_axisscaling.png' class='d-block mx-auto my-5' />


