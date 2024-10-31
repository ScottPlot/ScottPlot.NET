---
Title: Legend Wrapping - ScottPlot 5.0 Cookbook
Description: Legend items may wrap to improve display for a large number of items
URL: /cookbook/5.0/Legend/LegendWrapping/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Legends", "Legend Wrapping"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend", "/cookbook/5.0/Legend/LegendWrapping"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Legend/LegendWrapping'>Legend Wrapping</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Legend/LegendWrapping">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Legend">Category: Legends</a>
</div>

Legend items may wrap to improve display for a large number of items

[![](/cookbook/5.0/images/LegendWrapping.png?241031194635)](/cookbook/5.0/images/LegendWrapping.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

for (int i = 1; i <= 10; i++)
{
    double[] data = Generate.Sin(51, phase: .02 * i);
    var sig = myPlot.Add.Signal(data);
    sig.LegendText = $"#{i}";
}

myPlot.Legend.IsVisible = true;
myPlot.Legend.Orientation = Orientation.Horizontal;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


