---
Title: Crosshair Customization - ScottPlot 5 Cookbook
Description: Crosshairs can be extensively customized.
URL: /cookbook/5/Crosshair/CrosshairCustomization/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Crosshair", "Crosshair Customization"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Crosshair", "/cookbook/5/Crosshair/CrosshairCustomization"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Crosshair Customization</h1>
</div>

Crosshairs can be extensively customized.

[![](/cookbook/5/images/CrosshairCustomization.png?251011113742)](/cookbook/5/images/CrosshairCustomization.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Crosshair.cs" imageUrl="/cookbook/5/images/CrosshairCustomization.png?251011113742" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

var cross = myPlot.Add.Crosshair(13, .25);

// properties set style for both lines
cross.LineWidth = 2;
cross.LineColor = Colors.Magenta;

// each line's styles can be individually accessed as well
cross.HorizontalLine.LinePattern = LinePattern.Dotted;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Crosshair'>Crosshair</a> category</div>


