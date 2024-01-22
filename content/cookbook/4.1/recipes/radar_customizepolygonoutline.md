---
Title: "Customizable polygon outline - ScottPlot 4.1 Cookbook"
Description: "The thickness of each radar plot's outline can be customized."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/radar_customizepolygonoutline/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Radar Chart", "Customizable polygon outline"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-radar", "/cookbook/4.1/recipes/radar_customizepolygonoutline/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/radar_customizepolygonoutline.png"
---

<h2><a id='customizable-polygon-outline' href='/cookbook/4.1/recipes/radar_customizepolygonoutline/'>Customizable polygon outline</a></h2>

The thickness of each radar plot's outline can be customized.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
var plt = new ScottPlot.Plot(600, 400);

double[,] values = {
    { 5, 3, 10, 15, 3, 2 },
    { 5, 2, 10, 10, 1, 4 },
};

var radar = plt.AddRadar(values);
radar.OutlineWidth = 3;
radar.GroupLabels = new string[] { "Sebastian Vettel", "Fernando Alonso" };
plt.Title("2010 Formula One World Championship");
plt.Legend();

/* Data represents the 2010 Formula One World Championship
 * https://en.wikipedia.org/wiki/2010_Formula_One_World_Championship
 * Note: Alonso did not finish (DNF) in the Malaysian GP, but was included 
 * here because he completed >90% of the race distance.
 */

plt.SaveFig("radar_customizePolygonOutline.png");
```

{{< /code-sp4 >}}

<img src='../../images/radar_customizepolygonoutline.png' class='d-block mx-auto my-5' />


