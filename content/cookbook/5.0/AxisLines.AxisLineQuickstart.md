---
Title: Axis Lines - ScottPlot 5.0 Cookbook
Description: Axis lines are vertical or horizontal lines that span an entire axis.
URL: /cookbook/5.0/AxisLines/AxisLineQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Axis Lines", "Axis Lines"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/AxisLines", "/cookbook/5.0/AxisLines/AxisLineQuickstart"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Axis Lines</h1>
</div>

Axis lines are vertical or horizontal lines that span an entire axis.

[![](/cookbook/5.0/images/AxisLineQuickstart.png?241101192719)](/cookbook/5.0/images/AxisLineQuickstart.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Add.VerticalLine(24);
myPlot.Add.HorizontalLine(0.73);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/AxisLines'>Axis Lines</a> category</div>


