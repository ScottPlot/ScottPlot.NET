---
Title: Radar Series Customization - ScottPlot 5.0 Cookbook
Description: Radar plots have a collection of RadarSeries objects which each describe a set of values and the styling information used to display it as a shape on the radar plot. Users may change properties of radar series objects to achieve a high level of customization over each shape.
URL: /cookbook/5.0/Radar/RadarSeriesCustomization/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Radar Plot", "Radar Series Customization"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Radar", "/cookbook/5.0/Radar/RadarSeriesCustomization"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Radar Series Customization</h1>
</div>

Radar plots have a collection of RadarSeries objects which each describe a set of values and the styling information used to display it as a shape on the radar plot. Users may change properties of radar series objects to achieve a high level of customization over each shape.

[![](/cookbook/5.0/images/RadarSeriesCustomization.png?241101192719)](/cookbook/5.0/images/RadarSeriesCustomization.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

var radar = myPlot.Add.Radar(values);

radar.Series[0].FillColor = Colors.Transparent;
radar.Series[0].LineColor = Colors.Blue;
radar.Series[0].LineWidth = 3;
radar.Series[0].LinePattern = LinePattern.DenselyDashed;

radar.Series[1].FillColor = Colors.Green.WithAlpha(.2);
radar.Series[1].LineColor = Colors.Green;
radar.Series[1].LineWidth = 2;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Radar'>Radar Plot</a> category</div>


