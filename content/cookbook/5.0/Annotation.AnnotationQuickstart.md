---
Title: Annotation Quickstart - ScottPlot 5.0 Cookbook
Description: Annotations are labels you can place on the data area of a plot. Unlike Text added to the plot (which is placed in coordinate units on the axes), Annotations are positioned relative to the data area (in pixel units) and do not move as the plot is panned and zoomed.
URL: /cookbook/5.0/Annotation/AnnotationQuickstart/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Annotation", "Annotation Quickstart"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Annotation", "/cookbook/5.0/Annotation/AnnotationQuickstart"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Annotation Quickstart</h1>
</div>

Annotations are labels you can place on the data area of a plot. Unlike Text added to the plot (which is placed in coordinate units on the axes), Annotations are positioned relative to the data area (in pixel units) and do not move as the plot is panned and zoomed.

[![](/cookbook/5.0/images/AnnotationQuickstart.png?250126165944)](/cookbook/5.0/images/AnnotationQuickstart.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Annotation.cs" imageUrl="/cookbook/5.0/images/AnnotationQuickstart.png?250126165944" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Add.Annotation("This is an Annotation");

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Annotation'>Annotation</a> category</div>


