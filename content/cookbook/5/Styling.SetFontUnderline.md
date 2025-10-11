---
Title: Set Label Underline - ScottPlot 5 Cookbook
Description: Underlines may be added to label styles. Underline thickness and offset may be customized as well.
URL: /cookbook/5/Styling/SetFontUnderline/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Styling Plots", "Set Label Underline"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Styling", "/cookbook/5/Styling/SetFontUnderline"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Set Label Underline</h1>
</div>

Underlines may be added to label styles. Underline thickness and offset may be customized as well.

[![](/cookbook/5/images/SetFontUnderline.png?251011113742)](/cookbook/5/images/SetFontUnderline.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5/images/SetFontUnderline.png?251011113742" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 5; i++)
{
    var text = myPlot.Add.Text($"Underline {i}px", i / 5.0, i);
    text.LabelFontSize = 24;
    text.LabelFontColor = ScottPlot.Palette.Default.GetColor(i);
    text.LabelUnderline = true;
    text.LabelUnderlineWidth = i;
    text.LabelUnderlineOffset = 2 + i / 2;
}

myPlot.Axes.SetLimits(-1, 5, -1, 4);
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Styling'>Styling Plots</a> category</div>


