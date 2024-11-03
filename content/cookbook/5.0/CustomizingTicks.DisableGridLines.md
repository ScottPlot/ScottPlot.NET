---
Title: Disable Grid Lines - ScottPlot 5.0 Cookbook
Description: Users can disable grid lines for specific axes.
URL: /cookbook/5.0/CustomizingTicks/DisableGridLines/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "Disable Grid Lines"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/DisableGridLines"]
Date: 2024-11-03
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Disable Grid Lines</h1>
</div>

Users can disable grid lines for specific axes.

[![](/cookbook/5.0/images/DisableGridLines.png?241103171511)](/cookbook/5.0/images/DisableGridLines.png?241103171511)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/TickRecipes.cs" imageUrl="/cookbook/5.0/images/DisableGridLines.png?241103171511" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Grid.XAxisStyle.IsVisible = true;
myPlot.Grid.YAxisStyle.IsVisible = false;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/CustomizingTicks'>Customizing Ticks</a> category</div>


