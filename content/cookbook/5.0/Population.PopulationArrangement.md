---
Title: Population Arrangement - ScottPlot 5.0 Cookbook
Description: The user may customize where data is drawn relative to the bar or box. Centering everything can be used to achieve an effect where data points are drawn over the bar or box.
URL: /cookbook/5.0/Population/PopulationArrangement/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Population Plot", "Population Arrangement"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Population", "/cookbook/5.0/Population/PopulationArrangement"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Population/PopulationArrangement'>Population Arrangement</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Population/PopulationArrangement">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Population">Category: Population Plot</a>
</div>

The user may customize where data is drawn relative to the bar or box. Centering everything can be used to achieve an effect where data points are drawn over the bar or box.

[![](/cookbook/5.0/images/PopulationArrangement.png?241029205813)](/cookbook/5.0/images/PopulationArrangement.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i < 5; i++)
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

<hr class='my-5 invisible'>


