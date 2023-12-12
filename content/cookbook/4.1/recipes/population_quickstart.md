---
Title: "Population Plot - ScottPlot 4.1 Cookbook"
Description: "The population plot makes it easy to display populations as bar graphs, box-and-whisker plots, scattered values, or box plots and data points side-by-side. The population plot is different than using a box plot with an error bar in that you pass your original data into the population plot and it determines the standard deviation, standard error, quartiles, mean, median, outliers, etc., and you get to determine how to display these values."
Date: 12/11/2023 8:13:10 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/population_quickstart/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Population", "Population Plot"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-population", "/cookbook/4.1/recipes/population_quickstart/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/population_quickstart.png"
---

<h2><a id='population-plot' href='/cookbook/4.1/recipes/population_quickstart/'>Population Plot</a></h2>

The population plot makes it easy to display populations as bar graphs, box-and-whisker plots, scattered values, or box plots and data points side-by-side. The population plot is different than using a box plot with an error bar in that you pass your original data into the population plot and it determines the standard deviation, standard error, quartiles, mean, median, outliers, etc., and you get to determine how to display these values.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create sample data to represent test scores
Random rand = new Random(0);
double[] scores = DataGen.RandomNormal(rand, 35, 85, 5);

// First, create a Population object from your test scores
var pop = new Statistics.Population(scores);

// You can access population statistics as public fields
plt.Title($"Mean: {pop.mean} +/- {pop.stdErr}");

// You can plot a population
plt.AddPopulation(pop);

// improve the style of the plot
plt.XAxis.Ticks(true);
plt.XAxis.Grid(false);

plt.SaveFig("population_quickstart.png");
```

<img src='../../images/population_quickstart.png' class='d-block mx-auto my-5' />


