---
Title: Lollipop Plot Quickstart - ScottPlot 5.0 Cookbook
Description: Lollipop plots can be created from a sequence of values
URL: /cookbook/5.0/Lollipop/LollipopQuickStart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Lollipop Plot", "Lollipop Plot Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Lollipop", "/cookbook/5.0/Lollipop/LollipopQuickStart"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Lollipop/LollipopQuickStart'>Lollipop Plot Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Lollipop/LollipopQuickStart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Lollipop">Category: Lollipop Plot</a>
</div>

Lollipop plots can be created from a sequence of values

[![](/cookbook/5.0/images/LollipopQuickStart.png?241031194635)](/cookbook/5.0/images/LollipopQuickStart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] values = Generate.Sin(25);
myPlot.Add.Lollipop(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


