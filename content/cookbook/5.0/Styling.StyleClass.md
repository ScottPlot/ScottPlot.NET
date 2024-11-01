---
Title: Style Helper Functions - ScottPlot 5.0 Cookbook
Description: Plots contain many objects which can be customized individually by assigning to their public properties, but helper methods exist in the Plot's Style object that make it easier to customize many items at once using a simpler API.
URL: /cookbook/5.0/Styling/StyleClass/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Style Helper Functions"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/StyleClass"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Style Helper Functions</h1>
</div>

Plots contain many objects which can be customized individually by assigning to their public properties, but helper methods exist in the Plot's Style object that make it easier to customize many items at once using a simpler API.

[![](/cookbook/5.0/images/StyleClass.png?241101192719)](/cookbook/5.0/images/StyleClass.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

// visible items have public properties that can be customized
myPlot.Axes.Bottom.Label.Text = "Horizontal Axis";
myPlot.Axes.Left.Label.Text = "Vertical Axis";
myPlot.Axes.Title.Label.Text = "Plot Title";

// some items must be styled directly
myPlot.Grid.MajorLineColor = Color.FromHex("#0e3d54");
myPlot.FigureBackground.Color = Color.FromHex("#07263b");
myPlot.DataBackground.Color = Color.FromHex("#0b3049");

// the Style object contains helper methods to style many items at once
myPlot.Axes.Color(Color.FromHex("#a0acb5"));

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Styling'>Styling Plots</a> category</div>


