---
Title: Hand Drawn Line Style - ScottPlot 5.0 Cookbook
Description: Enabling hand-drawn line style allows creation of charts that mimic XKCD style graphs which use squiggly lines for comedic effect.
URL: /cookbook/5.0/Styling/HandDrawn/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Hand Drawn Line Style"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/HandDrawn"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Hand Drawn Line Style</h1>
</div>

Enabling hand-drawn line style allows creation of charts that mimic XKCD style graphs which use squiggly lines for comedic effect.

[![](/cookbook/5.0/images/HandDrawn.png?241105214550)](/cookbook/5.0/images/HandDrawn.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5.0/images/HandDrawn.png?241105214550" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(100);
double[] values1 = Generate.Sigmoidal(xs.Length, -1, 2);

// create a hand drawn scatter plot
var sp = myPlot.Add.ScatterLine(xs, values1);
sp.LineStyle.HandDrawn = true;
sp.LineStyle.HandDrawnJitter = 2;
sp.LineWidth = 3;
sp.LineColor = Colors.Black;

// configure axis frames to appear hand drawn
myPlot.HideGrid();
myPlot.Axes.GetAxes().ToList().ForEach(x =&gt; x.FrameLineStyle.HandDrawn = true);

// use a comedic font for axis titles and tick labels
myPlot.Title("Answers");
myPlot.YLabel("Utility");
myPlot.XLabel("Time Taken to Respond");
myPlot.Axes.Title.Label.FontName = "Comic Sans MS";
myPlot.Axes.Left.Label.FontName = "Comic Sans MS";
myPlot.Axes.Bottom.Label.FontName = "Comic Sans MS";
myPlot.Axes.Bottom.TickLabelStyle.FontName = "Comic Sans MS";

// use manually placed horizontal axis ticks
myPlot.Axes.Left.TickGenerator = new ScottPlot.TickGenerators.EmptyTickGenerator();
myPlot.Axes.Bottom.SetTicks([10, 50, 75], ["Minutes", "Days", "Weeks"]);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Styling'>Styling Plots</a> category</div>


