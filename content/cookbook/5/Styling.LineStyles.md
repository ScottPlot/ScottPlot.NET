---
Title: Line Styles - ScottPlot 5 Cookbook
Description: Many plot types have a LineStyle which can be customized.
URL: /cookbook/5/Styling/LineStyles/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Styling Plots", "Line Styles"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Styling", "/cookbook/5/Styling/LineStyles"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Line Styles</h1>
</div>

Many plot types have a LineStyle which can be customized.

[![](/cookbook/5/images/LineStyles.png?260329072039)](/cookbook/5/images/LineStyles.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5/images/LineStyles.png?260329072039" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Styling'>Styling Plots</a> category</div>


