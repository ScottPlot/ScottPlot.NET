---
Title: Set Font Slant - ScottPlot 5.0 Cookbook
Description: Font slant can be customized.
URL: /cookbook/5.0/Styling/SetFontSlant/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Styling Plots", "Set Font Slant"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Styling", "/cookbook/5.0/Styling/SetFontSlant"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Set Font Slant</h1>
</div>

Font slant can be customized.

[![](/cookbook/5.0/images/SetFontSlant.png?250822231048)](/cookbook/5.0/images/SetFontSlant.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Styling.cs" imageUrl="/cookbook/5.0/images/SetFontSlant.png?250822231048" >}}ScottPlot.Plot myPlot = new();

myPlot.Font.Set("Calibri", slant: FontSlant.Italic); // apply to many existing plot labels
myPlot.Title("Hello, World");

FontSlant[] slants = [FontSlant.Upright, FontSlant.Italic, FontSlant.Oblique];

for (int i = 0; i &lt; slants.Length; i++)
{
    FontSlant slant = slants[i];
    myPlot.Font.Set("Calibri", slant: slant); // apply to new labels
    var text = myPlot.Add.Text($"FontSlant.{slant}", 0, i);
    text.LabelFontSize = 24;
}

myPlot.Axes.SetLimits(-1, 5, -1, slants.Length);
myPlot.HideGrid();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Styling'>Styling Plots</a> category</div>


