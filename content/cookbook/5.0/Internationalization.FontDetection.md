---
Title: Supported Font Detection - ScottPlot 5.0 Cookbook
Description: ScottPlot comes with font detection methods which help identify the best installed font for displaying text which may contain international characters.
URL: /cookbook/5.0/Internationalization/FontDetection/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Internationalization", "Supported Font Detection"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Internationalization", "/cookbook/5.0/Internationalization/FontDetection"]
Date: 2025-01-26
Version: ScottPlot 5.0.55
Version: ScottPlot 5.0.55
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Supported Font Detection</h1>
</div>

ScottPlot comes with font detection methods which help identify the best installed font for displaying text which may contain international characters.

[![](/cookbook/5.0/images/FontDetection.png?250126165944)](/cookbook/5.0/images/FontDetection.png?250126165944)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/Miscellaneous/Internationalization.cs" imageUrl="/cookbook/5.0/images/FontDetection.png?250126165944" >}}ScottPlot.Plot myPlot = new();

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

<div class='my-5 text-center'>This recipe is one of many in the <a href='/cookbook/5.0/Internationalization'>Internationalization</a> category</div>


