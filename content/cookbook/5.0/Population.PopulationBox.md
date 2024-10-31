---
Title: Population Box Plot - ScottPlot 5.0 Cookbook
Description: Population statistics can be displayed using box plots.
URL: /cookbook/5.0/Population/PopulationBox/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Population Plot", "Population Box Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Population", "/cookbook/5.0/Population/PopulationBox"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Population/PopulationBox'>Population Box Plot</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Population/PopulationBox">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Population">Category: Population Plot</a>
</div>

Population statistics can be displayed using box plots.

[![](/cookbook/5.0/images/PopulationBox.png?241031194635)](/cookbook/5.0/images/PopulationBox.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i < 5; i++)
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

<hr class='my-5 invisible'>


