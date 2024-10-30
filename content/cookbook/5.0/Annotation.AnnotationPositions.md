---
Title: Annotation Positions - ScottPlot 5.0 Cookbook
Description: Annotations are aligned with the data area.
URL: /cookbook/5.0/Annotation/AnnotationPositions/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Annotation", "Annotation Positions"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Annotation", "/cookbook/5.0/Annotation/AnnotationPositions"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Annotation/AnnotationPositions'>Annotation Positions</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Annotation/AnnotationPositions">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Annotation">Category: Annotation</a>
</div>

Annotations are aligned with the data area.

[![](/cookbook/5.0/images/AnnotationPositions.png?241029205813)](/cookbook/5.0/images/AnnotationPositions.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

foreach (Alignment alignment in Enum.GetValues(typeof(Alignment)))
{
    myPlot.Add.Annotation(alignment.ToString(), alignment);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


