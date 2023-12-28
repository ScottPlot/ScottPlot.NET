---
Title: "Text Alignment and Rotation - ScottPlot 4.1 Cookbook"
Description: "Alignment indicates which corner is placed at the X/Y coordinate."
Date: 2023-12-28
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/text_alignment/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Text", "Text Alignment and Rotation"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-text", "/cookbook/4.1/recipes/text_alignment/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/text_alignment.png"
---

<h2><a id='text-alignment-and-rotation' href='/cookbook/4.1/recipes/text_alignment/'>Text Alignment and Rotation</a></h2>

Alignment indicates which corner is placed at the X/Y coordinate.

```cs
var plt = new ScottPlot.Plot(600, 400);

ScottPlot.Alignment[] alignments = (ScottPlot.Alignment[])Enum.GetValues(typeof(ScottPlot.Alignment));

for (int i = 0; i < alignments.Length; i++)
{
    double frac = (double)i / alignments.Length;
    double x = Math.Sin(frac * Math.PI * 2);
    double y = Math.Cos(frac * Math.PI * 2);

    var txt = plt.AddText(alignments[i].ToString(), x, y);
    txt.Alignment = alignments[i];
    txt.Font.Color = Color.Black; ;
    txt.BackgroundColor = Color.LightSteelBlue;
    txt.BackgroundFill = true;
    txt.Rotation = 5;
    txt.BorderSize = 2;
    txt.BorderColor = Color.Navy;
    txt.DragEnabled = true;

    plt.AddPoint(x, y, Color.Red, 10);
}

plt.Margins(.5, .2);

plt.SaveFig("text_alignment.png");
```

<img src='../../images/text_alignment.png' class='d-block mx-auto my-5' />


