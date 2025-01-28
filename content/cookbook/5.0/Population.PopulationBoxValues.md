---
Title: Population Box Values - ScottPlot 5.0 Cookbook
Description: The values displayed by the box midline, body, and whisker can be configured by assigning a static function to the box value configuration property.
URL: /cookbook/5.0/Population/PopulationBoxValues/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Population Plot", "Population Box Values"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Population", "/cookbook/5.0/Population/PopulationBoxValues"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Population Box Values</h1>
</div>

The values displayed by the box midline, body, and whisker can be configured by assigning a static function to the box value configuration property.

[![](/cookbook/5.0/images/PopulationBoxValues.png?250126165944)](/cookbook/5.0/images/PopulationBoxValues.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Population.cs" imageUrl="/cookbook/5.0/images/PopulationBoxValues.png?250126165944" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 5; i++)
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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Population'>Population Plot</a> category</div>


