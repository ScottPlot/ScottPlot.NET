---
Title: Population Bar Styling - ScottPlot 5.0 Cookbook
Description: The bar symbol in population plots can be extensively styled.
URL: /cookbook/5.0/Population/PopulationBarStyle/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Population Plot", "Population Bar Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Population", "/cookbook/5.0/Population/PopulationBarStyle"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Population/PopulationBarStyle'>Population Bar Styling</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Population/PopulationBarStyle">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Population">Category: Population Plot</a>
</div>

The bar symbol in population plots can be extensively styled.

[![](/cookbook/5.0/images/PopulationBarStyle.png?241029205813)](/cookbook/5.0/images/PopulationBarStyle.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


