---
Title: Supported Font Detection - ScottPlot 5.0 Cookbook
Description: ScottPlot comes with font detection methods which help identify the best installed font for displaying text which may contain international characters.
URL: /cookbook/5.0/Internationalization/FontDetection/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Internationalization", "Supported Font Detection"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Internationalization", "/cookbook/5.0/Internationalization/FontDetection"]
Date: 2024-10-31
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<h2 style='border-bottom: 0;'><a href='/cookbook/5.0/Internationalization/FontDetection'>Supported Font Detection</a></h2>

<div class="d-flex mb-2">
<a class="btn btn-sm btn-primary me-1" href="/cookbook/5.0/Internationalization/FontDetection">Recipe Permalink</a>
<a class="btn btn-sm btn-success me-1" href="/cookbook/5.0/Internationalization">Category: Internationalization</a>
</div>

ScottPlot comes with font detection methods which help identify the best installed font for displaying text which may contain international characters.

[![](/cookbook/5.0/images/FontDetection.png?241031194635)](/cookbook/5.0/images/FontDetection.png?241031194635)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

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


