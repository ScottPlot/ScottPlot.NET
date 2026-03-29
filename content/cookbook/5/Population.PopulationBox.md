---
Title: Population Box Plot - ScottPlot 5 Cookbook
Description: Population statistics can be displayed using box plots.
URL: /cookbook/5/Population/PopulationBox/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Population Plot", "Population Box Plot"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Population", "/cookbook/5/Population/PopulationBox"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Population Box Plot</h1>
</div>

Population statistics can be displayed using box plots.

[![](/cookbook/5/images/PopulationBox.png?260329072039)](/cookbook/5/images/PopulationBox.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Population.cs" imageUrl="/cookbook/5/images/PopulationBox.png?260329072039" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 5; i++)
{
    double[] values = Generate.RandomNormal(10, mean: 3 + i);
    var pop = myPlot.Add.Population(values, x: i);

    // disable visibility of the bar symbol
    pop.Bar.IsVisible = false;

    // enable visibility of the box symbol
    pop.Box.IsVisible = true;
}

// refine appearance of the plot
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Population'>Population Plot</a> category</div>


