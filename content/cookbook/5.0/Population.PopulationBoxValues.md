---
Title: Population Box Values - ScottPlot 5.0 Cookbook
Description: The values displayed by the box midline, body, and whisker can be configured by assigning a static function to the box value configuration property.
URL: /cookbook/5.0/Population/PopulationBoxValues/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Population Plot", "Population Box Values"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Population", "/cookbook/5.0/Population/PopulationBoxValues"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Population/PopulationBoxValues'>Population Box Values</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Population/PopulationBoxValues">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Population">Category: Population Plot</a>
</div>

The values displayed by the box midline, body, and whisker can be configured by assigning a static function to the box value configuration property.

[![](/cookbook/5.0/images/PopulationBoxValues.png?241031194635)](/cookbook/5.0/images/PopulationBoxValues.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i < 5; i++)
{
    double[] values = Generate.RandomNormal(10, mean: 3 + i);
    var pop = myPlot.Add.Population(values, x: i);
    pop.Bar.IsVisible = false;
    pop.Box.IsVisible = true;

    pop.BoxValueConfig = PopulationSymbol.BoxValueConfigurator_MeanStdErrStDev;
}

// refine appearance of the plot
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


