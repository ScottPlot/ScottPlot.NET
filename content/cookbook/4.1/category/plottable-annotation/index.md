---
Title: Annotation - ScottPlot 4.1 Cookbook
Description: Plottable - Annotation recipes
Source: https://github.com/ScottPlot/ScottPlot/tree/master/src/cookbook
---

## Figure Annotations

Annotations are labels placed at a X/Y location on the figure (not coordinates of the data area). Unlike the Text plottable, annotations do not move as the axes are adjusted.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Range(0, 5, .1);
plt.AddScatter(xs, DataGen.Sin(xs));
plt.AddScatter(xs, DataGen.Cos(xs));

// default placement is upper left
plt.AddAnnotation("Top Left", 10, 10);

// negative coordinates can be used to place text along different edges
plt.AddAnnotation("Lower Left", 10, -10);
plt.AddAnnotation("Top Right", -10, 10);
plt.AddAnnotation("Lower Right", -10, -10);

// Additional customizations are available
var fancy = plt.AddAnnotation("Fancy Annotation", 10, 40);
fancy.Font.Size = 24;
fancy.Font.Name = "Impact";
fancy.Font.Color = Color.Red;
fancy.Shadow = false;
fancy.BackgroundColor = Color.FromArgb(25, Color.Blue);
fancy.BorderWidth = 2;
fancy.BorderColor = Color.Magenta;

plt.SaveFig("annotation_quickstart.png");
```

<div class='text-center'>
<a href='../../images/annotation_quickstart.png'><img src='../../images/annotation_quickstart.png' /></a>
</div>

