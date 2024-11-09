---
Title: Annotation Customization - ScottPlot 5.0 Cookbook
Description: Annotations can be extensively customized.
URL: /cookbook/5.0/Annotation/AnnotationCustomize/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Annotation", "Annotation Customization"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Annotation", "/cookbook/5.0/Annotation/AnnotationCustomize"]
Date: 2024-11-09
Version: ScottPlot 5.0.44
Version: ScottPlot 5.0.44
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Annotation Customization</h1>
</div>

Annotations can be extensively customized.

[![](/cookbook/5.0/images/AnnotationCustomize.png?241109132219)](/cookbook/5.0/images/AnnotationCustomize.png?241109132219)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Annotation.cs" imageUrl="/cookbook/5.0/images/AnnotationCustomize.png?241109132219" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Annotation'>Annotation</a> category</div>


