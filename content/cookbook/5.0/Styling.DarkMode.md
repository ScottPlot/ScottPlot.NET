---
Title: Dark Mode - ScottPlot 5.0 Cookbook
Description: Plots can be created using dark mode by setting the colors of major plot components to ones consistent with a dark theme.
URL: /cookbook/5.0/Styling/DarkMode/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Dark Mode"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/DarkMode"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Styling/DarkMode'>Dark Mode</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Styling/DarkMode">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Styling">Category: Styling Plots</a>
</div>

Plots can be created using dark mode by setting the colors of major plot components to ones consistent with a dark theme.

[![](/cookbook/5.0/images/DarkMode.png?241029205813)](/cookbook/5.0/images/DarkMode.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// set the color palette used when coloring new items added to the plot
myPlot.Add.Palette = new ScottPlot.Palettes.Penumbra();

// add things to the plot
for (int i = 0; i < 5; i++)
{
    var sig = myPlot.Add.Signal(Generate.Sin(51, phase: -.05 * i));
    sig.LineWidth = 3;
    sig.LegendText = $"Line {i + 1}";
}
myPlot.XLabel("Horizontal Axis");
myPlot.YLabel("Vertical Axis");
myPlot.Title("ScottPlot 5 in Dark Mode");
myPlot.ShowLegend();

// change figure colors
myPlot.FigureBackground.Color = Color.FromHex("#181818");
myPlot.DataBackground.Color = Color.FromHex("#1f1f1f");

// change axis and grid colors
myPlot.Axes.Color(Color.FromHex("#d7d7d7"));
myPlot.Grid.MajorLineColor = Color.FromHex("#404040");

// change legend colors
myPlot.Legend.BackgroundColor = Color.FromHex("#404040");
myPlot.Legend.FontColor = Color.FromHex("#d7d7d7");
myPlot.Legend.OutlineColor = Color.FromHex("#d7d7d7");

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


