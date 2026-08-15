---
Title: Automatic Font Detection - ScottPlot 5 Cookbook
Description: The Plot's Style class contains a method which automatically sets the fonts of common plot objects to the font most likely able to display the characters they contain.
URL: /cookbook/5/Internationalization/AutomaticFontDetection/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Internationalization", "Automatic Font Detection"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Internationalization", "/cookbook/5/Internationalization/AutomaticFontDetection"]
Date: 2026-08-15
Version: ScottPlot 5.1.60
Version: ScottPlot 5.1.60
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Automatic Font Detection</h1>
</div>

The Plot's Style class contains a method which automatically sets the fonts of common plot objects to the font most likely able to display the characters they contain.

[![](/cookbook/5/images/AutomaticFontDetection.png?260815173246)](/cookbook/5/images/AutomaticFontDetection.png?260815173246)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Internationalization.cs" imageUrl="/cookbook/5/images/AutomaticFontDetection.png?260815173246" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Internationalization'>Internationalization</a> category</div>


