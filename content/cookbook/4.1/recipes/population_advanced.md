---
Title: "Advanced Population Styling - ScottPlot 4.1 Cookbook"
Description: "Populations can be displayed many different ways. Scatter values can be displayed on either side of the bar or bar. Populations can be shown as bar graphs instead of box plots. Public fields allow many additional customizations."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/population_advanced/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Population", "Advanced Population Styling"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-population", "/cookbook/4.1/recipes/population_advanced/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/population_advanced.png"
---

<h2><a id='advanced-population-styling' href='/cookbook/4.1/recipes/population_advanced/'>Advanced Population Styling</a></h2>

Populations can be displayed many different ways. Scatter values can be displayed on either side of the bar or bar. Populations can be shown as bar graphs instead of box plots. Public fields allow many additional customizations.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create sample data to represent test scores
Random rand = new Random(0);
double[] scoresA = DataGen.RandomNormal(rand, 35, 72, 7);
double[] scoresB = DataGen.RandomNormal(rand, 42, 57, 10);
double[] scoresC = DataGen.RandomNormal(rand, 23, 79, 5);

// To create a population series we need to start with an array of populations.
// In this example each population series just has one population in it.
var popsA = new Statistics.Population[] { new Statistics.Population(scoresA) };
var popsB = new Statistics.Population[] { new Statistics.Population(scoresB) };
var popsC = new Statistics.Population[] { new Statistics.Population(scoresC) };

// create a PopulationSeries for each set of scores, naming it in the process
var seriesA = new Statistics.PopulationSeries(popsA, "Class A");
var seriesB = new Statistics.PopulationSeries(popsB, "Class B");
var seriesC = new Statistics.PopulationSeries(popsC, "Class C");
var seriesArray = new Statistics.PopulationSeries[] { seriesA, seriesB, seriesC };

// create a MultiSeries object by passing in the array of series objects and plot it
var multiSeries = new Statistics.PopulationMultiSeries(seriesArray);
var popPlot = plt.AddPopulations(multiSeries);

// now customize its public fields to extensively customize its display options
popPlot.DistributionCurve = true;
popPlot.DistributionCurveLineStyle = LineStyle.Dash;
popPlot.ScatterOutlineColor = System.Drawing.Color.Transparent;
popPlot.DataFormat = ScottPlot.Plottable.PopulationPlot.DisplayItems.ScatterAndBox;
popPlot.DataBoxStyle = ScottPlot.Plottable.PopulationPlot.BoxStyle.BarMeanStDev;

// colors are managed at the population series level:
foreach (var popSeries in popPlot.MultiSeries.multiSeries)
    popSeries.color = Tools.GetRandomColor(rand);

// improve the style of the plot
plt.Legend(location: Alignment.LowerLeft);
plt.XAxis.Ticks(false);
plt.XAxis.Grid(false);
plt.YAxis.MajorGrid(lineStyle: LineStyle.Dot);
plt.SetAxisLimits(yMin: 0);

plt.SaveFig("population_advanced.png");
```

<img src='../../images/population_advanced.png' class='d-block mx-auto my-5' />


