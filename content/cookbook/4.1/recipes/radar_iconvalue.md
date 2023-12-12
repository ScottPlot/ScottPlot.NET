---
Title: "Categories with images - ScottPlot 4.1 Cookbook"
Description: "Images can be displayed on the arms of the radar chart. When using images, labels will be ignored so setting them will have no effect."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/radar_iconvalue/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radar Chart", "Categories with images"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radar", "/cookbook/4.1/recipes/radar_iconvalue/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radar_iconvalue.png"
---

<h2><a href='/cookbook/4.1/recipes/radar_iconvalue/'>Categories with images</a></h2>

Images can be displayed on the arms of the radar chart. When using images, labels will be ignored so setting them will have no effect.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[,] values = {
    { 5, 15, 3, 2 },
    { 5, 10, 1, 4 },
};

var radar = plt.AddRadar(values);
radar.CategoryImages = CategoryImages;
radar.GroupLabels = new string[] { "Sebastian Vettel", "Fernando Alonso" };

// customize the plot
plt.Title("2010 Formula One World Championship");
plt.Legend();

/* Data represents the 2010 Formula One World Championship
 * https://en.wikipedia.org/wiki/2010_Formula_One_World_Championship
 * Note: Alonso did not finish (DNF) in the Malaysian GP, but was included 
 * here because he completed >90% of the race distance.
 */

plt.SaveFig("radar_iconValue.png");
```

<img src='../../images/radar_iconvalue.png' class='d-block mx-auto my-5' />


