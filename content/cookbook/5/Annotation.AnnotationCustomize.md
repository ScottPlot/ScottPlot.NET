---
Title: Annotation Customization - ScottPlot 5 Cookbook
Description: Annotations can be extensively customized.
URL: /cookbook/5/Annotation/AnnotationCustomize/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Annotation", "Annotation Customization"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Annotation", "/cookbook/5/Annotation/AnnotationCustomize"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Annotation Customization</h1>
</div>

Annotations can be extensively customized.

[![](/cookbook/5/images/AnnotationCustomize.png?251011113742)](/cookbook/5/images/AnnotationCustomize.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Annotation.cs" imageUrl="/cookbook/5/images/AnnotationCustomize.png?251011113742" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

var anno = myPlot.Add.Annotation("Customized\nAnnotation");
anno.LabelFontSize = 32;
anno.LabelFontName = Fonts.Serif;
anno.LabelBackgroundColor = Colors.RebeccaPurple.WithAlpha(.3);
anno.LabelFontColor = Colors.RebeccaPurple;
anno.LabelBorderColor = Colors.Green;
anno.LabelBorderWidth = 3;
anno.LabelShadowColor = Colors.Transparent;
anno.OffsetY = 40;
anno.OffsetX = 20;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Annotation'>Annotation</a> category</div>


