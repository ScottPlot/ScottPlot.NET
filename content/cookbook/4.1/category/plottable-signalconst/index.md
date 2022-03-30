---
Title: SignalConst - ScottPlot 4.1 Cookbook
Description: Plottable - SignalConst recipes
Source: https://github.com/ScottPlot/ScottPlot/tree/master/src/cookbook
---

## SignalConst Quickstart

SignalConst plots pre-processes data to render much faster than Signal plots. Pre-processing takes a little time up-front and requires 4x the memory of Signal.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] values = DataGen.RandomWalk(1_000_000);
plt.AddSignalConst(values);
plt.Title("One Million Points");
plt.Benchmark();

plt.SaveFig("signalconst_quickstart.png");
```

<div class='text-center'>
<a href='../../images/signalconst_quickstart.png'><img src='../../images/signalconst_quickstart.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Generic Data Type

SignalConst supports other data types beyond just double arrays. You can use this plot type to display data in any numerical format that can be cast to a double.

```cs
var plt = new ScottPlot.Plot(600, 400);

int[] data = { 2, 6, 3, 8, 5, 6, 1, 9, 7 };
plt.AddSignalConst(data);
plt.Title("SignalConst Displaying int[] Data");

plt.SaveFig("signalconst_generic.png");
```

<div class='text-center'>
<a href='../../images/signalconst_generic.png'><img src='../../images/signalconst_generic.png' /></a>
</div>

