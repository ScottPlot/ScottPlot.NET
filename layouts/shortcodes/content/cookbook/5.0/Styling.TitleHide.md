---
Title: Hide the Title - ScottPlot 5.0 Cookbook
Description: A shortcut method exists to easily disable title visibility. This strategy can be used to un-hide the title later, preserving its original text.
URL: /cookbook/5.0/Styling/TitleHide/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Hide the Title"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/TitleHide"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Hide the Title</h1>
</div>

A shortcut method exists to easily disable title visibility. This strategy can be used to un-hide the title later, preserving its original text.

[![](/cookbook/5.0/images/TitleHide.png?250822231048)](/cookbook/5.0/images/TitleHide.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5.0/images/TitleHide.png?250822231048" >}}ScottPlot.Plot myPlot = new();

// add sample data
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

// display text in the title area
myPlot.Title("This is an example title");

// hide the title
myPlot.Title(false);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Styling'>Styling Plots</a> category</div>


