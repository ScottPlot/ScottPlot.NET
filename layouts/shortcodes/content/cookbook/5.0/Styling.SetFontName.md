---
Title: Set Font by Name - ScottPlot 5.0 Cookbook
Description: Set font by its name to apply it to common plot components.
URL: /cookbook/5.0/Styling/SetFontName/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Set Font by Name"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/SetFontName"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Set Font by Name</h1>
</div>

Set font by its name to apply it to common plot components.

[![](/cookbook/5.0/images/SetFontName.png?250822231048)](/cookbook/5.0/images/SetFontName.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5.0/images/SetFontName.png?250822231048" >}}ScottPlot.Plot myPlot = new();

myPlot.Font.Set("Comic Sans MS");
myPlot.Title("Hello, World");
var sig = myPlot.Add.Signal(Generate.Sin(51, mult: 1e6));
sig.LegendText = "Hello, Custom Font";

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Styling'>Styling Plots</a> category</div>


