---
Title: Bracket - ScottPlot 5 Cookbook
Description: Brackets annotate a range along a line in coordinate space
URL: /cookbook/5/Bracket/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Bracket"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Bracket"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---

<h1>Bracket</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Bracket</h1>
<a href='/cookbook/5/Bracket/BracketQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Brackets are useful for annotating linear ranges of data.

[![](/cookbook/5/images/BracketQuickstart.png?260329072039)](/cookbook/5/images/BracketQuickstart.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Bracket.cs" imageUrl="/cookbook/5/images/BracketQuickstart.png?260329072039" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Add.Bracket(0, 1, 0, 0, "Bracket A");
myPlot.Add.Bracket(25, -1, 38, -1, "Bracket B");
myPlot.Add.Bracket(20, .55, 27, -.3, "Bracket C");

myPlot.Axes.Margins(0.3, 0.4); // extra room for labels

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


