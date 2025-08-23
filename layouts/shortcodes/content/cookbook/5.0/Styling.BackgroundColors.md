---
Title: Background Colors - ScottPlot 5.0 Cookbook
Description: Background color for the entire figure or just the data area may be individually controlled. When using dark figure backgrounds it may be necessary to configure axes to use light colors
URL: /cookbook/5.0/Styling/BackgroundColors/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Background Colors"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/BackgroundColors"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Background Colors</h1>
</div>

Background color for the entire figure or just the data area may be individually controlled. When using dark figure backgrounds it may be necessary to configure axes to use light colors

[![](/cookbook/5.0/images/BackgroundColors.png?250822231048)](/cookbook/5.0/images/BackgroundColors.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5.0/images/BackgroundColors.png?250822231048" >}}ScottPlot.Plot myPlot = new();

// setup a plot with sample data
myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));
myPlot.XLabel("Horizontal Axis");
myPlot.YLabel("Vertical Axis");

// some items must be styled directly
myPlot.FigureBackground.Color = Colors.Navy;
myPlot.DataBackground.Color = Colors.Navy.Darken(0.1);
myPlot.Grid.MajorLineColor = Colors.Navy.Lighten(0.1);

// some items have helper methods to configure multiple properties at once
myPlot.Axes.Color(Colors.Navy.Lighten(0.8));

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Styling'>Styling Plots</a> category</div>


