---
Title: Scatter Line Patterns - ScottPlot 5.0 Cookbook
Description: Several line patterns are available
URL: /cookbook/5.0/Scatter/ScatterLinePatterns/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Line Patterns"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterLinePatterns"]
Date: 2024-05-04
Version: ScottPlot 5.0.33
Version: ScottPlot 5.0.33
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Scatter Line Patterns


Several line patterns are available

[![](/cookbook/5.0/images/ScatterLinePatterns.png?240504011455)](/cookbook/5.0/images/ScatterLinePatterns.png?240504011455)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

LinePattern[] patterns = Enum.GetValues<LinePattern>();
ScottPlot.Palettes.ColorblindFriendly palette = new();

for (int i = 0; i < patterns.Length; i++)
{
    double yOffset = patterns.Length - i;
    double[] xs = Generate.Consecutive(51);
    double[] ys = Generate.Sin(51, offset: yOffset);

    var sp = myPlot.Add.Scatter(xs, ys);
    sp.LineWidth = 2;
    sp.MarkerSize = 0;
    sp.LinePattern = patterns[i];
    sp.Color = palette.GetColor(i);

    var txt = myPlot.Add.Text(patterns[i].ToString(), 51, yOffset);
    txt.LabelFontColor = sp.Color;
    txt.LabelFontSize = 22;
    txt.LabelBold = true;
    txt.LabelAlignment = Alignment.MiddleLeft;
}

myPlot.Axes.Margins(.05, .5, .05, .05);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<a href='https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs'><svg xmlns="http://www.w3.org/2000/svg" width="16" height="16" fill="currentColor" class="mb-1 bi bi-github" viewBox="0 0 16 16">
  <path d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27s1.36.09 2 .27c1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.01 8.01 0 0 0 16 8c0-4.42-3.58-8-8-8"/>
</svg> Edit on GitHub</a>

