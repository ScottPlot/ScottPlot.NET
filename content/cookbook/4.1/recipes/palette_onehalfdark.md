---
Title: "OneHalfDark - ScottPlot 4.1 Cookbook"
Description: "OneHalfDark is a 7-color palette of colors complimentary to the OneHalf palette desaturated and optimized for a dark background. #2e3440 is a recommended background color with this palette."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/palette_onehalfdark/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Palette", "OneHalfDark"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/palette", "/cookbook/4.1/recipes/palette_onehalfdark/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/palette_onehalfdark.png"
---

<h2><a href='/cookbook/4.1/recipes/palette_onehalfdark/'>OneHalfDark</a></h2>

OneHalfDark is a 7-color palette of colors complimentary to the OneHalf palette desaturated and optimized for a dark background. #2e3440 is a recommended background color with this palette.

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.Palette = ScottPlot.Palette.OneHalfDark;

for (int i = 0; i < plt.Palette.Count(); i++)
{
    double[] xs = DataGen.Consecutive(100);
    double[] ys = DataGen.Sin(100, phase: -i * .5 / plt.Palette.Count());
    plt.AddScatterLines(xs, ys, lineWidth: 3);
}

plt.Title($"{plt.Palette}");
plt.AxisAuto(0, 0.1);
plt.Style(ScottPlot.Style.Gray1);
var bnColor = System.Drawing.ColorTranslator.FromHtml("#2e3440");
plt.Style(figureBackground: bnColor, dataBackground: bnColor);

plt.SaveFig("palette_OneHalfDark.png");
```

<img src='../../images/palette_onehalfdark.png' class='d-block mx-auto my-5' />


