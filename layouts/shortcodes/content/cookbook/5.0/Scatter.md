---
Title: Scatter Plot - ScottPlot 5.0 Cookbook
Description: Scatter plots display points at X/Y locations in coordinate space.
URL: /cookbook/5.0/Scatter/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Scatter Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Scatter"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Scatter Plot</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot Quickstart</h1>
<a href='/cookbook/5.0/Scatter/ScatterQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Scatter plots can be created from two arrays containing X and Y values.

[![](/cookbook/5.0/images/ScatterQuickstart.png?250822231048)](/cookbook/5.0/images/ScatterQuickstart.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterQuickstart.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] xs = { 1, 2, 3, 4, 5 };
double[] ys = { 1, 4, 9, 16, 25 };

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot Coordinates</h1>
<a href='/cookbook/5.0/Scatter/ScatterCoordinates' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Scatter plots can be created from a collection of Coordinates.

[![](/cookbook/5.0/images/ScatterCoordinates.png?250822231048)](/cookbook/5.0/images/ScatterCoordinates.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterCoordinates.png?250822231048" >}}ScottPlot.Plot myPlot = new();

Coordinates[] coordinates =
{
    new(1, 1),
    new(2, 4),
    new(3, 9),
    new(4, 16),
    new(5, 25),
};

myPlot.Add.Scatter(coordinates);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot Data Type</h1>
<a href='/cookbook/5.0/Scatter/ScatterDataType' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Scatter plots can be created from any numeric data type, not just double.

[![](/cookbook/5.0/images/ScatterDataType.png?250822231048)](/cookbook/5.0/images/ScatterDataType.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterDataType.png?250822231048" >}}ScottPlot.Plot myPlot = new();

float[] xs = { 1, 2, 3, 4, 5 };
int[] ys = { 1, 4, 9, 16, 25 };

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot of List Data</h1>
<a href='/cookbook/5.0/Scatter/ScatterList' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Scatter plots can be created from Lists, but be very cafeful not to add or remove items while a render is occurring or you may throw an index exception. See documentation about the Render Lock system for details.

[![](/cookbook/5.0/images/ScatterList.png?250822231048)](/cookbook/5.0/images/ScatterList.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterList.png?250822231048" >}}ScottPlot.Plot myPlot = new();

List&lt;double&gt; xs = new() { 1, 2, 3, 4, 5 };
List&lt;double&gt; ys = new() { 1, 4, 9, 16, 25 };

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot with Lines Only</h1>
<a href='/cookbook/5.0/Scatter/ScatterLine' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The `ScatterLine()` method can be used to create a scatter plot with a line only (marker size is set to 0).

[![](/cookbook/5.0/images/ScatterLine.png?250822231048)](/cookbook/5.0/images/ScatterLine.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterLine.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] sin = Generate.Sin(51);
double[] cos = Generate.Cos(51);

myPlot.Add.ScatterLine(xs, sin);
myPlot.Add.ScatterLine(xs, cos);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot with Points Only</h1>
<a href='/cookbook/5.0/Scatter/ScatterPoints' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The `ScatterPoints()` method can be used to create a scatter plot with markers only (line width is set to 0).

[![](/cookbook/5.0/images/ScatterPoints.png?250822231048)](/cookbook/5.0/images/ScatterPoints.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterPoints.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] sin = Generate.Sin(51);
double[] cos = Generate.Cos(51);

myPlot.Add.ScatterPoints(xs, sin);
myPlot.Add.ScatterPoints(xs, cos);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot Styling</h1>
<a href='/cookbook/5.0/Scatter/ScatterStyling' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Scatter plots can be extensively styled by interacting with the object that is returned after a scatter plot is added. Assign text to a scatter plot's Label property to allow it to appear in the legend.

[![](/cookbook/5.0/images/ScatterStyling.png?250822231048)](/cookbook/5.0/images/ScatterStyling.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterStyling.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys1 = Generate.Sin(51);
double[] ys2 = Generate.Cos(51);

var sp1 = myPlot.Add.Scatter(xs, ys1);
sp1.LegendText = "Sine";
sp1.LineWidth = 3;
sp1.Color = Colors.Magenta;
sp1.MarkerSize = 15;

var sp2 = myPlot.Add.Scatter(xs, ys2);
sp2.LegendText = "Cosine";
sp2.LineWidth = 2;
sp2.Color = Colors.Green;
sp2.MarkerSize = 10;

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Line Patterns</h1>
<a href='/cookbook/5.0/Scatter/ScatterLinePatterns' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Several line patterns are available

[![](/cookbook/5.0/images/ScatterLinePatterns.png?250822231048)](/cookbook/5.0/images/ScatterLinePatterns.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterLinePatterns.png?250822231048" >}}ScottPlot.Plot myPlot = new();

List&lt;LinePattern&gt; patterns = [];
patterns.AddRange(LinePattern.GetAllPatterns());
patterns.Add(new([2, 2, 5, 10], 0, "Custom"));

ScottPlot.Palettes.ColorblindFriendly palette = new();

for (int i = 0; i &lt; patterns.Count; i++)
{
    double yOffset = patterns.Count - i;
    double[] xs = Generate.Consecutive(51);
    double[] ys = Generate.Sin(51, offset: yOffset);

    var sp = myPlot.Add.Scatter(xs, ys);
    sp.LineWidth = 2;
    sp.MarkerSize = 0;
    sp.LinePattern = patterns[i];
    sp.Color = palette.GetColor(i);

    var txt = myPlot.Add.Text(patterns[i].Name, 51, yOffset);
    txt.LabelFontColor = sp.Color;
    txt.LabelFontSize = 22;
    txt.LabelBold = true;
    txt.LabelAlignment = Alignment.MiddleLeft;
}

myPlot.Axes.Margins(.05, .5, .05, .05);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Generic</h1>
<a href='/cookbook/5.0/Scatter/ScatterGeneric' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Scatter plots support generic data types, although double is typically the most performant.

[![](/cookbook/5.0/images/ScatterGeneric.png?250822231048)](/cookbook/5.0/images/ScatterGeneric.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterGeneric.png?250822231048" >}}ScottPlot.Plot myPlot = new();

int[] xs = { 1, 2, 3, 4, 5 };
float[] ys = { 1, 4, 9, 16, 25 };

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter DateTime</h1>
<a href='/cookbook/5.0/Scatter/ScatterDateTime' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A scatter plot may use DateTime units but be sure to setup the respective axis to display using DateTime format.

[![](/cookbook/5.0/images/ScatterDateTime.png?250822231048)](/cookbook/5.0/images/ScatterDateTime.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterDateTime.png?250822231048" >}}ScottPlot.Plot myPlot = new();

DateTime[] xs = Generate.ConsecutiveDays(100);
double[] ys = Generate.RandomWalk(xs.Length);

myPlot.Add.Scatter(xs, ys);
myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Step Plot</h1>
<a href='/cookbook/5.0/Scatter/ScatterStep' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Scatter plots can be created using a step plot display where points are connected with right angles instead of diagnal lines. The direction of the steps can be customized.

[![](/cookbook/5.0/images/ScatterStep.png?250822231048)](/cookbook/5.0/images/ScatterStep.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterStep.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(20);
double[] ys1 = Generate.Consecutive(20, first: 10);
double[] ys2 = Generate.Consecutive(20, first: 5);
double[] ys3 = Generate.Consecutive(20, first: 0);

var sp1 = myPlot.Add.Scatter(xs, ys1);
sp1.ConnectStyle = ConnectStyle.Straight;
sp1.LegendText = "Straight";

var sp2 = myPlot.Add.Scatter(xs, ys2);
sp2.ConnectStyle = ConnectStyle.StepHorizontal;
sp2.LegendText = "StepHorizontal";

var sp3 = myPlot.Add.Scatter(xs, ys3);
sp3.ConnectStyle = ConnectStyle.StepVertical;
sp3.LegendText = "StepVertical";

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter with Gaps</h1>
<a href='/cookbook/5.0/Scatter/ScatterWithGaps' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

NaN values in a scatter plot's data will appear as gaps in the line.

[![](/cookbook/5.0/images/ScatterWithGaps.png?250822231048)](/cookbook/5.0/images/ScatterWithGaps.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterWithGaps.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

// long stretch of empty data
for (int i = 10; i &lt; 20; i++)
    ys[i] = double.NaN;

// single missing data point
ys[30] = double.NaN;

// single floating data point
for (int i = 35; i &lt; 40; i++)
    ys[i] = double.NaN;
for (int i = 40; i &lt; 45; i++)
    ys[i] = double.NaN;

myPlot.Add.Scatter(xs, ys);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot with Smooth Lines</h1>
<a href='/cookbook/5.0/Scatter/ScatterSmooth' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Scatter plots draw straight lines between points by default, but setting the Smooth property allows the scatter plot to connect points with smooth lines. Lines are smoothed using cubic spline interpolation.

[![](/cookbook/5.0/images/ScatterSmooth.png?250822231048)](/cookbook/5.0/images/ScatterSmooth.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterSmooth.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(10);
double[] ys = Generate.RandomSample(10, 5, 15);

var sp = myPlot.Add.Scatter(xs, ys);
sp.Smooth = true;
sp.LegendText = "Smooth";
sp.LineWidth = 2;
sp.MarkerSize = 10;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Smooth Line Tension</h1>
<a href='/cookbook/5.0/Scatter/ScatterSmoothTension' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Tension of smooth lines can be adjusted for some smoothing strategies. Low tensions lead to 'overshoot' and high tensions produce curveswhich appear more like straight lines.

[![](/cookbook/5.0/images/ScatterSmoothTension.png?250822231048)](/cookbook/5.0/images/ScatterSmoothTension.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterSmoothTension.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.RandomWalk(10);
double[] ys = Generate.RandomWalk(10);

var mk = myPlot.Add.Markers(xs, ys);
mk.MarkerShape = MarkerShape.OpenCircle;
mk.Color = Colors.Black;

double[] tensions = { 0.3, 0.5, 1.0, 3.0 };

foreach (double tension in tensions)
{
    var sp = myPlot.Add.ScatterLine(xs, ys);
    sp.Smooth = true;
    sp.SmoothTension = tension;
    sp.LegendText = $"Tension {tension}";
    sp.LineWidth = 2;
}

myPlot.ShowLegend(Alignment.UpperLeft);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Smooth Scatter without Overshoot</h1>
<a href='/cookbook/5.0/Scatter/ScatterQuad' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The quadratic half point path strategy allows scatter plots to be displayed with smooth lines connecting points, but lines are eased in and out of points so they never 'overshoot' the values vertically.

[![](/cookbook/5.0/images/ScatterQuad.png?250822231048)](/cookbook/5.0/images/ScatterQuad.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterQuad.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(10);
double[] ys = Generate.RandomSample(10, 5, 15);

var sp = myPlot.Add.Scatter(xs, ys);
sp.PathStrategy = new ScottPlot.PathStrategies.QuadHalfPoint();
sp.LegendText = "Smooth";
sp.LineWidth = 2;
sp.MarkerSize = 10;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Limiting Display with Render Indexes</h1>
<a href='/cookbook/5.0/Scatter/ScatterLimitIndex' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Although a scatter plot may contain a very large amount of data, much of it may be unpopulated. The user can define min and max render indexes, and only values within that range will be displayed when the scatter plot is rendered.

[![](/cookbook/5.0/images/ScatterLimitIndex.png?250822231048)](/cookbook/5.0/images/ScatterLimitIndex.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterLimitIndex.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var sp = myPlot.Add.Scatter(xs, ys);
sp.MinRenderIndex = 10;
sp.MaxRenderIndex = 40;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot with Fill</h1>
<a href='/cookbook/5.0/Scatter/ScatterFill' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The area beneath a scatter plot can be filled.

[![](/cookbook/5.0/images/ScatterFill.png?250822231048)](/cookbook/5.0/images/ScatterFill.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterFill.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var sp = myPlot.Add.Scatter(xs, ys);
sp.FillY = true;
sp.FillYColor = sp.Color.WithAlpha(.2);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot Filled to a Value</h1>
<a href='/cookbook/5.0/Scatter/ScatterFillValue' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The base of the fill can be defined.

[![](/cookbook/5.0/images/ScatterFillValue.png?250822231048)](/cookbook/5.0/images/ScatterFillValue.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterFillValue.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var sp = myPlot.Add.Scatter(xs, ys);
sp.FillY = true;
sp.FillYColor = sp.Color.WithAlpha(.2);
sp.FillYValue = 0.6;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot Filled Above and Below</h1>
<a href='/cookbook/5.0/Scatter/ScatterFillAboveBelow' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Filled areas above and below the FillY value can be individually customized

[![](/cookbook/5.0/images/ScatterFillAboveBelow.png?250822231048)](/cookbook/5.0/images/ScatterFillAboveBelow.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterFillAboveBelow.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var sp = myPlot.Add.Scatter(xs, ys);
sp.FillY = true;
sp.FillYValue = 0;
sp.FillYAboveColor = Colors.Green.WithAlpha(.2);
sp.FillYBelowColor = Colors.Red.WithAlpha(.2);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot with Gradient Fill</h1>
<a href='/cookbook/5.0/Scatter/ScatterFillGradient' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The area beneath a scatter plot can be filled with a custom gradient of colors.

[![](/cookbook/5.0/images/ScatterFillGradient.png?250822231048)](/cookbook/5.0/images/ScatterFillGradient.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterFillGradient.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var poly = myPlot.Add.ScatterLine(xs, ys);
poly.FillY = true;

// colors are placed at specific positions on the X axis
poly.AxisGradientDirection = AxisGradientDirection.Horizontal;
poly.ColorPositions.Add(new(Colors.Red, 0));
poly.ColorPositions.Add(new(Colors.Orange, 10));
poly.ColorPositions.Add(new(Colors.Yellow, 20));
poly.ColorPositions.Add(new(Colors.Green, 30));
poly.ColorPositions.Add(new(Colors.Blue, 40));
poly.ColorPositions.Add(new(Colors.Violet, 50));

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Plot with Vertical Gradient</h1>
<a href='/cookbook/5.0/Scatter/ScatterFillGradientVertical' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Scatter plots may be filled with vertical gradients.

[![](/cookbook/5.0/images/ScatterFillGradientVertical.png?250822231048)](/cookbook/5.0/images/ScatterFillGradientVertical.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterFillGradientVertical.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);

var poly = myPlot.Add.ScatterLine(xs, ys);
poly.FillY = true;

// colors are placed at specific positions on the Y axis
poly.AxisGradientDirection = AxisGradientDirection.Vertical;
poly.ColorPositions.Add(new(Colors.Red, -1));
poly.ColorPositions.Add(new(Colors.Blue, 0));
poly.ColorPositions.Add(new(Colors.Orange, .5));
poly.ColorPositions.Add(new(Colors.Magenta, 1));

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Scatter Scale and Offset</h1>
<a href='/cookbook/5.0/Scatter/ScatterScaleAndOffset' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Scatter plot points can be multiplied by custom X and Y scale factors, or shifted horizontally or vertically using X and Y offset values.

[![](/cookbook/5.0/images/ScatterScaleAndOffset.png?250822231048)](/cookbook/5.0/images/ScatterScaleAndOffset.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterScaleAndOffset.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] xs = Generate.Consecutive(51);
double[] ys = Generate.Sin(51);
var sp = myPlot.Add.Scatter(xs, ys);
sp.ScaleX = 100;
sp.ScaleY = 10;
sp.OffsetX = 500;
sp.OffsetY = 5;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Stacked Filled Line Plot</h1>
<a href='/cookbook/5.0/Scatter/StackedFilledLinePlot' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A stacked filled line plot effect can be achieved by overlapping ScatterLines that fill area.

[![](/cookbook/5.0/images/StackedFilledLinePlot.png?250822231048)](/cookbook/5.0/images/StackedFilledLinePlot.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/StackedFilledLinePlot.png?250822231048" >}}ScottPlot.Plot myPlot = new();

// create sample data
double[] xs = { 1, 2, 3, 4 };
double[] ys1 = { 1, 3, 1, 2 };
double[] ys2 = { 3, 7, 3, 1 };
double[] ys3 = { 5, 2, 5, 6 };

// shift each plot vertically by the sum of all plots before it
ys2 = Enumerable.Range(0, ys2.Length).Select(x =&gt; ys2[x] + ys1[x]).ToArray();
ys3 = Enumerable.Range(0, ys2.Length).Select(x =&gt; ys3[x] + ys2[x]).ToArray();

// plot the padded data points as ScatterLine
var sp3 = myPlot.Add.ScatterLine(xs, ys3, Colors.Black);
var sp2 = myPlot.Add.ScatterLine(xs, ys2, Colors.Black);
var sp1 = myPlot.Add.ScatterLine(xs, ys1, Colors.Black);

// set plot style
sp1.LineWidth = 2;
sp2.LineWidth = 2;
sp3.LineWidth = 2;
sp1.FillY = true;
sp2.FillY = true;
sp3.FillY = true;
sp1.FillYColor = Colors.Green;
sp2.FillYColor = Colors.Orange;
sp3.FillYColor = Colors.Blue;

// use tight margins so data goes to the edge of the plot
myPlot.Axes.Margins(0, 0, 0, 0.1);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Stacked Scatter with Shading</h1>
<a href='/cookbook/5.0/Scatter/ScatterStackedShading' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Demonstrates how to combine filled scatter plots with vertical and horizontal offsets to achieve an interesting visual effect.

[![](/cookbook/5.0/images/ScatterStackedShading.png?250822231048)](/cookbook/5.0/images/ScatterStackedShading.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Scatter.cs" imageUrl="/cookbook/5.0/images/ScatterStackedShading.png?250822231048" >}}ScottPlot.Plot myPlot = new();

double[] xs = ScottPlot.Generate.Consecutive(100);
ScottPlot.Colormaps.MellowRainbow cmap = new();

for (int i = 0; i &lt; 10; i++)
{
    double yOffset = 9 - i * 0.5;
    double[] ys = Generate.Sigmoidal(xs.Length)
        .Select(y =&gt; y + yOffset)
        .ToArray();

    Generate.AddNoiseInPlace(ys, 0.1);

    var sig = myPlot.Add.ScatterLine(xs, ys);
    sig.LineColor = Colors.Black;
    sig.LineWidth = 1.5f;
    sig.FillY = true;
    sig.FillYValue = yOffset;
    sig.FillYAboveColor = cmap.GetColor(i, 10);
}

myPlot.HideGrid();
myPlot.Axes.MarginsX(0);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


