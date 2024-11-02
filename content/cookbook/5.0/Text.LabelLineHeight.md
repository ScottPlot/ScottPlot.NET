---
Title: Line Height - ScottPlot 5.0 Cookbook
Description: Multiline labels have a default line height estimated from the typeface and font size, however line height may be manually defined by the user.
URL: /cookbook/5.0/Text/LabelLineHeight/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Text", "Line Height"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Text", "/cookbook/5.0/Text/LabelLineHeight"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Line Height</h1>
</div>

Multiline labels have a default line height estimated from the typeface and font size, however line height may be manually defined by the user.

[![](/cookbook/5.0/images/LabelLineHeight.png?241102170938)](/cookbook/5.0/images/LabelLineHeight.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Text.cs" imageUrl="/cookbook/5.0/images/LabelLineHeight.png?241102170938" >}}ScottPlot.Plot myPlot = new();

var label1 = myPlot.Add.Text($"line\nheight", 0, 0);
label1.LabelLineSpacing = 0;
label1.LabelFontColor = Colors.Red;
label1.LabelBorderColor = Colors.Black;

var label2 = myPlot.Add.Text($"can\nbe", 1, 0);
label2.LabelLineSpacing = 10;
label2.LabelFontColor = Colors.Orange;
label2.LabelBorderColor = Colors.Black;

var label3 = myPlot.Add.Text($"automatic\nor", 2, 0);
label3.LabelLineSpacing = null;
label3.LabelFontColor = Colors.Green;
label3.LabelBorderColor = Colors.Black;

var label4 = myPlot.Add.Text($"set\nmanually", 3, 0);
label4.LabelLineSpacing = 15;
label4.LabelFontColor = Colors.Blue;
label4.LabelBorderColor = Colors.Black;

myPlot.HideGrid();
myPlot.Axes.SetLimitsX(-.5, 4);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Text'>Text</a> category</div>


