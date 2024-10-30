---
Title: Legend Customization - ScottPlot 5.0 Cookbook
Description: Access the Legend object directly for advanced customization options.
URL: /cookbook/5.0/Legend/LegendStyle/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Legends", "Legend Customization"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend", "/cookbook/5.0/Legend/LegendStyle"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Legend/LegendStyle'>Legend Customization</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Legend/LegendStyle">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Legend">Category: Legends</a>
</div>

Access the Legend object directly for advanced customization options.

[![](/cookbook/5.0/images/LegendStyle.png?241029205813)](/cookbook/5.0/images/LegendStyle.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.LegendText = "Sin";

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.LegendText = "Cos";

myPlot.Legend.IsVisible = true;
myPlot.Legend.Alignment = Alignment.UpperCenter;

myPlot.Legend.OutlineColor = Colors.Navy;
myPlot.Legend.OutlineWidth = 5;
myPlot.Legend.BackgroundColor = Colors.LightBlue;

myPlot.Legend.ShadowColor = Colors.Blue.WithOpacity(.2);
myPlot.Legend.ShadowOffset = new(10, 10);

myPlot.Legend.FontSize = 32;
myPlot.Legend.FontName = Fonts.Serif;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


