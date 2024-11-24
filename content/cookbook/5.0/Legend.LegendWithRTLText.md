---
Title: Right To Left (RTL) text support - ScottPlot 5.0 Cookbook
Description: Enabling Right To Left (RTL) support correctly renders text in RTL languages.
URL: /cookbook/5.0/Legend/LegendWithRTLText/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Legends", "Right To Left (RTL) text support"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend", "/cookbook/5.0/Legend/LegendWithRTLText"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Right To Left (RTL) text support</h1>
</div>

Enabling Right To Left (RTL) support correctly renders text in RTL languages.

[![](/cookbook/5.0/images/LegendWithRTLText.png?241124170640)](/cookbook/5.0/images/LegendWithRTLText.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5.0/images/LegendWithRTLText.png?241124170640" >}}ScottPlot.Plot myPlot = new();

LabelStyle.RTLSupport = true; // enable right-to-left text support

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.LegendText = "אמת"; // example right-to-left text

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.LegendText = "English"; // example left-to-right text

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Legend'>Legends</a> category</div>


