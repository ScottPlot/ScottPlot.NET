---
Title: Scatter Line Patterns - ScottPlot 5.0 Cookbook
Description: Several line patterns are available
URL: /cookbook/5.0/Scatter/ScatterLinePatterns/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Line Patterns"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterLinePatterns"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Scatter/ScatterLinePatterns'>Scatter Line Patterns</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Scatter/ScatterLinePatterns">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Scatter">Category: Scatter Plot</a>
</div>

Several line patterns are available

[![](/cookbook/5.0/images/ScatterLinePatterns.png?241029205813)](/cookbook/5.0/images/ScatterLinePatterns.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

List<LinePattern> patterns = [];
patterns.AddRange(LinePattern.GetAllPatterns());
patterns.Add(new([2, 2, 5, 10], 0, "Custom"));

ScottPlot.Palettes.ColorblindFriendly palette = new();

for (int i = 0; i < patterns.Count; i++)
{
    double yOffset = patterns.Count - i;
    double[] xs = Generate.Consecutive(51);
    double[] ys = Generate.Sin(51, offset: yOffset);

    var sp = myPlot.Add.Scatter(xs, ys);
    sp.LineWidth = 2;
    sp.MarkerSize = 0;
    sp.LinePattern = patterns[i];
    sp.Color = palette.GetColor(i);

    var txt = myPlot.Add.Text(patterns[i].Name, 51, yOffset);
    txt.LabelFontColor = sp.Color;
    txt.LabelFontSize = 22;
    txt.LabelBold = true;
    txt.LabelAlignment = Alignment.MiddleLeft;
}

myPlot.Axes.Margins(.05, .5, .05, .05);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


