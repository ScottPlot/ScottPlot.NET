---
Title: Annotation Quickstart - ScottPlot 5.0 Cookbook
Description: Annotations are labels you can place on the data area of a plot. Unlike Text added to the plot (which is placed in coordinate units on the axes), Annotations are positioned relative to the data area (in pixel units) and do not move as the plot is panned and zoomed.
URL: /cookbook/5.0/Annotation/AnnotationQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Annotation", "Annotation Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Annotation", "/cookbook/5.0/Annotation/AnnotationQuickstart"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Annotation/AnnotationQuickstart'>Annotation Quickstart</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Annotation/AnnotationQuickstart">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Annotation">Category: Annotation</a>
</div>

Annotations are labels you can place on the data area of a plot. Unlike Text added to the plot (which is placed in coordinate units on the axes), Annotations are positioned relative to the data area (in pixel units) and do not move as the plot is panned and zoomed.

[![](/cookbook/5.0/images/AnnotationQuickstart.png?241031194635)](/cookbook/5.0/images/AnnotationQuickstart.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Add.Annotation("This is an Annotation");

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


