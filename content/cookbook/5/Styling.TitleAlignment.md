---
Title: Title Alignment - ScottPlot 5 Cookbook
Description: The title is centered over the data area by default, but a flag allows users to center it relative to the figure instead
URL: /cookbook/5/Styling/TitleAlignment/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Styling Plots", "Title Alignment"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Styling", "/cookbook/5/Styling/TitleAlignment"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Title Alignment</h1>
</div>

The title is centered over the data area by default, but a flag allows users to center it relative to the figure instead

[![](/cookbook/5/images/TitleAlignment.png?251011113742)](/cookbook/5/images/TitleAlignment.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5/images/TitleAlignment.png?251011113742" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51, mult: 1e9));
myPlot.Title("This title is centered in the figure");
myPlot.Axes.Title.FullFigureCenter = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Styling'>Styling Plots</a> category</div>


