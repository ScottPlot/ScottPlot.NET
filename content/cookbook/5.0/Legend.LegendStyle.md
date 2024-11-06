---
Title: Legend Customization - ScottPlot 5.0 Cookbook
Description: Access the Legend object directly for advanced customization options.
URL: /cookbook/5.0/Legend/LegendStyle/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Legends", "Legend Customization"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend", "/cookbook/5.0/Legend/LegendStyle"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Legend Customization</h1>
</div>

Access the Legend object directly for advanced customization options.

[![](/cookbook/5.0/images/LegendStyle.png?241105214550)](/cookbook/5.0/images/LegendStyle.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5.0/images/LegendStyle.png?241105214550" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Legend'>Legends</a> category</div>


