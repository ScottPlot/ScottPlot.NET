---
Title: Annotation Positions - ScottPlot 5 Cookbook
Description: Annotations are aligned with the data area.
URL: /cookbook/5/Annotation/AnnotationPositions/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Annotation", "Annotation Positions"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Annotation", "/cookbook/5/Annotation/AnnotationPositions"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Annotation Positions</h1>
</div>

Annotations are aligned with the data area.

[![](/cookbook/5/images/AnnotationPositions.png?260329072039)](/cookbook/5/images/AnnotationPositions.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Annotation.cs" imageUrl="/cookbook/5/images/AnnotationPositions.png?260329072039" >}}ScottPlot.Plot myPlot = new();

foreach (Alignment alignment in Enum.GetValues(typeof(Alignment)))
{
    myPlot.Add.Annotation(alignment.ToString(), alignment);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Annotation'>Annotation</a> category</div>


