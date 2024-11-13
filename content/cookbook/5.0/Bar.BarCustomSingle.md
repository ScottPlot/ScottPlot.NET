---
Title: Customized Bar Plot - ScottPlot 5.0 Cookbook
Description: Ultimate control of bar plot styling and positioning may be achieved by creating each bar individually, styling it as desired, and setting its exact size and location. This level of customization may be used to create extremely advanced stacked or grouped bar plots.
URL: /cookbook/5.0/Bar/BarCustomSingle/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bar Plot", "Customized Bar Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bar", "/cookbook/5.0/Bar/BarCustomSingle"]
Date: 2024-11-13
Version: ScottPlot 5.0.45
Version: ScottPlot 5.0.45
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Customized Bar Plot</h1>
</div>

Ultimate control of bar plot styling and positioning may be achieved by creating each bar individually, styling it as desired, and setting its exact size and location. This level of customization may be used to create extremely advanced stacked or grouped bar plots.

[![](/cookbook/5.0/images/BarCustomSingle.png?241112193154)](/cookbook/5.0/images/BarCustomSingle.png?241112193154)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Bar.cs" imageUrl="/cookbook/5.0/images/BarCustomSingle.png?241112193154" >}}ScottPlot.Plot myPlot = new();

ScottPlot.Bar bar1 = new()
{
    Position = 2,
    Value = 5,
};

myPlot.Add.Bar(bar1);

ScottPlot.Bar bar2 = new()
{
    Position = 5,
    Value = 7,
    ValueBase = 2,
    Error = 1,
    FillColor = Colors.Magenta,
    LineWidth = 3,
    LineColor = Colors.Navy,
    FillHatch = new ScottPlot.Hatches.Striped(),
    FillHatchColor = Colors.Magenta.Lighten(.2),
};

myPlot.Add.Bar(bar2);

myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Bar'>Bar Plot</a> category</div>


