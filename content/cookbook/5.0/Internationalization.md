---
Title: Internationalization - ScottPlot 5.0 Cookbook
Description: Using ScottPlot across cultures with different text and numeric requirements.
URL: /cookbook/5.0/Internationalization/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Internationalization"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Internationalization"]
Date: 2024-11-24
Version: ScottPlot 5.0.47
Version: ScottPlot 5.0.47
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Internationalization</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Supported Font Detection</h1>
<a href='/cookbook/5.0/Internationalization/FontDetection' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

ScottPlot comes with font detection methods which help identify the best installed font for displaying text which may contain international characters.

[![](/cookbook/5.0/images/FontDetection.png?241124170640)](/cookbook/5.0/images/FontDetection.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Internationalization.cs" imageUrl="/cookbook/5.0/images/FontDetection.png?241124170640" >}}ScottPlot.Plot myPlot = new();

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
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Automatic Font Detection</h1>
<a href='/cookbook/5.0/Internationalization/AutomaticFontDetection' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The Plot's Style class contains a method which automatically sets the fonts of common plot objects to the font most likely able to display the characters they contain.

[![](/cookbook/5.0/images/AutomaticFontDetection.png?241124170640)](/cookbook/5.0/images/AutomaticFontDetection.png?241124170640)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Internationalization.cs" imageUrl="/cookbook/5.0/images/AutomaticFontDetection.png?241124170640" >}}ScottPlot.Plot myPlot = new();

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
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


