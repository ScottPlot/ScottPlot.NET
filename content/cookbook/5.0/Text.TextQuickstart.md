---
Title: Text Quickstart - ScottPlot 5.0 Cookbook
Description: Text can be placed anywhere in coordinate space.
URL: /cookbook/5.0/Text/TextQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Text", "Text Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Text", "/cookbook/5.0/Text/TextQuickstart"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Text/TextQuickstart'>Text Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Text/TextQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Text">Category: Text</a>
</div>

Text can be placed anywhere in coordinate space.

[![](/cookbook/5.0/images/TextQuickstart.png?241031194635)](/cookbook/5.0/images/TextQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());
myPlot.Add.Text("Hello, World", 25, 0.5);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


