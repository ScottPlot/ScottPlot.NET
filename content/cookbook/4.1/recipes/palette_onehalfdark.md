---
Title: "OneHalfDark - ScottPlot 4.1 Cookbook"
Description: "OneHalfDark is a 7-color palette of colors complimentary to the OneHalf palette desaturated and optimized for a dark background. #2e3440 is a recommended background color with this palette."
Date: 2024-01-21
Version: ScottPlot 4.1.71
URL: /cookbook/4.1/recipes/palette_onehalfdark/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Palette", "OneHalfDark"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/palette", "/cookbook/4.1/recipes/palette_onehalfdark/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/palette_onehalfdark.png"
---

<h2><a id='onehalfdark' href='/cookbook/4.1/recipes/palette_onehalfdark/'>OneHalfDark</a></h2>

OneHalfDark is a 7-color palette of colors complimentary to the OneHalf palette desaturated and optimized for a dark background. #2e3440 is a recommended background color with this palette.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 71);
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

{{< /code-sp4 >}}

<img src='../../images/palette_onehalfdark.png' class='d-block mx-auto my-5' />


