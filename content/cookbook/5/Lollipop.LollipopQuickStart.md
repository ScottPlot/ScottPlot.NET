---
Title: Lollipop Plot Quickstart - ScottPlot 5 Cookbook
Description: Lollipop plots can be created from a sequence of values
URL: /cookbook/5/Lollipop/LollipopQuickStart/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Lollipop Plot", "Lollipop Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Lollipop", "/cookbook/5/Lollipop/LollipopQuickStart"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Lollipop Plot Quickstart</h1>
</div>

Lollipop plots can be created from a sequence of values

[![](/cookbook/5/images/LollipopQuickStart.png?251011113742)](/cookbook/5/images/LollipopQuickStart.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Lollipop.cs" imageUrl="/cookbook/5/images/LollipopQuickStart.png?251011113742" >}}ScottPlot.Plot myPlot = new();

double[] values = Generate.Sin(25);
myPlot.Add.Lollipop(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Lollipop'>Lollipop Plot</a> category</div>


