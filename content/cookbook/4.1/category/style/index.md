---
Title: Style - ScottPlot 4.1 Cookbook
Description: Style recipes
Source: https://github.com/ScottPlot/ScottPlot/tree/master/src/cookbook
---

## Default Style

Customize many plot features using style presets

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.Style(Style.Default);
plt.Title("Style.Default");
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

plt.SaveFig("style_Default.png");
```

<div class='text-center'>
<a href='../../images/style_default.png'><img src='../../images/style_default.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Monospace Style

Customize many plot features using style presets

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.Style(Style.Monospace);
plt.Title("Style.Monospace");
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

plt.SaveFig("style_monospace.png");
```

<div class='text-center'>
<a href='../../images/style_monospace.png'><img src='../../images/style_monospace.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Blue1 Style

Customize many plot features using style presets

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.Style(Style.Blue1);
plt.Title("Style.Blue1");
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

plt.SaveFig("style_blue1.png");
```

<div class='text-center'>
<a href='../../images/style_blue1.png'><img src='../../images/style_blue1.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Blue2 Style

Customize many plot features using style presets

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.Style(Style.Blue2);
plt.Title("Style.Blue2");
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

plt.SaveFig("style_blue2.png");
```

<div class='text-center'>
<a href='../../images/style_blue2.png'><img src='../../images/style_blue2.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Light1 Style

Customize many plot features using style presets

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.Style(Style.Light1);
plt.Title("Style.Light1");
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

plt.SaveFig("style_light1.png");
```

<div class='text-center'>
<a href='../../images/style_light1.png'><img src='../../images/style_light1.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Gray1 Style

Customize many plot features using style presets

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.Style(Style.Gray1);
plt.Title("Style.Gray1");
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

plt.SaveFig("style_Gray1.png");
```

<div class='text-center'>
<a href='../../images/style_gray1.png'><img src='../../images/style_gray1.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Black Style

Customize many plot features using style presets

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.Style(Style.Black);
plt.Title("Style.Black");
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

plt.SaveFig("style_Black.png");
```

<div class='text-center'>
<a href='../../images/style_black.png'><img src='../../images/style_black.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Seaborn Style

Customize many plot features using style presets

```cs
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.Style(Style.Seaborn);
plt.Title("Style.Seaborn");
plt.XLabel("Horizontal Axis");
plt.YLabel("Vertical Axis");

plt.SaveFig("style_Seaborn.png");
```

<div class='text-center'>
<a href='../../images/style_seaborn.png'><img src='../../images/style_seaborn.png' /></a>
</div>

