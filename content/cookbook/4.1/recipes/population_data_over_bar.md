---
Title: "Data points over bar - ScottPlot 4.1 Cookbook"
Description: "Alternate styling options allow data points to be displayed over the box and whisker plots."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/population_data_over_bar/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Population", "Data points over bar"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-population", "/cookbook/4.1/recipes/population_data_over_bar/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/population_data_over_bar.png"
---

<h2><a id='data-points-over-bar' href='/cookbook/4.1/recipes/population_data_over_bar/'>Data points over bar</a></h2>

Alternate styling options allow data points to be displayed over the box and whisker plots.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
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

// customize the data display format
var popPlot = plt.AddPopulations(poulations);
popPlot.DistributionCurve = false;
popPlot.DataFormat = ScottPlot.Plottable.PopulationPlot.DisplayItems.ScatterOnBox;
popPlot.DataBoxStyle = ScottPlot.Plottable.PopulationPlot.BoxStyle.BarMeanStDev;

// improve the style of the plot
plt.XAxis.Grid(false);
plt.XTicks(populationNames);

plt.SaveFig("population_data_over_bar.png");
```

{{< /code-sp4 >}}

<img src='../../images/population_data_over_bar.png' class='d-block mx-auto my-5' />


