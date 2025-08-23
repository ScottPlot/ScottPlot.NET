---
Title: Annotation Positions - ScottPlot 5.0 Cookbook
Description: Annotations are aligned with the data area.
URL: /cookbook/5.0/Annotation/AnnotationPositions/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Annotation", "Annotation Positions"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Annotation", "/cookbook/5.0/Annotation/AnnotationPositions"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Annotation Positions</h1>
</div>

Annotations are aligned with the data area.

[![](/cookbook/5.0/images/AnnotationPositions.png?250822231048)](/cookbook/5.0/images/AnnotationPositions.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Annotation.cs" imageUrl="/cookbook/5.0/images/AnnotationPositions.png?250822231048" >}}ScottPlot.Plot myPlot = new();

foreach (Alignment alignment in Enum.GetValues(typeof(Alignment)))
{
    myPlot.Add.Annotation(alignment.ToString(), alignment);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Annotation'>Annotation</a> category</div>


