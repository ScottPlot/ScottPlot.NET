---
Title: Population Quickstart - ScottPlot 5.0 Cookbook
Description: A Population can be created from a collection of values, styled as desired, and placed anywhere on the plot.
URL: /cookbook/5.0/Population/PopulationQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Population Plot", "Population Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Population", "/cookbook/5.0/Population/PopulationQuickstart"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Population/PopulationQuickstart'>Population Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Population/PopulationQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Population">Category: Population Plot</a>
</div>

A Population can be created from a collection of values, styled as desired, and placed anywhere on the plot.

[![](/cookbook/5.0/images/PopulationQuickstart.png?241029205813)](/cookbook/5.0/images/PopulationQuickstart.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i < 5; i++)
{
    double[] values = Generate.RandomNormal(10, mean: 3 + i);
    myPlot.Add.Population(values, x: i);
}

// make the bottom of the plot snap to zero by default
myPlot.Axes.Margins(bottom: 0);

// replace the default numeric ticks with custom ones
double[] tickPositions = Generate.Consecutive(5);
string[] tickLabels = Enumerable.Range(1, 5).Select(x => $"Group {x}").ToArray();
myPlot.Axes.Bottom.SetTicks(tickPositions, tickLabels);

// refine appearance of the plot
myPlot.Axes.Bottom.MajorTickStyle.Length = 0;
myPlot.Axes.Margins(bottom: 0);
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


