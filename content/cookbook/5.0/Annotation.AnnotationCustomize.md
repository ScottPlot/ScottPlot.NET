---
Title: Annotation Customization - ScottPlot 5.0 Cookbook
Description: Annotations can be extensively customized.
URL: /cookbook/5.0/Annotation/AnnotationCustomize/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Annotation", "Annotation Customization"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Annotation", "/cookbook/5.0/Annotation/AnnotationCustomize"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Annotation/AnnotationCustomize'>Annotation Customization</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Annotation/AnnotationCustomize">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Annotation">Category: Annotation</a>
</div>

Annotations can be extensively customized.

[![](/cookbook/5.0/images/AnnotationCustomize.png?241031194635)](/cookbook/5.0/images/AnnotationCustomize.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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

<hr class='my-5 invisible'>


