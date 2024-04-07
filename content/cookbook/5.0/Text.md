---
Title: Text - ScottPlot 5.0 Cookbook
Description: Text labels can be placed on the plot in coordinate space
URL: /cookbook/5.0/Text/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Text"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Text"]
Date: 2024-04-07
Version: ScottPlot 5.0.24
Version: ScottPlot 5.0.24
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Text


<h2><a href='/cookbook/5.0/Text/TextQuickstart'>Text Quickstart</a></h2>

Text can be placed anywhere in coordinate space.

[![](/cookbook/5.0/images/TextQuickstart.png?240407170921)](/cookbook/5.0/images/TextQuickstart.png?240407170921)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());
myPlot.Add.Text("Hello, World", 25, 0.5);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Text/Formatting'>Text Formatting</a></h2>

Text formatting can be extensively customized.

[![](/cookbook/5.0/images/Formatting.png?240407170921)](/cookbook/5.0/images/Formatting.png?240407170921)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var text = myPlot.Add.Text("Hello, World", 42, 69);
text.Label.FontSize = 26;
text.Label.Bold = true;
text.Label.Rotation = -45;
text.Label.ForeColor = Colors.Yellow;
text.Label.BackColor = Colors.Navy.WithAlpha(.5);
text.Label.BorderColor = Colors.Magenta;
text.Label.BorderWidth = 3;
text.Label.Padding = 10;
text.Label.Alignment = Alignment.MiddleCenter;

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Text/LabelLineHeight'>Line Height</a></h2>

Multiline labels have a default line height estimated from the typeface and font size, however line height may be manually defined by the user.

[![](/cookbook/5.0/images/LabelLineHeight.png?240407170921)](/cookbook/5.0/images/LabelLineHeight.png?240407170921)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var label1 = myPlot.Add.Text($"line\nheight", 0, 0);
label1.LineSpacing = 0;
label1.FontColor = Colors.Red;

var label2 = myPlot.Add.Text($"can\nbe", 1, 0);
label2.LineSpacing = 10;
label2.FontColor = Colors.Orange;

var label3 = myPlot.Add.Text($"automatic\nor", 2, 0);
label3.LineSpacing = null;
label3.FontColor = Colors.Green;

var label4 = myPlot.Add.Text($"set\nmanually", 3, 0);
label4.LineSpacing = 15;
label4.FontColor = Colors.Blue;

myPlot.Axes.SetLimitsX(-.5, 4);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Text/TextOffset'>Text Offset</a></h2>

The offset properties can be used to fine-tune text position in pixel units

[![](/cookbook/5.0/images/TextOffset.png?240407170921)](/cookbook/5.0/images/TextOffset.png?240407170921)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

for (int i = 0; i < 25; i += 5)
{
    // place a marker at the point
    var marker = myPlot.Add.Marker(i, 1);

    // place a styled text label at the point
    var txt = myPlot.Add.Text($"{i}", i, 1);
    txt.FontSize = 16;
    txt.BorderColor = Colors.Black;
    txt.BorderWidth = 1;
    txt.Padding = 2;
    txt.Bold = true;
    txt.BackColor = marker.Color.WithAlpha(.5);

    // offset the text label by the given number of pixels
    txt.OffsetX = i;
    txt.OffsetY = i;
}

myPlot.Axes.SetLimitsX(-5, 30);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

