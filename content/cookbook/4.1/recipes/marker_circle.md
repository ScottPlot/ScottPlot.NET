---
Title: "Circle Marker - ScottPlot 4.1 Cookbook"
Description: "Circles can be added anywhere on the plot. If a line style is used, a custom pattern should be created."
Date: 12/11/2023 8:04:06 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/marker_circle/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Marker", "Circle Marker"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-marker", "/cookbook/4.1/recipes/marker_circle/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/marker_circle.png"
---

<h2><a href='/cookbook/4.1/recipes/marker_circle/'>Circle Marker</a></h2>

Circles can be added anywhere on the plot. If a line style is used, a custom pattern should be created.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create a custom pattern (defining dash and space lengths)
List<float> patternLengths = new();
for (int i = 0; i < 20; i++)
{
    patternLengths.Add(1f); // dash
    patternLengths.Add(.5f); // space
    patternLengths.Add(.25f); // dot
    patternLengths.Add(.5f); // space
}

// normalize the lengths so the total pattern length is 1
float totalPatternLength = patternLengths.Sum();
float[] pattern = patternLengths.Select(x => x / totalPatternLength).ToArray();

// apply the custom pattern
ScottPlot.LineStylePatterns.Custom = pattern;

// plot a circle using the custom pattern
plt.AddCircle(x: 7, y: 13, radius: 5, lineWidth: 3, lineStyle: LineStyle.Custom);

plt.SaveFig("marker_Circle.png");
```

<img src='../../images/marker_circle.png' class='d-block mx-auto my-5' />


