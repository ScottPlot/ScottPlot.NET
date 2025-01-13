---
Title: Population Arrangement - ScottPlot 5.0 Cookbook
Description: The user may customize where data is drawn relative to the bar or box. Centering everything can be used to achieve an effect where data points are drawn over the bar or box.
URL: /cookbook/5.0/Population/PopulationArrangement/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Population Plot", "Population Arrangement"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Population", "/cookbook/5.0/Population/PopulationArrangement"]
Date: 2025-01-13
Version: ScottPlot 5.0.53
Version: ScottPlot 5.0.53
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Population Arrangement</h1>
</div>

The user may customize where data is drawn relative to the bar or box. Centering everything can be used to achieve an effect where data points are drawn over the bar or box.

[![](/cookbook/5.0/images/PopulationArrangement.png?250112204022)](/cookbook/5.0/images/PopulationArrangement.png?250112204022)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Population.cs" imageUrl="/cookbook/5.0/images/PopulationArrangement.png?250112204022" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 5; i++)
{
    double[] values = Generate.RandomNormal(10, mean: 3 + i);
    var pop = myPlot.Add.Population(values, x: i);

    pop.MarkerAlignment = HorizontalAlignment.Center;
    pop.BarAlignment = HorizontalAlignment.Center;
    pop.Marker.Shape = MarkerShape.OpenDiamond;
    pop.Marker.Color = Colors.Black.WithAlpha(.5);
    pop.Bar.FillColor = Colors.Gray;
    pop.Bar.LineWidth = 2;
    pop.Width = 0.5;
}

// refine appearance of the plot
myPlot.Axes.Margins(bottom: 0);
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Population'>Population Plot</a> category</div>


