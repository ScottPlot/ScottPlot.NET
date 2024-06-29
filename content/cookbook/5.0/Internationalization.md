---
Title: Internationalization - ScottPlot 5.0 Cookbook
Description: Using ScottPlot across cultures with different text and numeric requirements.
URL: /cookbook/5.0/Internationalization/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Internationalization"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Internationalization"]
Date: 2024-06-29
Version: ScottPlot 5.0.36
Version: ScottPlot 5.0.36
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Internationalization


<h2><a href='/cookbook/5.0/Internationalization/FontDetection'>Supported Font Detection</a></h2>

ScottPlot comes with font detection methods which help identify the best installed font for displaying text which may contain international characters.

[![](/cookbook/5.0/images/FontDetection.png?240629072232)](/cookbook/5.0/images/FontDetection.png?240629072232)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

string chinese = "测试";
myPlot.Axes.Title.Label.Text = chinese;
myPlot.Axes.Title.Label.FontName = Fonts.Detect(chinese);

string japanese = "試験";
myPlot.Axes.Left.Label.Text = japanese;
myPlot.Axes.Left.Label.FontName = Fonts.Detect(japanese);

string korean = "테스트";
myPlot.Axes.Bottom.Label.Text = korean;
myPlot.Axes.Bottom.Label.FontName = Fonts.Detect(korean);

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>


<h2><a href='/cookbook/5.0/Internationalization/AutomaticFontDetection'>Automatic Font Detection</a></h2>

The Plot's Style class contains a method which automatically sets the fonts of common plot objects to the font most likely able to display the characters they contain.

[![](/cookbook/5.0/images/AutomaticFontDetection.png?240629072232)](/cookbook/5.0/images/AutomaticFontDetection.png?240629072232)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin(phase: .1));
var sig2 = myPlot.Add.Signal(Generate.Sin(phase: .2));
var sig3 = myPlot.Add.Signal(Generate.Sin(phase: .3));

sig1.LegendText = "测试"; // Chinese
sig2.LegendText = "試験"; // Japanese
sig3.LegendText = "테스트"; // Korean
myPlot.ShowLegend();

myPlot.Title("测试"); // Chinese
myPlot.YLabel("試験"); // Japanese
myPlot.XLabel("테스트"); // Korean

myPlot.Font.Automatic(); // set font for each item based on its content

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

