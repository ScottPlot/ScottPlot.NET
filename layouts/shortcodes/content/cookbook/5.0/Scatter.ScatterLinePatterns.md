---
Title: Scatter Line Patterns - ScottPlot 5.0 Cookbook
Description: Several line patterns are available
URL: /cookbook/5.0/Scatter/ScatterLinePatterns/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot", "Scatter Line Patterns"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter", "/cookbook/5.0/Scatter/ScatterLinePatterns"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Line Patterns</h1>
</div>

Several line patterns are available

[![](/cookbook/5.0/images/ScatterLinePatterns.png?250822231048)](/cookbook/5.0/images/ScatterLinePatterns.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterLinePatterns.png?250822231048" >}}ScottPlot.Plot myPlot = new();

List&lt;LinePattern&gt; patterns = [];
patterns.AddRange(LinePattern.GetAllPatterns());
patterns.Add(new([2, 2, 5, 10], 0, "Custom"));

ScottPlot.Palettes.ColorblindFriendly palette = new();

for (int i = 0; i &lt; patterns.Count; i++)
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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Scatter'>Scatter Plot</a> category</div>


