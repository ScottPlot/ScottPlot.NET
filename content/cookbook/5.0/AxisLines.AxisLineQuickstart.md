---
Title: Axis Lines - ScottPlot 5.0 Cookbook
Description: Axis lines are vertical or horizontal lines that span an entire axis.
URL: /cookbook/5.0/AxisLines/AxisLineQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis Lines", "Axis Lines"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisLines", "/cookbook/5.0/AxisLines/AxisLineQuickstart"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/AxisLines/AxisLineQuickstart'>Axis Lines</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/AxisLines/AxisLineQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/AxisLines">Category: Axis Lines</a>
</div>

Axis lines are vertical or horizontal lines that span an entire axis.

[![](/cookbook/5.0/images/AxisLineQuickstart.png?241029205813)](/cookbook/5.0/images/AxisLineQuickstart.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Add.VerticalLine(24);
myPlot.Add.HorizontalLine(0.73);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


