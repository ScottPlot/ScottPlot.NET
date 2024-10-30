---
Title: Fixed Rectangle - ScottPlot 5.0 Cookbook
Description: The plot can be arranged so the data is drawn inside a fixed rectangle defined in pixel units
URL: /cookbook/5.0/Layout/FixedRectangle/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Layout", "Fixed Rectangle"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Layout", "/cookbook/5.0/Layout/FixedRectangle"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Layout/FixedRectangle'>Fixed Rectangle</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Layout/FixedRectangle">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Layout">Category: Layout</a>
</div>

The plot can be arranged so the data is drawn inside a fixed rectangle defined in pixel units

[![](/cookbook/5.0/images/FixedRectangle.png?241029205813)](/cookbook/5.0/images/FixedRectangle.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// add sample data to the plot
myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

// set the data area to render inside a fixed rectangle
PixelSize size = new(300, 200);
Pixel offset = new(50, 50);
PixelRect rect = new(size, offset);
myPlot.Layout.Fixed(rect);

// darken the figure background so we can observe its dimensions
myPlot.FigureBackground.Color = Colors.LightBlue;
myPlot.DataBackground.Color = Colors.White;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


