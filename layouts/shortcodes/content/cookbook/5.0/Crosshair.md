---
Title: Crosshair - ScottPlot 5.0 Cookbook
Description: A Crosshair combines a horizontal axis line and vertical axis line to mark a location in coordinate space.
URL: /cookbook/5.0/Crosshair/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Crosshair"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Crosshair"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Crosshair</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Crosshair Quickstart</h1>
<a href='/cookbook/5.0/Crosshair/CrosshairQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A Crosshair combines a horizontal axis line and vertical axis line to mark a location in coordinate space.

[![](/cookbook/5.0/images/CrosshairQuickstart.png?250822231048)](/cookbook/5.0/images/CrosshairQuickstart.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Crosshair.cs" imageUrl="/cookbook/5.0/images/CrosshairQuickstart.png?250822231048" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Add.Crosshair(13, .25);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Crosshair Customization</h1>
<a href='/cookbook/5.0/Crosshair/CrosshairCustomization' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Crosshairs can be extensively customized.

[![](/cookbook/5.0/images/CrosshairCustomization.png?250822231048)](/cookbook/5.0/images/CrosshairCustomization.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Crosshair.cs" imageUrl="/cookbook/5.0/images/CrosshairCustomization.png?250822231048" >}}ScottPlot.Plot myPlot = new();

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


