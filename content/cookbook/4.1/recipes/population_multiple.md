---
Title: "Multiple Populations - ScottPlot 4.1 Cookbook"
Description: "Multiple populations can be assembled into an array and plotted as a single group."
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/population_multiple/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Population", "Multiple Populations"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-population", "/cookbook/4.1/recipes/population_multiple/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/population_multiple.png"
---

<h2><a id='multiple-populations' href='/cookbook/4.1/recipes/population_multiple/'>Multiple Populations</a></h2>

Multiple populations can be assembled into an array and plotted as a single group.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create sample data to represent test scores
Random rand = new Random(0);
double[] valuesA = DataGen.RandomNormal(rand, 35, 85, 5);
double[] valuesB = DataGen.RandomNormal(rand, 42, 87, 3);
double[] valuesC = DataGen.RandomNormal(rand, 23, 92, 3);

// create population objects for each set of data values
var popA = new Statistics.Population(valuesA);
var popB = new Statistics.Population(valuesB);
var popC = new Statistics.Population(valuesC);

// combine several populations into an array and plot it
var poulations = new Statistics.Population[] { popA, popB, popC };
string[] populationNames = { "Group A", "Group B", "Group C" };
plt.AddPopulations(poulations);

// improve the style of the plot
plt.XAxis.Grid(false);
plt.XTicks(populationNames);

plt.SaveFig("population_multiple.png");
```

<img src='../../images/population_multiple.png' class='d-block mx-auto my-5' />


