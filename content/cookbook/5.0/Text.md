---
Title: Text - ScottPlot 5.0 Cookbook
Description: Text labels can be placed on the plot in coordinate space
URL: /cookbook/5.0/Text/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Text"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Text"]
Date: 2024-10-28
Version: ScottPlot 5.0.41
Version: ScottPlot 5.0.41
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Text


<h2><a href='/cookbook/5.0/Text/TextQuickstart'>Text Quickstart</a></h2>

Text can be placed anywhere in coordinate space.

[![](/cookbook/5.0/images/TextQuickstart.png?241027220842)](/cookbook/5.0/images/TextQuickstart.png?241027220842)

{{< recipe-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());
myPlot.Add.Text("Hello, World", 25, 0.5);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Text/Formatting'>Text Formatting</a></h2>

Text formatting can be extensively customized.

[![](/cookbook/5.0/images/Formatting.png?241027220842)](/cookbook/5.0/images/Formatting.png?241027220842)

{{< recipe-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var text = myPlot.Add.Text("Hello, World", 42, 69);
text.LabelFontSize = 26;
text.LabelBold = true;
text.LabelRotation = -45;
text.LabelFontColor = Colors.Yellow;
text.LabelBackgroundColor = Colors.Navy.WithAlpha(.5);
text.LabelBorderColor = Colors.Magenta;
text.LabelBorderWidth = 3;
text.LabelPadding = 10;
text.LabelAlignment = Alignment.MiddleCenter;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Text/LabelLineHeight'>Line Height</a></h2>

Multiline labels have a default line height estimated from the typeface and font size, however line height may be manually defined by the user.

[![](/cookbook/5.0/images/LabelLineHeight.png?241027220842)](/cookbook/5.0/images/LabelLineHeight.png?241027220842)

{{< recipe-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var label1 = myPlot.Add.Text($"line\nheight", 0, 0);
label1.LabelLineSpacing = 0;
label1.LabelFontColor = Colors.Red;
label1.LabelBorderColor = Colors.Black;

var label2 = myPlot.Add.Text($"can\nbe", 1, 0);
label2.LabelLineSpacing = 10;
label2.LabelFontColor = Colors.Orange;
label2.LabelBorderColor = Colors.Black;

var label3 = myPlot.Add.Text($"automatic\nor", 2, 0);
label3.LabelLineSpacing = null;
label3.LabelFontColor = Colors.Green;
label3.LabelBorderColor = Colors.Black;

var label4 = myPlot.Add.Text($"set\nmanually", 3, 0);
label4.LabelLineSpacing = 15;
label4.LabelFontColor = Colors.Blue;
label4.LabelBorderColor = Colors.Black;

myPlot.HideGrid();
myPlot.Axes.SetLimitsX(-.5, 4);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Text/TextOffset'>Text Offset</a></h2>

The offset properties can be used to fine-tune text position in pixel units

[![](/cookbook/5.0/images/TextOffset.png?241027220842)](/cookbook/5.0/images/TextOffset.png?241027220842)

{{< recipe-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

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

```

{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>

