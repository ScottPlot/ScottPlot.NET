---
Title: Text Formatting - ScottPlot 5 Cookbook
Description: Text formatting can be extensively customized.
URL: /cookbook/5/Text/Formatting/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Text", "Text Formatting"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Text", "/cookbook/5/Text/Formatting"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Text Formatting</h1>
</div>

Text formatting can be extensively customized.

[![](/cookbook/5/images/Formatting.png?251011113742)](/cookbook/5/images/Formatting.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Text.cs" imageUrl="/cookbook/5/images/Formatting.png?251011113742" >}}ScottPlot.Plot myPlot = new();

var text = myPlot.Add.Text("Hello, World", 42, 69);
text.LabelFontSize = 26;
text.LabelBold = true;
text.LabelRotation = -45;
text.LabelFontColor = Colors.Yellow;
text.LabelBackgroundColor = Colors.Navy.WithAlpha(.5);
text.LabelBorderColor = Colors.Magenta;
text.LabelBorderWidth = 3;
text.LabelPadding = 10;
text.LabelAlignment = Alignment.MiddleCenter;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Text'>Text</a> category</div>


