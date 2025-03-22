---
Title: Population Marker Styling - ScottPlot 5.0 Cookbook
Description: The data markers in population plots can be extensively styled.
URL: /cookbook/5.0/Population/PopulationMarkerStyle/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Population Plot", "Population Marker Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Population", "/cookbook/5.0/Population/PopulationMarkerStyle"]
Date: 2025-03-22
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Population Marker Styling</h1>
</div>

The data markers in population plots can be extensively styled.

[![](/cookbook/5.0/images/PopulationMarkerStyle.png?250322130304)](/cookbook/5.0/images/PopulationMarkerStyle.png?250322130304)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Population.cs" imageUrl="/cookbook/5.0/images/PopulationMarkerStyle.png?250322130304" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 5; i++)
{
    double[] values = Generate.RandomNormal(10, mean: 3 + i);
    var pop = myPlot.Add.Population(values, x: i);

    pop.Marker.LineWidth = 2;
    pop.Marker.Color = Colors.Black.WithAlpha(.5);
    pop.Marker.Shape = MarkerShape.OpenTriangleUp;
}

// refine appearance of the plot
myPlot.Axes.Margins(bottom: 0);
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Population'>Population Plot</a> category</div>


