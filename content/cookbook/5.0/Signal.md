---
Title: Signal Plot - ScottPlot 5.0 Cookbook
Description: Signal plots display evenly-spaced data
URL: /cookbook/5.0/Signal/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Signal Plot"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Signal"]
Date: 2024-11-02
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Signal Plot</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Signal Plot Quickstart</h1>
<a href='/cookbook/5.0/Signal/SignalQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Signal plots are best for extremely large datasets. They use render using special optimizations that allow highspeed interactivity with plots containing millions of data points.

[![](/cookbook/5.0/images/SignalQuickstart.png?241102170938)](/cookbook/5.0/images/SignalQuickstart.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Signal.cs" imageUrl="/cookbook/5.0/images/SignalQuickstart.png?241102170938" >}}ScottPlot.Plot myPlot = new();

double[] values = Generate.RandomWalk(1_000_000);

myPlot.Add.Signal(values);

myPlot.Title("Signal Plot with 1 Million Points");

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Signal Plot Styling</h1>
<a href='/cookbook/5.0/Signal/SignalStyling' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Signal plots can be styled in a variety of ways.

[![](/cookbook/5.0/images/SignalStyling.png?241102170938)](/cookbook/5.0/images/SignalStyling.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Signal.cs" imageUrl="/cookbook/5.0/images/SignalStyling.png?241102170938" >}}ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin());
sig1.Color = Colors.Magenta;
sig1.LineWidth = 10;
sig1.LegendText = "Sine";

var sig2 = myPlot.Add.Signal(Generate.Cos());
sig2.Color = Colors.Green;
sig2.LineWidth = 5;
sig2.LegendText = "Cosine";

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Signal Offset</h1>
<a href='/cookbook/5.0/Signal/SignalOffset' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Signal plots can be offset by a given X and Y value.

[![](/cookbook/5.0/images/SignalOffset.png?241102170938)](/cookbook/5.0/images/SignalOffset.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Signal.cs" imageUrl="/cookbook/5.0/images/SignalOffset.png?241102170938" >}}ScottPlot.Plot myPlot = new();

double[] values = ScottPlot.Generate.Sin(51);

var sig1 = myPlot.Add.Signal(values);
sig1.LegendText = "Default";

var sig2 = myPlot.Add.Signal(values);
sig2.Data.XOffset = 10;
sig2.Data.YOffset = .25;
sig2.LegendText = "Offset";

myPlot.Legend.IsVisible = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Signal Scaling</h1>
<a href='/cookbook/5.0/Signal/SignalScaleY' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Signal plots can be scaled vertically according to a user-defined amount.

[![](/cookbook/5.0/images/SignalScaleY.png?241102170938)](/cookbook/5.0/images/SignalScaleY.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Signal.cs" imageUrl="/cookbook/5.0/images/SignalScaleY.png?241102170938" >}}ScottPlot.Plot myPlot = new();

// plot values between -1 and 1
double[] values = ScottPlot.Generate.Sin(51);
var signal = myPlot.Add.Signal(values);

// increase the vertical scaling
signal.Data.YScale = 500;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Signal Marker Size</h1>
<a href='/cookbook/5.0/Signal/SignalMarkerSize' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Signal plots can have markers displayed at each point which are only visible when the plot is zoomed in.

[![](/cookbook/5.0/images/SignalMarkerSize.png?241102170938)](/cookbook/5.0/images/SignalMarkerSize.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Signal.cs" imageUrl="/cookbook/5.0/images/SignalMarkerSize.png?241102170938" >}}ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Cos());
sig1.LegendText = "Default";
sig1.Data.YOffset = 3;

var sig2 = myPlot.Add.Signal(Generate.Cos());
sig2.LegendText = "Large Markers";
sig2.MaximumMarkerSize = 20;
sig2.Data.YOffset = 2;

var sig3 = myPlot.Add.Signal(Generate.Cos());
sig3.LegendText = "Hidden Markers";
sig3.MaximumMarkerSize = 0;
sig3.Data.YOffset = 1;

myPlot.Legend.IsVisible = true;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Partial Signal Rendering</h1>
<a href='/cookbook/5.0/Signal/SignalRenderIndexes' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Even if a signal plot references a large array of data, rendering can be limited to a range of values. If set,only the range of data between the minimum and maximum render indexes will be displayed.

[![](/cookbook/5.0/images/SignalRenderIndexes.png?241102170938)](/cookbook/5.0/images/SignalRenderIndexes.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Signal.cs" imageUrl="/cookbook/5.0/images/SignalRenderIndexes.png?241102170938" >}}ScottPlot.Plot myPlot = new();

double[] values = Generate.RandomWalk(1000);

var sigAll = myPlot.Add.Signal(values);
sigAll.LegendText = "Full";
sigAll.Data.YOffset = 80;

var sigLeft = myPlot.Add.Signal(values);
sigLeft.LegendText = "Left";
sigLeft.Data.YOffset = 60;
sigLeft.Data.MaximumIndex = 700;

var sigRight = myPlot.Add.Signal(values);
sigRight.LegendText = "Right";
sigRight.Data.YOffset = 40;
sigRight.Data.MinimumIndex = 300;

var sigMid = myPlot.Add.Signal(values);
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
<h1 class='me-2 text-dark my-0 border-0'>Signal Generic</h1>
<a href='/cookbook/5.0/Signal/SignalGeneric' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Signal plots support generic data types, although double is typically the most performant.

[![](/cookbook/5.0/images/SignalGeneric.png?241102170938)](/cookbook/5.0/images/SignalGeneric.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Signal.cs" imageUrl="/cookbook/5.0/images/SignalGeneric.png?241102170938" >}}ScottPlot.Plot myPlot = new();

int[] values = Generate.RandomIntegers(1000, -100, 100);

myPlot.Add.Signal(values);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Signal DateTime</h1>
<a href='/cookbook/5.0/Signal/SignalDateTime' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A signal plot may use DateTime units but be sure to setup the respective axis to display using DateTime format.

[![](/cookbook/5.0/images/SignalDateTime.png?241102170938)](/cookbook/5.0/images/SignalDateTime.png?241102170938)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/PlotTypes/Signal.cs" imageUrl="/cookbook/5.0/images/SignalDateTime.png?241102170938" >}}ScottPlot.Plot myPlot = new();

DateTime start = new(2024, 1, 1);
double[] ys = Generate.RandomWalk(200);

var sig = myPlot.Add.Signal(ys);
sig.Data.XOffset = start.ToOADate();
sig.Data.Period = 1.0; // one day between each point

myPlot.Axes.DateTimeTicksBottom();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


