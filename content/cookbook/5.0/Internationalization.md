---
Title: Internationalization - ScottPlot 5.0 Cookbook
Description: Using ScottPlot across cultures with different text and numeric requirements.
URL: /cookbook/5.0/Internationalization/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Internationalization"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Internationalization"]
Date: 2024-01-16
Version: ScottPlot 5.0.16
Version: ScottPlot 5.0.16
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

# Internationalization


<h2><a href='/cookbook/5.0/Internationalization/FontDetection'>Supported Font Detection</a></h2>

ScottPlot comes with font detection methods which help identify the best installed font for displaying text which may contain international characters.

[![](/cookbook/5.0/images/FontDetection.png)](/cookbook/5.0/images/FontDetection.png)

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

[![](/cookbook/5.0/images/AutomaticFontDetection.png)](/cookbook/5.0/images/AutomaticFontDetection.png)

{{< code-sp5 >}}

```cs
ScottPlot.Plot myPlot = new();

myPlot.Title("测试"); // Chinese
myPlot.YLabel("試験"); // Japanese
myPlot.XLabel("테스트"); // Korean
myPlot.Style.SetBestFonts();

myPlot.SavePng("demo.png", 400, 300);

```

{{< /code-sp5 >}}

<hr class='my-5 invisible'>

