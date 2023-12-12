---
Title: "Labeled Values - ScottPlot 4.1 Cookbook"
Description: "Labels can be displayed on the arms of the radar chart."
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/radar_labelvalue/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radar Chart", "Labeled Values"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radar", "/cookbook/4.1/recipes/radar_labelvalue/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radar_labelvalue.png"
---

<h2><a href='/cookbook/4.1/recipes/radar_labelvalue/'>Labeled Values</a></h2>

Labels can be displayed on the arms of the radar chart.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[,] values = {
    { 5, 3, 10, 15, 3, 2 },
    { 5, 2, 10, 10, 1, 4 },
};

var radar = plt.AddRadar(values);
radar.CategoryLabels = new string[] { "Wins", "Poles", "Podiums", "Points Finishes", "DNFs", "Fastest Laps" };
radar.GroupLabels = new string[] { "Sebastian Vettel", "Fernando Alonso" };

// customize the plot
plt.Title("2010 Formula One World Championship");
plt.Legend();

/* Data represents the 2010 Formula One World Championship
 * https://en.wikipedia.org/wiki/2010_Formula_One_World_Championship
 * Note: Alonso did not finish (DNF) in the Malaysian GP, but was included 
 * here because he completed >90% of the race distance.
 */

plt.SaveFig("radar_labelValue.png");
```

<img src='../../images/radar_labelvalue.png' class='d-block mx-auto my-5' />


