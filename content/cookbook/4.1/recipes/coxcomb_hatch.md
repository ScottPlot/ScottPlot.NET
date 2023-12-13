---
Title: "Custom Hatching (patterns) - ScottPlot 4.1 Cookbook"
Description: "Coxcomb charts allow custom hatching of their slices."
Date: 2023-12-13
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/coxcomb_hatch/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Coxcomb Chart", "Custom Hatching (patterns)"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-coxcomb", "/cookbook/4.1/recipes/coxcomb_hatch/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/coxcomb_hatch.png"
---

<h2><a id='custom-hatching-(patterns)' href='/cookbook/4.1/recipes/coxcomb_hatch/'>Custom Hatching (patterns)</a></h2>

Coxcomb charts allow custom hatching of their slices.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 11, 16, 7, 3, 14 };
var coxcomb = plt.AddCoxcomb(values);
coxcomb.HatchOptions = new HatchOptions[] {
    new () { Pattern = HatchStyle.StripedUpwardDiagonal, Color = Color.FromArgb(100, Color.Gray) },
    new () { Pattern = HatchStyle.StripedDownwardDiagonal, Color = Color.FromArgb(100, Color.Gray) },
    new () { Pattern = HatchStyle.LargeCheckerBoard, Color = Color.FromArgb(100, Color.Gray) },
    new () { Pattern = HatchStyle.SmallCheckerBoard, Color = Color.FromArgb(100, Color.Gray) },
    new () { Pattern = HatchStyle.LargeGrid, Color = Color.FromArgb(100, Color.Gray) },
};
coxcomb.OutlineWidth = 1;

coxcomb.SliceLabels = new string[] { "bikes", "blimps", "subs", "saucers", "rockets" };
plt.Legend();

plt.SaveFig("coxcomb_hatch.png");
```

<img src='../../images/coxcomb_hatch.png' class='d-block mx-auto my-5' />


