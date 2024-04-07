---
Title: Annotation - ScottPlot 5.0 Cookbook
Description: Annotations are always-visible text labels positioned over the data area.
URL: /cookbook/5.0/Annotation/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Annotation"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Annotation"]
Date: 2024-04-07
Version: ScottPlot 5.0.24
Version: ScottPlot 5.0.24
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Annotation


<h2><a href='/cookbook/5.0/Annotation/AnnotationQuickstart'>Annotation Quickstart</a></h2>

Annotations are labels you can place on the data area of a plot. Unlike Text added to the plot (which is placed in coordinate units on the axes), Annotations are positioned relative to the data area (in pixel units) and do not move as the plot is panned and zoomed.

[![](/cookbook/5.0/images/AnnotationQuickstart.png?240407170921)](/cookbook/5.0/images/AnnotationQuickstart.png?240407170921)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.Add.Annotation("This is an Annotation");

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Annotation/AnnotationCustomize'>Annotation Customization</a></h2>

Annotations can be extensively customized.

[![](/cookbook/5.0/images/AnnotationCustomize.png?240407170921)](/cookbook/5.0/images/AnnotationCustomize.png?240407170921)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

var anno = myPlot.Add.Annotation("Customized\nAnnotation");
anno.Label.FontSize = 32;
anno.Label.FontName = Fonts.Serif;
anno.Label.BackColor = Colors.RebeccaPurple.WithAlpha(.3);
anno.Label.ForeColor = Colors.RebeccaPurple;
anno.Label.BorderColor = Colors.Green;
anno.Label.BorderWidth = 3;
anno.OffsetY = 40;
anno.OffsetX = 20;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Annotation/AnnotationPositions'>Annotation Positions</a></h2>

Annotations are aligned with the data area.

[![](/cookbook/5.0/images/AnnotationPositions.png?240407170921)](/cookbook/5.0/images/AnnotationPositions.png?240407170921)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

foreach (Alignment alignment in Enum.GetValues(typeof(Alignment)))
{
    myPlot.Add.Annotation(alignment.ToString(), alignment);
}

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

