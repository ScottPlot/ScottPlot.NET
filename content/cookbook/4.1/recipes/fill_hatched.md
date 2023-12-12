---
Title: "Hatched Fill - ScottPlot 4.1 Cookbook"
Description: "Hatched Fills are useful for when there are overlapping fills, such as this diagram depicting the ranges of possible producer surpluses under a price floor."
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/fill_hatched/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Fill", "Hatched Fill"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-fill", "/cookbook/4.1/recipes/fill_hatched/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/fill_hatched.png"
---

<h2><a id='hatched-fill' href='/cookbook/4.1/recipes/fill_hatched/'>Hatched Fill</a></h2>

Hatched Fills are useful for when there are overlapping fills, such as this diagram depicting the ranges of possible producer surpluses under a price floor.

```cs
var plt = new ScottPlot.Plot(600, 400);

double SupplyFunction(double q) => 5 * q + 1;
double DemandFunction(double q) => -3 * q + 17;

const double priceFloor = 12.5;
double[] xs = DataGen.Consecutive(5);
double[] supply = xs.Select(SupplyFunction).ToArray();
double[] demand = xs.Select(DemandFunction).ToArray();

plt.AddScatter(xs, supply, markerShape: MarkerShape.none, label: "Supply");
plt.AddScatter(xs, demand, markerShape: MarkerShape.none, label: "Demand");
plt.AddHorizontalLine(priceFloor, label: "Price Floor");

double[] maxProducerSurplusBounds = new double[] { 0, 1.5 };
var maxProducerSurplus = plt.AddFill(maxProducerSurplusBounds, maxProducerSurplusBounds.Select(SupplyFunction).ToArray(), maxProducerSurplusBounds, Enumerable.Repeat(priceFloor, 2).ToArray());
maxProducerSurplus.LineWidth = 0;
maxProducerSurplus.FillColor = Color.LawnGreen;
maxProducerSurplus.HatchColor = Color.Transparent;
maxProducerSurplus.HatchStyle = Drawing.HatchStyle.StripedWideDownwardDiagonal;
maxProducerSurplus.Label = "Maximum Possible Producer Surplus";

double[] minProducerSurplusBounds = new double[] { 1.2, 2.3 };
var minProducerSurplus = plt.AddFill(minProducerSurplusBounds, minProducerSurplusBounds.Select(SupplyFunction).ToArray(), minProducerSurplusBounds, Enumerable.Repeat(priceFloor, 2).ToArray());
minProducerSurplus.LineWidth = 0;
minProducerSurplus.FillColor = Color.Transparent;
minProducerSurplus.HatchColor = Color.Red;
minProducerSurplus.HatchStyle = Drawing.HatchStyle.StripedWideDownwardDiagonal;
minProducerSurplus.Label = "Minimum Possible Producer Surplus";

plt.Legend();

plt.SaveFig("fill_hatched.png");
```

<img src='../../images/fill_hatched.png' class='d-block mx-auto my-5' />


