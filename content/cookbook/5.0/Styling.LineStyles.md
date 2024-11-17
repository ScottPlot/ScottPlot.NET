---
Title: Line Styles - ScottPlot 5.0 Cookbook
Description: Many plot types have a LineStyle which can be customized.
URL: /cookbook/5.0/Styling/LineStyles/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Line Styles"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/LineStyles"]
Date: 2024-11-17
Version: ScottPlot 5.0.46
Version: ScottPlot 5.0.46
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Line Styles</h1>
</div>

Many plot types have a LineStyle which can be customized.

[![](/cookbook/5.0/images/LineStyles.png?241117162641)](/cookbook/5.0/images/LineStyles.png?241117162641)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5.0/images/LineStyles.png?241117162641" >}}ScottPlot.Plot myPlot = new();

List&lt;LinePattern&gt; patterns = [];
patterns.AddRange(LinePattern.GetAllPatterns());
patterns.Add(new([2, 2, 5, 10], 0, "Custom"));

for (int i = 0; i &lt; patterns.Count; i++)
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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Styling'>Styling Plots</a> category</div>


