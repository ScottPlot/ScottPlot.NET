---
Title: "NaN Values Break the Line - ScottPlot 4.1 Cookbook"
Description: "When the OnNaN field is set to Gap, points containing NaN X or Y values break the line. This results in a scatter plot appearing as multiple lines, with gaps representing missing data."
Date: 12/11/2023 7:52:02 PM
Version: ScottPlot 4.1.69
URL: /cookbook/4.1/recipes/scatter_nan_gap/
BreadcrumbNames: ["ScottPlot 4.1 Cookbook", "Scatter Plot", "NaN Values Break the Line"]
BreadcrumbUrls: ["/cookbook/4.1/", "/cookbook/4.1/category/plottable-scatter-plot", "/cookbook/4.1/recipes/scatter_nan_gap/"]
SearchUrl: "/cookbook/4.1/search/"
OgImage: "/cookbook/4.1/images/scatter_nan_gap.png"
---

<h2><a href='/cookbook/4.1/recipes/scatter_nan_gap/'>NaN Values Break the Line</a></h2>

When the OnNaN field is set to Gap, points containing NaN X or Y values break the line. This results in a scatter plot appearing as multiple lines, with gaps representing missing data.

```cs
var plt = new ScottPlot.Plot(600, 400);

// create data that does NOT contain NaN
double[] xs = ScottPlot.DataGen.Consecutive(51);
double[] ys = ScottPlot.DataGen.Sin(51);

// plot it the traditional way
plt.AddScatter(xs, ys, Color.FromArgb(50, Color.Black));

// create new data that contains NaN
double[] ysWithNan = ScottPlot.DataGen.Sin(51);
static void FillWithNan(double[] values, int start, int count)
{
    for (int i = 0; i < count; i++)
        values[start + i] = double.NaN;
}
FillWithNan(ysWithNan, 5, 15);
FillWithNan(ysWithNan, 25, 1);
FillWithNan(ysWithNan, 30, 15);
ysWithNan[10] = ys[10];

// add a scatter plot and customize NaN behavior
var sp2 = plt.AddScatter(xs, ysWithNan, Color.Black);
sp2.OnNaN = ScottPlot.Plottable.ScatterPlot.NanBehavior.Gap;
plt.Title($"OnNaN = {sp2.OnNaN}");

plt.SaveFig("scatter_nan_gap.png");
```

<img src='../../images/scatter_nan_gap.png' class='d-block mx-auto my-5' />


