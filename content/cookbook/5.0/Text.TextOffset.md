---
Title: Text Offset - ScottPlot 5.0 Cookbook
Description: The offset properties can be used to fine-tune text position in pixel units
URL: /cookbook/5.0/Text/TextOffset/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Text", "Text Offset"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Text", "/cookbook/5.0/Text/TextOffset"]
Date: 2024-10-30
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Text/TextOffset'>Text Offset</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Text/TextOffset">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Text">Category: Text</a>
</div>

The offset properties can be used to fine-tune text position in pixel units

[![](/cookbook/5.0/images/TextOffset.png?241029205813)](/cookbook/5.0/images/TextOffset.png?241029205813)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i < 25; i += 5)
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

<hr class='my-5 invisible'>


