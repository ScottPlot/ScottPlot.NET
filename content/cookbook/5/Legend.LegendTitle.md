---
Title: Legend with Title - ScottPlot 5 Cookbook
Description: Place a manual legend item at the top of the list and style it as desired to achieve a title inside the legend area.
URL: /cookbook/5/Legend/LegendTitle/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Legends", "Legend with Title"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Legend", "/cookbook/5/Legend/LegendTitle"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Legend with Title</h1>
</div>

Place a manual legend item at the top of the list and style it as desired to achieve a title inside the legend area.

[![](/cookbook/5/images/LegendTitle.png?260329072039)](/cookbook/5/images/LegendTitle.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5/images/LegendTitle.png?260329072039" >}}ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.LegendText = "Sine Wave";

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.LegendText = "Cosine Wave";

var sig3 = myPlot.Add.Signal(Generate.Sin(51, 2));
sig3.LegendText = "High Frequency";

LegendItem legendTitle = new()
{
    LabelText = "Math Functions",
    LabelFontSize = 14,
    LabelFontColor = Colors.Navy,
    LabelBold = true,
    LabelOffsetX = -20, // compensate for space used to display shape
};

myPlot.Legend.ManualItems.Add(legendTitle);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Legend'>Legends</a> category</div>


