---
Title: Scale Bar - ScottPlot 4.1 Cookbook
Description: Plottable - Scale Bar recipes
Source: https://github.com/ScottPlot/ScottPlot/tree/master/src/cookbook
---

## Scale Bar

An L-shaped scalebar can be added in the corner of any plot. Set the vertical or horizontal sizer to zero and the scale bar will only span one dimension.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// remove traditional scale indicators
plt.Grid(enable: false);
plt.Frameless();

// add an L-shaped scalebar
plt.AddScaleBar(5, .25, "100 ms", "250 mV");

plt.SaveFig("scalebar_quickstart.png");
```

<div class='text-center'>
<a href='../../images/scalebar_quickstart.png'><img src='../../images/scalebar_quickstart.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Horizontal Scale Bar

Set the vertical or horizontal sizer to zero and the scale bar will only span one dimension.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot sample data 
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// show only the left axis
plt.XAxis.Hide();
plt.XAxis2.Hide();
plt.YAxis2.Hide();
plt.Grid(enable: false);

// add a horizontal scale bar (no Y height)
plt.AddScaleBar(5, 0, "100 ms", null);

plt.SaveFig("scalebar_horizontal.png");
```

<div class='text-center'>
<a href='../../images/scalebar_horizontal.png'><img src='../../images/scalebar_horizontal.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Styled Scale Bar

An L-shaped scalebar can be added in the corner of any plot. Set the vertical or horizontal sizer to zero and the scale bar will only span one dimension.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// remove traditional scale indicators
plt.Grid(enable: false);
plt.Frameless();

// add an L-shaped scalebar
plt.AddScaleBar(5, .25, "100 ms", "250 mV");

// add style
plt.Style(Style.Black);

plt.SaveFig("scalebar_styled.png");
```

<div class='text-center'>
<a href='../../images/scalebar_styled.png'><img src='../../images/scalebar_styled.png' /></a>
</div>

