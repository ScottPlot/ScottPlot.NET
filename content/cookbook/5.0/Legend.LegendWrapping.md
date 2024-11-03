---
Title: Legend Wrapping - ScottPlot 5.0 Cookbook
Description: Legend items may wrap to improve display for a large number of items
URL: /cookbook/5.0/Legend/LegendWrapping/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Legends", "Legend Wrapping"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend", "/cookbook/5.0/Legend/LegendWrapping"]
Date: 2024-11-03
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Legend Wrapping</h1>
</div>

Legend items may wrap to improve display for a large number of items

[![](/cookbook/5.0/images/LegendWrapping.png?241103171511)](/cookbook/5.0/images/LegendWrapping.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5.0/images/LegendWrapping.png?241103171511" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Legend'>Legends</a> category</div>


