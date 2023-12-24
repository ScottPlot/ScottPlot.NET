---
Title: "Multiple Series - ScottPlot 4.1 Cookbook"
Description: "Multiple series of population groups can be plotted Here each group is clustered on the horizontal axis, and each series is given a different color and appears in the legend."
Date: 2023-12-24
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/population_multiseries/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Population", "Multiple Series"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-population", "/cookbook/4.1/recipes/population_multiseries/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/population_multiseries.png"
---

<h2><a id='multiple-series' href='/cookbook/4.1/recipes/population_multiseries/'>Multiple Series</a></h2>

Multiple series of population groups can be plotted Here each group is clustered on the horizontal axis, and each series is given a different color and appears in the legend.

```cs
var plt = new ScottPlot.Plot(600, 400);

// Each class (A, B, C) is a series.
// Each semester (fall, spring, summer A, summer B) is a group.

// create sample data to represent test scores for each class in each semester
Random rand = new Random(0);
double[] scoresAfall = DataGen.RandomNormal(rand, 35, 85, 5);
double[] scoresBfall = DataGen.RandomNormal(rand, 42, 87, 5);
double[] scoresCfall = DataGen.RandomNormal(rand, 23, 82, 5);
double[] scoresAspring = DataGen.RandomNormal(rand, 35, 84, 3);
double[] scoresBspring = DataGen.RandomNormal(rand, 42, 88, 3);
double[] scoresCspring = DataGen.RandomNormal(rand, 23, 84, 3);
double[] scoresAsumA = DataGen.RandomNormal(rand, 35, 80, 5);
double[] scoresBsumA = DataGen.RandomNormal(rand, 42, 90, 5);
double[] scoresCsumA = DataGen.RandomNormal(rand, 23, 85, 5);
double[] scoresAsumB = DataGen.RandomNormal(rand, 35, 91, 2);
double[] scoresBsumB = DataGen.RandomNormal(rand, 42, 93, 2);
double[] scoresCsumB = DataGen.RandomNormal(rand, 23, 90, 2);

// Collect multiple populations into a PopulationSeries.
// All populations in a series will be styled the same and appear once in the legend.
var popsA = new Statistics.Population[] {
    new Statistics.Population(scoresAfall),
    new Statistics.Population(scoresAspring),
    new Statistics.Population(scoresAsumA),
    new Statistics.Population(scoresAsumB)
};

var popsB = new Statistics.Population[] {
    new Statistics.Population(scoresBfall),
    new Statistics.Population(scoresBspring),
    new Statistics.Population(scoresBsumA),
    new Statistics.Population(scoresBsumB)
};

var popsC = new Statistics.Population[] {
    new Statistics.Population(scoresCfall),
    new Statistics.Population(scoresCspring),
    new Statistics.Population(scoresCsumA),
    new Statistics.Population(scoresCsumB)
};

// create a population series for each array of populations and give it a label
var seriesA = new Statistics.PopulationSeries(popsA, "Class A");
var seriesB = new Statistics.PopulationSeries(popsB, "Class B");
var seriesC = new Statistics.PopulationSeries(popsC, "Class C");
var allSeries = new Statistics.PopulationSeries[] { seriesA, seriesB, seriesC };

// create a MultiSeries from multiple population series and plot it
var multiSeries = new Statistics.PopulationMultiSeries(allSeries);
plt.AddPopulations(multiSeries);

// improve the style of the plot
string[] groupNames = new string[] { "Fall", "Spring", "Summer A", "Summer B" };
plt.XTicks(groupNames);
plt.XAxis.Grid(false);
plt.Legend();

plt.SaveFig("population_multiSeries.png");
```

<img src='../../images/population_multiseries.png' class='d-block mx-auto my-5' />


