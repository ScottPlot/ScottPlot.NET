---
Title: Text Formatting - ScottPlot 5.0 Cookbook
Description: Text formatting can be extensively customized.
URL: /cookbook/5.0/Text/Formatting/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Text", "Text Formatting"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Text", "/cookbook/5.0/Text/Formatting"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Text/Formatting'>Text Formatting</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Text/Formatting">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Text">Category: Text</a>
</div>

Text formatting can be extensively customized.

[![](/cookbook/5.0/images/Formatting.png?241029205813)](/cookbook/5.0/images/Formatting.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


