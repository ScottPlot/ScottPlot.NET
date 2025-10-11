---
Title: Interactive Spans - ScottPlot 5 Cookbook
Description: Interactive vertical and horizontal spans let the user select ranges along the vertical and horizontal axes, respectively.
URL: /cookbook/5/InteractivePlottables/InteractiveSpans/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Interactive", "Interactive Spans"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/InteractivePlottables", "/cookbook/5/InteractivePlottables/InteractiveSpans"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Interactive Spans</h1>
</div>

Interactive vertical and horizontal spans let the user select ranges along the vertical and horizontal axes, respectively.

[![](/cookbook/5/images/InteractiveSpans.png?251011113742)](/cookbook/5/images/InteractiveSpans.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/InteractivePlottables.cs" imageUrl="/cookbook/5/images/InteractiveSpans.png?251011113742" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.InteractiveVerticalSpan(3, 5);
myPlot.Add.InteractiveHorizontalSpan(3, 5);
myPlot.Axes.SetLimits(0, 10, 0, 10);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/InteractivePlottables'>Interactive</a> category</div>


