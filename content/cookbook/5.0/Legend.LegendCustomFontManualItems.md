---
Title: Manual Legend Items Custom Font - ScottPlot 5.0 Cookbook
Description: Use custom fonts from TTF files in the legend (manual legend items).
URL: /cookbook/5.0/Legend/LegendCustomFontManualItems/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Legends", "Manual Legend Items Custom Font"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend", "/cookbook/5.0/Legend/LegendCustomFontManualItems"]
Date: 2024-11-17
Version: ScottPlot 5.0.46
Version: ScottPlot 5.0.46
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Manual Legend Items Custom Font</h1>
</div>

Use custom fonts from TTF files in the legend (manual legend items).

[![](/cookbook/5.0/images/LegendCustomFontManualItems.png?241117162641)](/cookbook/5.0/images/LegendCustomFontManualItems.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5.0/images/LegendCustomFontManualItems.png?241117162641" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Legend'>Legends</a> category</div>


