---
Title: "Customize Pie Colors - ScottPlot 4.1 Cookbook"
Description: "Colors for pie slices and labels can be customized."
Date: 2024-01-07
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/pie_customcolors/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Pie Chart", "Customize Pie Colors"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-pie", "/cookbook/4.1/recipes/pie_customcolors/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/pie_customcolors.png"
---

<h2><a id='customize-pie-colors' href='/cookbook/4.1/recipes/pie_customcolors/'>Customize Pie Colors</a></h2>

Colors for pie slices and labels can be customized.

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 778, 43, 283, 76, 184 };
string[] labels = { "C#", "JAVA", "Python", "F#", "PHP" };

// Language colors from https://github.com/ozh/github-colors
Color[] sliceColors =
{
    ColorTranslator.FromHtml("#178600"),
    ColorTranslator.FromHtml("#B07219"),
    ColorTranslator.FromHtml("#3572A5"),
    ColorTranslator.FromHtml("#B845FC"),
    ColorTranslator.FromHtml("#4F5D95"),
};

// Show labels using different transparencies
Color[] labelColors =
    new Color[] {
    Color.FromArgb(255, Color.White),
    Color.FromArgb(100, Color.White),
    Color.FromArgb(250, Color.White),
    Color.FromArgb(150, Color.White),
    Color.FromArgb(200, Color.White),
};

var pie = plt.AddPie(values);
pie.SliceLabels = labels;
pie.ShowLabels = true;
pie.SliceFillColors = sliceColors;
pie.SliceLabelColors = labelColors;

plt.SaveFig("pie_customColors.png");
```

<img src='../../images/pie_customcolors.png' class='d-block mx-auto my-5' />


