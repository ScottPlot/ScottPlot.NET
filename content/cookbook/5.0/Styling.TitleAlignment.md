---
Title: Title Alignment - ScottPlot 5.0 Cookbook
Description: The title is centered over the data area by default, but a flag allows users to center it relative to the figure instead
URL: /cookbook/5.0/Styling/TitleAlignment/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Title Alignment"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/TitleAlignment"]
Date: 2025-01-05
Version: ScottPlot 5.0.48
Version: ScottPlot 5.0.48
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Title Alignment</h1>
</div>

The title is centered over the data area by default, but a flag allows users to center it relative to the figure instead

[![](/cookbook/5.0/images/TitleAlignment.png?250105183901)](/cookbook/5.0/images/TitleAlignment.png?250105183901)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5.0/images/TitleAlignment.png?250105183901" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51, mult: 1e9));
myPlot.Title("This title is centered in the figure");
myPlot.Axes.Title.FullFigureCenter = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Styling'>Styling Plots</a> category</div>


