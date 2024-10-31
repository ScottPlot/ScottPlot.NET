---
Title: Line Styles - ScottPlot 5.0 Cookbook
Description: Many plot types have a LineStyle which can be customized.
URL: /cookbook/5.0/Styling/LineStyles/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Line Styles"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/LineStyles"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Styling/LineStyles'>Line Styles</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Styling/LineStyles">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Styling">Category: Styling Plots</a>
</div>

Many plot types have a LineStyle which can be customized.

[![](/cookbook/5.0/images/LineStyles.png?241031194635)](/cookbook/5.0/images/LineStyles.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

List<LinePattern> patterns = [];
patterns.AddRange(LinePattern.GetAllPatterns());
patterns.Add(new([2, 2, 5, 10], 0, "Custom"));

for (int i = 0; i < patterns.Count; i++)
{
    LinePattern pattern = patterns[i];

    var line = myPlot.Add.Line(0, -i, 1, -i);
    line.LinePattern = pattern;
    line.LineWidth = 2;
    line.Color = Colors.Black;

    var txt = myPlot.Add.Text(patterns[i].Name, 1.1, -i);
    txt.LabelFontSize = 18;
    txt.LabelBold = true;
    txt.LabelFontColor = Colors.Black;
    txt.LabelAlignment = Alignment.MiddleLeft;
}

myPlot.Axes.Margins(right: 1);
myPlot.HideGrid();
myPlot.Layout.Frameless();

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


