---
Title: Automatic Font Detection - ScottPlot 5.0 Cookbook
Description: The Plot's Style class contains a method which automatically sets the fonts of common plot objects to the font most likely able to display the characters they contain.
URL: /cookbook/5.0/Internationalization/AutomaticFontDetection/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Internationalization", "Automatic Font Detection"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Internationalization", "/cookbook/5.0/Internationalization/AutomaticFontDetection"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Internationalization/AutomaticFontDetection'>Automatic Font Detection</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Internationalization/AutomaticFontDetection">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Internationalization">Category: Internationalization</a>
</div>

The Plot's Style class contains a method which automatically sets the fonts of common plot objects to the font most likely able to display the characters they contain.

[![](/cookbook/5.0/images/AutomaticFontDetection.png?241031194635)](/cookbook/5.0/images/AutomaticFontDetection.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin(phase: .1));
var sig2 = myPlot.Add.Signal(Generate.Sin(phase: .2));
var sig3 = myPlot.Add.Signal(Generate.Sin(phase: .3));

sig1.LegendText = "测试"; // Chinese
sig2.LegendText = "試験"; // Japanese
sig3.LegendText = "테스트"; // Korean
myPlot.ShowLegend();

myPlot.Title("测试"); // Chinese
myPlot.YLabel("試験"); // Japanese
myPlot.XLabel("테스트"); // Korean

myPlot.Font.Automatic(); // set font for each item based on its content

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


