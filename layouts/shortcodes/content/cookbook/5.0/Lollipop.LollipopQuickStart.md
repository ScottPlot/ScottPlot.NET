---
Title: Lollipop Plot Quickstart - ScottPlot 5.0 Cookbook
Description: Lollipop plots can be created from a sequence of values
URL: /cookbook/5.0/Lollipop/LollipopQuickStart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Lollipop Plot", "Lollipop Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Lollipop", "/cookbook/5.0/Lollipop/LollipopQuickStart"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Lollipop Plot Quickstart</h1>
</div>

Lollipop plots can be created from a sequence of values

[![](/cookbook/5.0/images/LollipopQuickStart.png?250822231048)](/cookbook/5.0/images/LollipopQuickStart.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Lollipop.cs" imageUrl="/cookbook/5.0/images/LollipopQuickStart.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] values = Generate.Sin(25);
myPlot.Add.Lollipop(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Lollipop'>Lollipop Plot</a> category</div>


