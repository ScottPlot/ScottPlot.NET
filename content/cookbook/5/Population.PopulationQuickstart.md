---
Title: Population Quickstart - ScottPlot 5 Cookbook
Description: A Population can be created from a collection of values, styled as desired, and placed anywhere on the plot.
URL: /cookbook/5/Population/PopulationQuickstart/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Population Plot", "Population Quickstart"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Population", "/cookbook/5/Population/PopulationQuickstart"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Population Quickstart</h1>
</div>

A Population can be created from a collection of values, styled as desired, and placed anywhere on the plot.

[![](/cookbook/5/images/PopulationQuickstart.png?260329072039)](/cookbook/5/images/PopulationQuickstart.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Population.cs" imageUrl="/cookbook/5/images/PopulationQuickstart.png?260329072039" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 5; i++)
{
    double[] values = Generate.RandomNormal(10, mean: 3 + i);
    myPlot.Add.Population(values, x: i);
}

// make the bottom of the plot snap to zero by default
myPlot.Axes.Margins(bottom: 0);

// replace the default numeric ticks with custom ones
double[] tickPositions = Generate.Consecutive(5);
string[] tickLabels = Enumerable.Range(1, 5).Select(x =&gt; $"Group {x}").ToArray();
myPlot.Axes.Bottom.SetTicks(tickPositions, tickLabels);

// refine appearance of the plot
myPlot.Axes.Bottom.MajorTickStyle.Length = 0;
myPlot.Axes.Margins(bottom: 0);
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Population'>Population Plot</a> category</div>


