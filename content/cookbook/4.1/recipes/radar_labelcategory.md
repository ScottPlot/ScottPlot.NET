---
Title: "Labeled Categories - ScottPlot 4.1 Cookbook"
Description: "Category labels can be displayed on the radar chart."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/radar_labelcategory/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radar Chart", "Labeled Categories"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radar", "/cookbook/4.1/recipes/radar_labelcategory/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radar_labelcategory.png"
---

<h2><a id='labeled-categories' href='/cookbook/4.1/recipes/radar_labelcategory/'>Labeled Categories</a></h2>

Category labels can be displayed on the radar chart.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[,] values = {
    { 5, 3, 10, 15, 3, 2, 256 },
    { 5, 2, 10, 10, 1, 4, 252 },
};

var radar = plt.AddRadar(values, independentAxes: true);
radar.CategoryLabels = new string[] { "Wins", "Poles", "Podiums", "Points Finishes", "DNFs", "Fastest Laps", "Points" };
radar.GroupLabels = new[] { "Sebastian Vettel", "Fernando Alonso" };
radar.ShowAxisValues = false;

// customize the plot
plt.Title("2010 Formula One World Championship");
plt.Legend();

/* Data represents the 2010 Formula One World Championship
 * https://en.wikipedia.org/wiki/2010_Formula_One_World_Championship
 * Note: Alonso did not finish (DNF) in the Malaysian GP, but was included 
 * here because he completed >90% of the race distance.
 */

plt.SaveFig("radar_labelCategory.png");
```

<img src='../../images/radar_labelcategory.png' class='d-block mx-auto my-5' />


