---
Title: Disable Grid Lines - ScottPlot 5.0 Cookbook
Description: Users can disable grid lines for specific axes.
URL: /cookbook/5.0/CustomizingTicks/DisableGridLines/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "Disable Grid Lines"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/DisableGridLines"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/CustomizingTicks/DisableGridLines'>Disable Grid Lines</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/CustomizingTicks/DisableGridLines">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/CustomizingTicks">Category: Customizing Ticks</a>
</div>

Users can disable grid lines for specific axes.

[![](/cookbook/5.0/images/DisableGridLines.png?241031194635)](/cookbook/5.0/images/DisableGridLines.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Grid.XAxisStyle.IsVisible = true;
myPlot.Grid.YAxisStyle.IsVisible = false;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


