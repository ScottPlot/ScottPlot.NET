---
Title: Text Offset - ScottPlot 5.0 Cookbook
Description: The offset properties can be used to fine-tune text position in pixel units
URL: /cookbook/5.0/Text/TextOffset/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Text", "Text Offset"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Text", "/cookbook/5.0/Text/TextOffset"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Text Offset</h1>
</div>

The offset properties can be used to fine-tune text position in pixel units

[![](/cookbook/5.0/images/TextOffset.png?250126165944)](/cookbook/5.0/images/TextOffset.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Text.cs" imageUrl="/cookbook/5.0/images/TextOffset.png?250126165944" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 25; i += 5)
{
    // place a marker at the point
    var marker = myPlot.Add.Marker(i, 1);

    // place a styled text label at the point
    var txt = myPlot.Add.Text($"{i}", i, 1);
    txt.LabelFontSize = 16;
    txt.LabelBorderColor = Colors.Black;
    txt.LabelBorderWidth = 1;
    txt.LabelPadding = 2;
    txt.LabelBold = true;
    txt.LabelBackgroundColor = marker.Color.WithAlpha(.5);

    // offset the text label by the given number of pixels
    txt.OffsetX = i;
    txt.OffsetY = i;
}

myPlot.Axes.SetLimitsX(-5, 30);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Text'>Text</a> category</div>


