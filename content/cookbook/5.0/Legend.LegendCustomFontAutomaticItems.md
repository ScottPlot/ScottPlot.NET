---
Title: Automatic Legend Items Custom Font - ScottPlot 5.0 Cookbook
Description: Use custom fonts from TTF files in the legend.
URL: /cookbook/5.0/Legend/LegendCustomFontAutomaticItems/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Legends", "Automatic Legend Items Custom Font"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend", "/cookbook/5.0/Legend/LegendCustomFontAutomaticItems"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Legend/LegendCustomFontAutomaticItems'>Automatic Legend Items Custom Font</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Legend/LegendCustomFontAutomaticItems">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Legend">Category: Legends</a>
</div>

Use custom fonts from TTF files in the legend.

[![](/cookbook/5.0/images/LegendCustomFontAutomaticItems.png?241029205813)](/cookbook/5.0/images/LegendCustomFontAutomaticItems.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


