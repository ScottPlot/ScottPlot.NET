---
Title: Annotation - ScottPlot 5.0 Cookbook
Description: Annotations are always-visible text labels positioned over the data area.
URL: /cookbook/5.0/Annotation/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Annotation"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Annotation"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Annotation</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Annotation Quickstart</h1>
<a href='/cookbook/5.0/Annotation/AnnotationQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Annotations are labels you can place on the data area of a plot. Unlike Text added to the plot (which is placed in coordinate units on the axes), Annotations are positioned relative to the data area (in pixel units) and do not move as the plot is panned and zoomed.

[![](/cookbook/5.0/images/AnnotationQuickstart.png?241101192719)](/cookbook/5.0/images/AnnotationQuickstart.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Add.Annotation("This is an Annotation");

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Annotation Customization</h1>
<a href='/cookbook/5.0/Annotation/AnnotationCustomize' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Annotations can be extensively customized.

[![](/cookbook/5.0/images/AnnotationCustomize.png?241101192719)](/cookbook/5.0/images/AnnotationCustomize.png?241101192719)

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



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Annotation Positions</h1>
<a href='/cookbook/5.0/Annotation/AnnotationPositions' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Annotations are aligned with the data area.

[![](/cookbook/5.0/images/AnnotationPositions.png?241101192719)](/cookbook/5.0/images/AnnotationPositions.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

foreach (Alignment alignment in Enum.GetValues(typeof(Alignment)))
{
    myPlot.Add.Annotation(alignment.ToString(), alignment);
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


