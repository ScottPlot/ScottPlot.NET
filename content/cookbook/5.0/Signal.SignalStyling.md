---
Title: Signal Plot Styling - ScottPlot 5.0 Cookbook
Description: Signal plots can be styled in a variety of ways.
URL: /cookbook/5.0/Signal/SignalStyling/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Signal Plot", "Signal Plot Styling"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Signal", "/cookbook/5.0/Signal/SignalStyling"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Signal Plot Styling</h1>
</div>

Signal plots can be styled in a variety of ways.

[![](/cookbook/5.0/images/SignalStyling.png?241101192719)](/cookbook/5.0/images/SignalStyling.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin());
sig1.Color = Colors.Magenta;
sig1.LineWidth = 10;
sig1.LegendText = "Sine";

var sig2 = myPlot.Add.Signal(Generate.Cos());
sig2.Color = Colors.Green;
sig2.LineWidth = 5;
sig2.LegendText = "Cosine";

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Signal'>Signal Plot</a> category</div>


