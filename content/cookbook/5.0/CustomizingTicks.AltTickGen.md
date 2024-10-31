---
Title: Custom Tick Generators - ScottPlot 5.0 Cookbook
Description: Tick generators determine where ticks are to be placed and also contain logic for generating tick labels from tick positions. Alternative tick generators can be created and assigned to axes. Some common tick generators are provided with ScottPlot, and users also have the option create their own.
URL: /cookbook/5.0/CustomizingTicks/AltTickGen/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Customizing Ticks", "Custom Tick Generators"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/CustomizingTicks", "/cookbook/5.0/CustomizingTicks/AltTickGen"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/CustomizingTicks/AltTickGen'>Custom Tick Generators</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/CustomizingTicks/AltTickGen">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/CustomizingTicks">Category: Customizing Ticks</a>
</div>

Tick generators determine where ticks are to be placed and also contain logic for generating tick labels from tick positions. Alternative tick generators can be created and assigned to axes. Some common tick generators are provided with ScottPlot, and users also have the option create their own.

[![](/cookbook/5.0/images/AltTickGen.png?241031194635)](/cookbook/5.0/images/AltTickGen.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

myPlot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericFixedInterval(11);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


