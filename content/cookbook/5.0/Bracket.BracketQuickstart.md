---
Title: Bracket - ScottPlot 5.0 Cookbook
Description: Brackets are useful for annotating linear ranges of data.
URL: /cookbook/5.0/Bracket/BracketQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Bracket", "Bracket"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Bracket", "/cookbook/5.0/Bracket/BracketQuickstart"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Bracket</h1>
</div>

Brackets are useful for annotating linear ranges of data.

[![](/cookbook/5.0/images/BracketQuickstart.png?241124170640)](/cookbook/5.0/images/BracketQuickstart.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Bracket.cs" imageUrl="/cookbook/5.0/images/BracketQuickstart.png?241124170640" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Add.Bracket(0, 1, 0, 0, "Bracket A");
myPlot.Add.Bracket(25, -1, 38, -1, "Bracket B");
myPlot.Add.Bracket(20, .55, 27, -.3, "Bracket C");

myPlot.Axes.Margins(0.3, 0.4); // extra room for labels

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Bracket'>Bracket</a> category</div>


