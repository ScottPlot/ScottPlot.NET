---
Title: Automatic Legend Items Custom Font - ScottPlot 5.0 Cookbook
Description: Use custom fonts from TTF files in the legend.
URL: /cookbook/5.0/Legend/LegendCustomFontAutomaticItems/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Legends", "Automatic Legend Items Custom Font"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend", "/cookbook/5.0/Legend/LegendCustomFontAutomaticItems"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Automatic Legend Items Custom Font</h1>
</div>

Use custom fonts from TTF files in the legend.

[![](/cookbook/5.0/images/LegendCustomFontAutomaticItems.png?250126165944)](/cookbook/5.0/images/LegendCustomFontAutomaticItems.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5.0/images/LegendCustomFontAutomaticItems.png?250126165944" >}}ScottPlot.Plot myPlot = new();

Fonts.AddFontFile("Alumni Sans", Path.Combine(GetFontsBasePath(), @"AlumniSans/AlumniSans-Regular.ttf"), bold: false, italic: false);

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.LegendText = "Sin";

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.LegendText = "Cos";

myPlot.Legend.FontName = "Alumni Sans";
myPlot.Legend.FontSize = 48;
myPlot.Legend.FontColor = Colors.Red;

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Legend'>Legends</a> category</div>


