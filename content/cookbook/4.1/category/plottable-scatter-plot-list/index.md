---
Title: Scatter Plot List - ScottPlot 4.1 Cookbook
Description: Plottable - Scatter Plot List recipes
Source: https://github.com/ScottPlot/ScottPlot/tree/master/src/cookbook
---

## Scatter List Quickstart

This experimental plot type has add/remove/clear methods like typical lists.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] xs = { 1, 2, 3, 4 };
double[] ys = { 1, 4, 9, 16 };

var scatterList = plt.AddScatterList();
scatterList.AddRange(xs, ys);
scatterList.Add(5, 25);

plt.SaveFig("scatterList_quickstart.png");
```

<div class='text-center'>
<a href='../../images/scatterlist_quickstart.png'><img src='../../images/scatterlist_quickstart.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Scatter List Generic

This plot type supports generics.

```cs
var plt = new ScottPlot.Plot(600, 400);

int[] xs = { 1, 2, 3, 4 };
int[] ys = { 1, 4, 9, 16 };

var scatterList = plt.AddScatterList<int>();
scatterList.AddRange(xs, ys);
scatterList.Add(5, 25);

plt.SaveFig("scatterList_generic.png");
```

<div class='text-center'>
<a href='../../images/scatterlist_generic.png'><img src='../../images/scatterlist_generic.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Scatter List Draggable

There exists an experimental Scatter Plot List with draggable points.

```cs
var plt = new ScottPlot.Plot(600, 400);

double[] xs = ScottPlot.DataGen.Consecutive(51);
double[] ys = ScottPlot.DataGen.Sin(51);

var scatter = new ScottPlot.Plottable.ScatterPlotListDraggable();
scatter.AddRange(xs, ys);

plt.Add(scatter);

plt.SaveFig("scatterList_draggable.png");
```

<div class='text-center'>
<a href='../../images/scatterlist_draggable.png'><img src='../../images/scatterlist_draggable.png' /></a>
</div>


<div class='m-2'>&nbsp;</div>

## Scatter List Draggable Limits

A custom function can be used to limit the range of draggable points.

```cs
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
double[] xs = ScottPlot.DataGen.Consecutive(20);
double[] ys = ScottPlot.DataGen.Sin(20);
var scatter = new ScottPlot.Plottable.ScatterPlotListDraggable();
scatter.AddRange(xs, ys);
scatter.MarkerSize = 5;
plt.Add(scatter);

// use a custom function to limit the movement of points
static Coordinate MoveBetweenAdjacent(List<double> xs, List<double> ys, int index, Coordinate requested)
{
    int leftIndex = Math.Max(index - 1, 0);
    int rightIndex = Math.Min(index + 1, xs.Count - 1);

    double newX = requested.X;
    newX = Math.Max(newX, xs[leftIndex]);
    newX = Math.Min(newX, xs[rightIndex]);

    return new Coordinate(newX, requested.Y);
}

scatter.MovePointFunc = MoveBetweenAdjacent;

plt.SaveFig("scatterList_draggableLimits.png");
```

<div class='text-center'>
<a href='../../images/scatterlist_draggablelimits.png'><img src='../../images/scatterlist_draggablelimits.png' /></a>
</div>

