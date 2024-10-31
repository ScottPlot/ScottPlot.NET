---
Title: Manual Legend Items Custom Font - ScottPlot 5.0 Cookbook
Description: Use custom fonts from TTF files in the legend (manual legend items).
URL: /cookbook/5.0/Legend/LegendCustomFontManualItems/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Legends", "Manual Legend Items Custom Font"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend", "/cookbook/5.0/Legend/LegendCustomFontManualItems"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Legend/LegendCustomFontManualItems'>Manual Legend Items Custom Font</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Legend/LegendCustomFontManualItems">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Legend">Category: Legends</a>
</div>

Use custom fonts from TTF files in the legend (manual legend items).

[![](/cookbook/5.0/images/LegendCustomFontManualItems.png?241031194635)](/cookbook/5.0/images/LegendCustomFontManualItems.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// Add a font file to use its typeface for fonts with a given name
Fonts.AddFontFile(
    name: "Alumni Sans",
    path: Path.Combine(Paths.FontFolder, @"AlumniSans/AlumniSans-Regular.ttf"));

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.LegendText = "Sin";

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.LegendText = "Cos";

myPlot.Legend.ManualItems.Add(new LegendItem()
{
    LabelText = "Custom",
    LabelFontName = "Alumni Sans",
    LabelFontSize = 18,
    LabelFontColor = Colors.Magenta,
    LinePattern = LinePattern.Dotted,
    LineWidth = 2,
    LineColor = Colors.Magenta,
});

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


