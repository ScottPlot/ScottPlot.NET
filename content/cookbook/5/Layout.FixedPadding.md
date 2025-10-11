---
Title: Fixed Padding - ScottPlot 5 Cookbook
Description: The plot can be arranged to achieve a fixed amount of padding on each side of the data area
URL: /cookbook/5/Layout/FixedPadding/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Layout", "Fixed Padding"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Layout", "/cookbook/5/Layout/FixedPadding"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Fixed Padding</h1>
</div>

The plot can be arranged to achieve a fixed amount of padding on each side of the data area

[![](/cookbook/5/images/FixedPadding.png?251011113742)](/cookbook/5/images/FixedPadding.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/LayoutRecipes.cs" imageUrl="/cookbook/5/images/FixedPadding.png?251011113742" >}}ScottPlot.Plot myPlot = new();

// add sample data to the plot
myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

// use a fixed amount of of pixel padding on each side
PixelPadding padding = new(100, 50, 100, 50);
myPlot.Layout.Fixed(padding);

// darken the figure background so we can observe its dimensions
myPlot.FigureBackground.Color = Colors.LightBlue;
myPlot.DataBackground.Color = Colors.White;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Layout'>Layout</a> category</div>


