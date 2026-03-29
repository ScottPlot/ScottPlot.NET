---
Title: Set Font Weight - ScottPlot 5 Cookbook
Description: Font weight can be customized.
URL: /cookbook/5/Styling/SetFontWeight/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Styling Plots", "Set Font Weight"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/Styling", "/cookbook/5/Styling/SetFontWeight"]
Date: 2026-03-29
Version: ScottPlot 5.1.58
Version: ScottPlot 5.1.58
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Set Font Weight</h1>
</div>

Font weight can be customized.

[![](/cookbook/5/images/SetFontWeight.png?260329072039)](/cookbook/5/images/SetFontWeight.png?260329072039)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5/images/SetFontWeight.png?260329072039" >}}ScottPlot.Plot myPlot = new();

myPlot.Font.Set("Calibri"); // apply to many existing plot labels
myPlot.Title("Hello, World");

FontWeight[] weights = [FontWeight.Light, FontWeight.Normal,
    FontWeight.SemiBold, FontWeight.Bold, FontWeight.ExtraBlack];

for (int i = 0; i &lt; weights.Length; i++)
{
    FontWeight weight = weights[i];
    myPlot.Font.Set("Calibri", weight: weight); // apply to new labels
    var text = myPlot.Add.Text($"FontWeight.{weight}", 0, i);
    text.LabelFontSize = 24;
}

myPlot.Axes.SetLimits(-1, 5, -2, weights.Length);
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/Styling'>Styling Plots</a> category</div>


