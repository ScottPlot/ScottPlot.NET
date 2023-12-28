---
Title: "Customizing Colors - ScottPlot 4.1 Cookbook"
Description: "Population plots apply different transparencies to boxes and markers by default. Precise control of colors can be achieved by defining alpha overrides as shown here."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/population_custom_colors/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Population", "Customizing Colors"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-population", "/cookbook/4.1/recipes/population_custom_colors/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/population_custom_colors.png"
---

<h2><a id='customizing-colors' href='/cookbook/4.1/recipes/population_custom_colors/'>Customizing Colors</a></h2>

Population plots apply different transparencies to boxes and markers by default. Precise control of colors can be achieved by defining alpha overrides as shown here.

```cs
var plt = new ScottPlot.Plot(600, 400);

// Define population data (3 groups, 2 series per group)
double[][][] seriesData = new[] {
    new[] { new []{1.0, 2.0, 3.0}, new []{2.0, 3.0, 4.0}, new []{5.0, 6.0, 7.0} },
    new[] { new []{8.0, 9.0, 10.0}, new []{11.0, 12.0, 13.0}, new []{14.0, 15.0, 16.0} }
};

// Build the population plot and add it to the graph
Statistics.Population[][] populations = seriesData.Select(series => series.Select(seriesData => new Statistics.Population(seriesData)).ToArray()).ToArray();
Statistics.PopulationSeries[] populationSeries = populations.Select((p, i) => new Statistics.PopulationSeries(p, seriesLabel: $"Series {i}")).ToArray();
Statistics.PopulationMultiSeries populationMultiSeries = new(populationSeries.ToArray());
var populationPlot = plt.AddPopulations(populationMultiSeries);

// Add group and series labels
plt.XTicks(new string[] { "Group A", "Group B", "Group C" });
plt.Legend();

// Define specific colors for each group
populationSeries[0].color = Color.FromArgb(alpha: 100, red: 255, green: 0, blue: 0);
populationSeries[1].color = Color.FromArgb(alpha: 255, red: 0, green: 0, blue: 255);

// Manually define transparency for boxes and markers - alpha values will now be set using the series colors
populationPlot.AutomaticOpacity = false;

// Make scatter markers 75% as opaque as box plots
populationPlot.MarkerOpacityRatio = 0.75;

plt.SaveFig("population_custom_colors.png");
```

<img src='../../images/population_custom_colors.png' class='d-block mx-auto my-5' />


