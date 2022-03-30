---
Title: Coxcomb - ScottPlot 4.1 Cookbook
Description: Plottable - Coxcomb recipes
Source: https://github.com/ScottPlot/ScottPlot/tree/master/src/cookbook
---

## Coxcomb Chart

A Pie chart where the angle of slices is constant but the radii are not.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 11, 16, 7, 3, 14 };
var coxcomb = plt.AddCoxcomb(values);
coxcomb.FillColors = plt.Palette.GetColors(5, 0, .5);
coxcomb.SliceLabels = new string[] { "bikes", "blimps", "subs", "saucers", "rockets" };

plt.SaveFig("coxcomb_quickstart.png");
```

<div class='text-center'>
<a href='../../images/coxcomb_quickstart.png'><img src='../../images/coxcomb_quickstart.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Coxcomb Chart with icons

A Pie chart where the angle of slices is constant but the radii are not, icons are used for quick reference.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 11, 16, 7, 3, 14 };
var coxcomb = plt.AddCoxcomb(values);
coxcomb.CategoryImages = CategoryImages;
coxcomb.FillColors = plt.Palette.GetColors(5, 0, .5);
plt.Legend();

plt.SaveFig("coxcomb_iconValue.png");
```

<div class='text-center'>
<a href='../../images/coxcomb_iconvalue.png'><img src='../../images/coxcomb_iconvalue.png' /></a>
</div>

