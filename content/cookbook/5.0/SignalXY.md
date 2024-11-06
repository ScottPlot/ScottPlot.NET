---
Title: SignalXY Plot - ScottPlot 5.0 Cookbook
Description: SignalXY are a high performance plot type optimized for X/Y pairs where the X values are always ascending. For large datasets SignalXY plots are much more performant than Scatter plots (which allow unordered X points) but not as performant as Signal plots (which require fixed spacing between X points).
URL: /cookbook/5.0/SignalXY/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "SignalXY Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/SignalXY"]
Date: 2024-11-06
Version: ScottPlot 5.0.43
Version: ScottPlot 5.0.43
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>SignalXY Plot</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SignalXY Quickstart</h1>
<a href='/cookbook/5.0/SignalXY/SignalXYQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

SignalXY plots are a high performance plot type for X/Y data where the X values are always ascending.

[![](/cookbook/5.0/images/SignalXYQuickstart.png?241105214550)](/cookbook/5.0/images/SignalXYQuickstart.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5.0/images/SignalXYQuickstart.png?241105214550" >}}ScottPlot.Plot myPlot = new();

// generate sample data with gaps
List&lt;double&gt; xList = new();
List&lt;double&gt; yList = new();
for (int i = 0; i &lt; 5; i++)
{
    xList.AddRange(Generate.Consecutive(1000, first: 2000 * i));
    yList.AddRange(Generate.RandomSample(1000));
}
double[] xs = xList.ToArray();
double[] ys = yList.ToArray();

// add a SignalXY plot
myPlot.Add.SignalXY(xs, ys);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SignalXY Generic</h1>
<a href='/cookbook/5.0/SignalXY/SignalXYGeneric' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

SignalXY plots support generic data types, although double is typically the most performant.

[![](/cookbook/5.0/images/SignalXYGeneric.png?241105214550)](/cookbook/5.0/images/SignalXYGeneric.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5.0/images/SignalXYGeneric.png?241105214550" >}}ScottPlot.Plot myPlot = new();

// generate sample data with gaps
List&lt;int&gt; xList = new();
List&lt;float&gt; yList = new();
for (int i = 0; i &lt; 5; i++)
{
    xList.AddRange(Generate.Consecutive(1000, first: 2000 * i).Select(x =&gt; (int)x));
    yList.AddRange(Generate.RandomSample(1000).Select(x =&gt; (float)x));
}
int[] xs = xList.ToArray();
float[] ys = yList.ToArray();

// add a SignalXY plot
myPlot.Add.SignalXY(xs, ys);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SignalXY DateTime Axis</h1>
<a href='/cookbook/5.0/SignalXY/SignalXYDateTime' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

SignalXY plots can display unevenly spaced time series data using a DateTime horizontal axis.

[![](/cookbook/5.0/images/SignalXYDateTime.png?241105214550)](/cookbook/5.0/images/SignalXYDateTime.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5.0/images/SignalXYDateTime.png?241105214550" >}}ScottPlot.Plot myPlot = new();

DateTime start = new(2024, 01, 01);
DateTime[] xs = Generate.ConsecutiveDays(100, start);

double[] ys = Generate.RandomWalk(100);

myPlot.Add.SignalXY(xs, ys);
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Partial SignalXY Rendering</h1>
<a href='/cookbook/5.0/SignalXY/SignalXYRenderIndexes' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Even if a SignalXY plot references a large array of data, rendering can be limited to a range of values. If set,only the range of data between the minimum and maximum render indexes will be displayed.

[![](/cookbook/5.0/images/SignalXYRenderIndexes.png?241105214550)](/cookbook/5.0/images/SignalXYRenderIndexes.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5.0/images/SignalXYRenderIndexes.png?241105214550" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(1000);
double[] ys = Generate.RandomWalk(1000);

var sigAll = myPlot.Add.SignalXY(xs, ys);
sigAll.LegendText = "Full";
sigAll.Data.YOffset = 80;

var sigLeft = myPlot.Add.SignalXY(xs, ys);
sigLeft.LegendText = "Left";
sigLeft.Data.YOffset = 60;
sigLeft.Data.MaximumIndex = 700;

var sigRight = myPlot.Add.SignalXY(xs, ys);
sigRight.LegendText = "Right";
sigRight.Data.YOffset = 40;
sigRight.Data.MinimumIndex = 300;

var sigMid = myPlot.Add.SignalXY(xs, ys);
sigMid.LegendText = "Mid";
sigMid.Data.YOffset = 20;
sigMid.Data.MinimumIndex = 300;
sigMid.Data.MaximumIndex = 700;

myPlot.ShowLegend(Alignment.UpperRight);
myPlot.Axes.Margins(top: .5);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SignalXY Offset</h1>
<a href='/cookbook/5.0/SignalXY/SignalXYOffset' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A fixed offset can be applied to SignalXY plots.

[![](/cookbook/5.0/images/SignalXYOffset.png?241105214550)](/cookbook/5.0/images/SignalXYOffset.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5.0/images/SignalXYOffset.png?241105214550" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(1000);
double[] ys = Generate.Sin(1000);

var sig1 = myPlot.Add.SignalXY(xs, ys);

var sig2 = myPlot.Add.SignalXY(xs, ys);
sig2.Data.XOffset = 250;
sig2.Data.YOffset = .5;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SignalXY Scaling</h1>
<a href='/cookbook/5.0/SignalXY/SignalXYOffsetScaleY' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

SignalXY plots can be scaled vertically according to a user-defined amount.

[![](/cookbook/5.0/images/SignalXYOffsetScaleY.png?241105214550)](/cookbook/5.0/images/SignalXYOffsetScaleY.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5.0/images/SignalXYOffsetScaleY.png?241105214550" >}}ScottPlot.Plot myPlot = new();

// plot values between -1 and 1
double[] values = ScottPlot.Generate.Sin(51);
double[] xs = ScottPlot.Generate.Consecutive(51);
var signalXY = myPlot.Add.SignalXY(xs, values);

// increase the vertical scaling
signalXY.Data.YScale = 500;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Vertical SignalXY</h1>
<a href='/cookbook/5.0/SignalXY/VerticalSignalXY' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Although SignalXY plots typically display data left-to-right, it is possible to use this plot type to display data bottom-to-top.

[![](/cookbook/5.0/images/VerticalSignalXY.png?241105214550)](/cookbook/5.0/images/VerticalSignalXY.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5.0/images/VerticalSignalXY.png?241105214550" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(1000);
double[] ys = Generate.RandomWalk(1000);

var sig1 = myPlot.Add.SignalXY(xs, ys);
sig1.Data.Rotated = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Vertical SignalXY with Inverted X Axis</h1>
<a href='/cookbook/5.0/SignalXY/SignalXYVerticalInvertedX' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Demonstrates how to display a rotated SignalXY plot (so it goes from bottom to top) which is also displayed on an inverted horizontal axis (where positive values are on the left).

[![](/cookbook/5.0/images/SignalXYVerticalInvertedX.png?241105214550)](/cookbook/5.0/images/SignalXYVerticalInvertedX.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5.0/images/SignalXYVerticalInvertedX.png?241105214550" >}}ScottPlot.Plot myPlot = new();

// add a signal plot
double[] xs = Generate.Consecutive(5_000);
double[] ys = Generate.Sin(count: xs.Length, oscillations: 4);

// rotate it so it is vertical
var signal = myPlot.Add.SignalXY(xs, ys);
signal.Data.Rotated = true;

// invert the horizontal axis
myPlot.Axes.SetLimitsX(1, -1);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Vertical SignalXY with Inverted Y Axis</h1>
<a href='/cookbook/5.0/SignalXY/SignalXYVerticalInvertedY' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Demonstrates how to display a rotated SignalXY plot on an inverted vertical axis so data goes from top to bottom.

[![](/cookbook/5.0/images/SignalXYVerticalInvertedY.png?241105214550)](/cookbook/5.0/images/SignalXYVerticalInvertedY.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5.0/images/SignalXYVerticalInvertedY.png?241105214550" >}}ScottPlot.Plot myPlot = new();

// add a signal plot
double[] xs = Generate.Consecutive(5_000);
double[] ys = Generate.Sin(count: xs.Length, oscillations: 4);

// rotate it so it is vertical
var signal = myPlot.Add.SignalXY(xs, ys);
signal.Data.Rotated = true;

// invert the vertical axis
myPlot.Axes.SetLimitsY(5000, 0);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>SignalXY with Markers</h1>
<a href='/cookbook/5.0/SignalXY/SignalXYMarkers' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Users can enable a marker to be displayedat each data point. However, this can reduce performance for extremely large datasets.

[![](/cookbook/5.0/images/SignalXYMarkers.png?241105214550)](/cookbook/5.0/images/SignalXYMarkers.png?241105214550)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/SignalXY.cs" imageUrl="/cookbook/5.0/images/SignalXYMarkers.png?241105214550" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var sig = myPlot.Add.SignalXY(xs, ys);
sig.MarkerStyle.Shape = MarkerShape.FilledCircle;
sig.MarkerStyle.Size = 5;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


