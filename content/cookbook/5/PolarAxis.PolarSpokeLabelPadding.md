---
Title: Polar Spoke Label Padding - ScottPlot 5 Cookbook
Description: Modifies the padding of labels on polar spokes.
URL: /cookbook/5/PolarAxis/PolarSpokeLabelPadding/
BreadcrumbNames: ["ScottPlot 5 Cookbook", "Polar Axis", "Polar Spoke Label Padding"]
BreadcrumbUrls: ["/cookbook/5/", "/cookbook/5/PolarAxis", "/cookbook/5/PolarAxis/PolarSpokeLabelPadding"]
Date: 2025-10-11
Version: ScottPlot 5.1.57
Version: ScottPlot 5.1.57
SearchUrl: "/cookbook/5/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Polar Spoke Label Padding</h1>
</div>

Modifies the padding of labels on polar spokes.

[![](/cookbook/5/images/PolarSpokeLabelPadding.png?251011113742)](/cookbook/5/images/PolarSpokeLabelPadding.png?251011113742)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/PolarAxis.cs" imageUrl="/cookbook/5/images/PolarSpokeLabelPadding.png?251011113742" >}}ScottPlot.Plot myPlot = new();

var polarAxis = myPlot.Add.PolarAxis();
polarAxis.SetSpokes(4, 1);

for (int i = 0; i &lt; polarAxis.Spokes.Count; i++)
{
    polarAxis.Spokes[i].LineWidth = 4;
    polarAxis.Spokes[i].LabelStyle.FontSize = 16;
    polarAxis.Spokes[i].LabelPaddingFraction = 0.2 * i;
    polarAxis.Spokes[i].LabelText = $"{polarAxis.Spokes[i].LabelLength}";
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5/PolarAxis'>Polar Axis</a> category</div>


