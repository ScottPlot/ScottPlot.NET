---
Title: "Customize Pie Hatching - ScottPlot 4.1 Cookbook"
Description: "Hatching (patterns) for pie slices and labels can be customized."
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/recipes/pie_customhatch/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Pie Chart", "Customize Pie Hatching"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-pie", "/cookbook/4.1/recipes/pie_customhatch/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/pie_customhatch.png"
---

<h2><a id='customize-pie-hatching' href='/cookbook/4.1/recipes/pie_customhatch/'>Customize Pie Hatching</a></h2>

Hatching (patterns) for pie slices and labels can be customized.

{{< code-sp4 >}}

```cs
ScottPlot.Version.ShouldBe(4, 1, 70);
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 778, 43, 283, 76, 184 };
string[] labels = { "C#", "JAVA", "Python", "F#", "PHP" };

var pie = plt.AddPie(values);
pie.HatchOptions = new HatchOptions[] {
    new () { Pattern = HatchStyle.StripedUpwardDiagonal, Color = Color.FromArgb(100, Color.Gray) },
    new () { Pattern = HatchStyle.StripedDownwardDiagonal, Color = Color.FromArgb(100, Color.Gray) },
    new () { Pattern = HatchStyle.LargeCheckerBoard, Color = Color.FromArgb(100, Color.Gray) },
    new () { Pattern = HatchStyle.SmallCheckerBoard, Color = Color.FromArgb(100, Color.Gray) },
    new () { Pattern = HatchStyle.LargeGrid, Color = Color.FromArgb(100, Color.Gray) },
};
pie.OutlineSize = 1;

pie.SliceLabels = labels;
plt.Legend();

plt.SaveFig("pie_customHatch.png");
```

{{< /code-sp4 >}}

<img src='../../images/pie_customhatch.png' class='d-block mx-auto my-5' />


