---
Title: Crosshair Customization - ScottPlot 5.0 Cookbook
Description: Crosshairs can be extensively customized.
URL: /cookbook/5.0/Crosshair/CrosshairCustomization/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Crosshair", "Crosshair Customization"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Crosshair", "/cookbook/5.0/Crosshair/CrosshairCustomization"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Crosshair/CrosshairCustomization'>Crosshair Customization</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Crosshair/CrosshairCustomization">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Crosshair">Category: Crosshair</a>
</div>

Crosshairs can be extensively customized.

[![](/cookbook/5.0/images/CrosshairCustomization.png?241031194635)](/cookbook/5.0/images/CrosshairCustomization.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


