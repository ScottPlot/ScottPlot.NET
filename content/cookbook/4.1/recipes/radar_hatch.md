---
Title: "Customizable hatching (pattern) - ScottPlot 4.1 Cookbook"
Description: "The hatch of each radar plot can be customized"
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/radar_hatch/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radar Chart", "Customizable hatching (pattern)"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radar", "/cookbook/4.1/recipes/radar_hatch/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radar_hatch.png"
---

<h2><a href='/cookbook/4.1/recipes/radar_hatch/'>Customizable hatching (pattern)</a></h2>

The hatch of each radar plot can be customized

```cs
var plt = new ScottPlot.Plot(600, 400);

double[,] values = {
    { 5, 3, 10, 15, 3, 2 },
    { 5, 2, 10, 10, 1, 4 },
};

var radar = plt.AddRadar(values);
radar.HatchOptions = new HatchOptions[]
{
    new() { Pattern = HatchStyle.StripedUpwardDiagonal, Color = Color.FromArgb(100, Color.Gray) },
    new() { Pattern = HatchStyle.StripedDownwardDiagonal, Color = Color.FromArgb(100, Color.Gray) },
};

radar.GroupLabels = new string[] { "Sebastian Vettel", "Fernando Alonso" };
plt.Title("2010 Formula One World Championship");
plt.Legend();

/* Data represents the 2010 Formula One World Championship
 * https://en.wikipedia.org/wiki/2010_Formula_One_World_Championship
 * Note: Alonso did not finish (DNF) in the Malaysian GP, but was included 
 * here because he completed >90% of the race distance.
 */

plt.SaveFig("radar_hatch.png");
```

<img src='../../images/radar_hatch.png' class='d-block mx-auto my-5' />


