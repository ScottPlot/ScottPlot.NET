---
Title: Text Quickstart - ScottPlot 5.0 Cookbook
Description: Text can be placed anywhere in coordinate space.
URL: /cookbook/5.0/Text/TextQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Text", "Text Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Text", "/cookbook/5.0/Text/TextQuickstart"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Text Quickstart</h1>
</div>

Text can be placed anywhere in coordinate space.

[![](/cookbook/5.0/images/TextQuickstart.png?250822231048)](/cookbook/5.0/images/TextQuickstart.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Text.cs" imageUrl="/cookbook/5.0/images/TextQuickstart.png?250822231048" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());
myPlot.Add.Text("Hello, World", 25, 0.5);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Text'>Text</a> category</div>


