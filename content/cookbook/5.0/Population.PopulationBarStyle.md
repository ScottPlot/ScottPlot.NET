---
Title: Population Bar Styling - ScottPlot 5.0 Cookbook
Description: The bar symbol in population plots can be extensively styled.
URL: /cookbook/5.0/Population/PopulationBarStyle/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Population Plot", "Population Bar Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Population", "/cookbook/5.0/Population/PopulationBarStyle"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Population Bar Styling</h1>
</div>

The bar symbol in population plots can be extensively styled.

[![](/cookbook/5.0/images/PopulationBarStyle.png?241102170938)](/cookbook/5.0/images/PopulationBarStyle.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Population.cs" imageUrl="/cookbook/5.0/images/PopulationBarStyle.png?241102170938" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i < 5; i++)
{
    double[] values = Generate.RandomNormal(10, mean: 3 + i);
    var pop = myPlot.Add.Population(values, x: i);

    pop.Bar.FillColor = pop.Marker.MarkerLineColor.WithAlpha(.5);
    pop.Bar.LineWidth = 2;
    pop.Bar.ErrorNegative = false;
}

// refine appearance of the plot
myPlot.Axes.Margins(bottom: 0);
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Population'>Population Plot</a> category</div>


