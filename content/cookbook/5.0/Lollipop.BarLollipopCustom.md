---
Title: Lollipop Plot Customizations - ScottPlot 5.0 Cookbook
Description: The stem line and head marker can be extensively customized.
URL: /cookbook/5.0/Lollipop/BarLollipopCustom/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Lollipop Plot", "Lollipop Plot Customizations"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Lollipop", "/cookbook/5.0/Lollipop/BarLollipopCustom"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Lollipop/BarLollipopCustom'>Lollipop Plot Customizations</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Lollipop/BarLollipopCustom">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Lollipop">Category: Lollipop Plot</a>
</div>

The stem line and head marker can be extensively customized.

[![](/cookbook/5.0/images/BarLollipopCustom.png?241029205813)](/cookbook/5.0/images/BarLollipopCustom.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[] values = Generate.Sin(21);
var lollipop = myPlot.Add.Lollipop(values);

lollipop.MarkerColor = Colors.Red;
lollipop.MarkerSize = 15;
lollipop.MarkerShape = MarkerShape.FilledDiamond;

lollipop.LineColor = Colors.Green;
lollipop.LineWidth = 3;
lollipop.LinePattern = LinePattern.Dotted;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


