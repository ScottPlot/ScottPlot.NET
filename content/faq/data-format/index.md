---
Title: ScottPlot Data Formats - ScottPlot FAQ
Description: Why does ScottPlot prefer double[]? Can other data types be used?
---

# ScottPlot Data Formats

**ScottPlot is opinionated, and prefers data to be in `double[]` format.** We often receive suggestions and questions related to plotting data originating in other formats. This topic frequently surfaces in GitHub issues, discussions, and even pull requests (see links at the bottom of this page). 

This page summarizes the formats ScottPlot supports, justifies why these formats were chosen, and provides suggestions for users who want to plot data originating from other formats.

## Why ScottPlot Prefers `double[]`

**ScottPlot's primary goals are simplicity, performance, and maintainability,** and we find that requiring the user to provide data as `double[]` achieves the best balance between these priorities for most users.

Plotting often involves search algorithms to convert data coordinates to pixel locations. These algorithms are implemented using `double` for comparisons, and supporting more types would require duplicating these algorithms to support `double[]`, `float[]`, `long[]`, `int[]`, and `byte[]`, as well as duplicate plot types and Plot method overloads for every type. 

Generics could be used and search algorithms could compare `T`, but generics don't support operations (`+`, `-`, `<` etc.) so comparisons require `T.ConvertTo(double)` which greatly impairs performance of these critical search methods.

## How to Plot Other Data Types

You can quickly convert your iteratable data type to a double array using LINQ:

```cs
int[] originalData = { 5, 2, 7, 4, 9, 5 };
double[] myData = originalData.Select(x=>(double)x).ToArray();
```

## How to Plot `List` and `List<T>` Types

You can use LINQ to convert any numerical list type to a double array:

```cs
List<int> originalData = new List<int>() {5, 2, 7, 4, 9, 5};
double[] myData = originalData.Select(x=>(double)x).ToArray();
```

If your List is a `List<double>` you can do this even simpler:

```cs
List<double> originalData = new List<double>() {5, 2, 7, 4, 9, 5};
double[] myData = originalData.ToArray();
```

## SignalConst&lt;T&gt;

The `SignalConst` plot type pre-processes data so rendering performance is not negatively impacted by comparison of generic types. `AddSignalConst()` accepts any array type, so as long as its elements can be cast to double you can use this plot type to display data from types other than `double[]`.

```cs
int[] data = { 2, 6, 3, 8, 5, 6, 1, 9, 7 };
plt.AddSignalConst(data);
```

## ScatterPlotList

There are experimental plot types such as `ScatterPlotList` which use `List<T>` instead of `double[]` under the hood. These plot types have `Add()`, `RemoveAt()`, and `Clear()` methods, making them suitable for applications where the data type is not `double` and/or the number of data points is expected to change.

List-based plot types are experimental and are intentionally not documented in the cookbook at time. They can be found in the `ScottPlot.Plottable` namespace. To use them you can instantiate them with `new`, add them to the plot with `plt.Add()`, then interact with their methods to add and manipulate data.

```cs
// instantiate an experimental plot type and add it to the plot
var plt = new ScottPlot.Plot();
var experimental = new ScottPlot.Plottable.ScatterPlotList();
plt.Add(experimental);

// interact with the plot type using public methods
experimental.Add(x, y);
```

## Resources

### Relevant Conversations on GitHub
* https://github.com/ScottPlot/ScottPlot/issues/103 - using generic types for data
* https://github.com/ScottPlot/ScottPlot/issues/841 - using data objects for data
* https://github.com/ScottPlot/ScottPlot/pull/815 - using Lists for data
* https://github.com/ScottPlot/ScottPlot/discussions/766 - using Memory&lt;T&gt; and Span&lt;T&gt; for data