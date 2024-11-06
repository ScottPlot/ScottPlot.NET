---
Title: Fixed Rectangle - ScottPlot 5.0 Cookbook
Description: The plot can be arranged so the data is drawn inside a fixed rectangle defined in pixel units
URL: /cookbook/5.0/Layout/FixedRectangle/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Layout", "Fixed Rectangle"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Layout", "/cookbook/5.0/Layout/FixedRectangle"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Fixed Rectangle</h1>
</div>

The plot can be arranged so the data is drawn inside a fixed rectangle defined in pixel units

[![](/cookbook/5.0/images/FixedRectangle.png?241105214550)](/cookbook/5.0/images/FixedRectangle.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/LayoutRecipes.cs" imageUrl="/cookbook/5.0/images/FixedRectangle.png?241105214550" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Layout'>Layout</a> category</div>


