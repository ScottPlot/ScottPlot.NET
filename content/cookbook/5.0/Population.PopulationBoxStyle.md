---
Title: Population Box Styling - ScottPlot 5.0 Cookbook
Description: The box symbol in population plots can be extensively styled.
URL: /cookbook/5.0/Population/PopulationBoxStyle/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Population Plot", "Population Box Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Population", "/cookbook/5.0/Population/PopulationBoxStyle"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Population/PopulationBoxStyle'>Population Box Styling</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Population/PopulationBoxStyle">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Population">Category: Population Plot</a>
</div>

The box symbol in population plots can be extensively styled.

[![](/cookbook/5.0/images/PopulationBoxStyle.png?241031194635)](/cookbook/5.0/images/PopulationBoxStyle.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i < 5; i++)
{
    double[] values = Generate.RandomNormal(10, mean: 3 + i);
    var pop = myPlot.Add.Population(values, x: i);
    pop.Bar.IsVisible = false;
    pop.Box.IsVisible = true;
    pop.Box.LineWidth = 2;
    pop.Box.FillColor = pop.Marker.MarkerLineColor.WithAlpha(.5);
}

// refine appearance of the plot
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


