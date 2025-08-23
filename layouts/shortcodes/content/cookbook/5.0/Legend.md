---
Title: Legends - ScottPlot 5.0 Cookbook
Description: A legend is a key typically displayed in the corner of a plot
URL: /cookbook/5.0/Legend/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Legends"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Legend"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Legends</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Legend Quickstart</h1>
<a href='/cookbook/5.0/Legend/LegendQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Many plottables have a Label property that can be set so they appear in the legend.

[![](/cookbook/5.0/images/LegendQuickstart.png?250822231048)](/cookbook/5.0/images/LegendQuickstart.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5.0/images/LegendQuickstart.png?250822231048" >}}ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.LegendText = "Sin";

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.LegendText = "Cos";

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Right To Left (RTL) text support</h1>
<a href='/cookbook/5.0/Legend/LegendWithRTLText' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Enabling Right To Left (RTL) support correctly renders text in RTL languages.

[![](/cookbook/5.0/images/LegendWithRTLText.png?250822231048)](/cookbook/5.0/images/LegendWithRTLText.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5.0/images/LegendWithRTLText.png?250822231048" >}}ScottPlot.Plot myPlot = new();

LabelStyle.RTLSupport = true; // enable right-to-left text support

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.LegendText = "אמת"; // example right-to-left text

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.LegendText = "English"; // example left-to-right text

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Manual Legend Items</h1>
<a href='/cookbook/5.0/Legend/ManualLegend' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Legends may be constructed manually and markers customized.

[![](/cookbook/5.0/images/ManualLegend.png?250822231048)](/cookbook/5.0/images/ManualLegend.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5.0/images/ManualLegend.png?250822231048" >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));
myPlot.Legend.IsVisible = true;

LegendItem item1 = new()
{
    LineColor = Colors.Magenta,
    MarkerFillColor = Colors.Magenta,
    MarkerLineColor = Colors.Magenta,
    MarkerShape = MarkerShape.Cross,
    LineWidth = 2,
    LabelText = "Alpha"
};

LegendItem item2 = new()
{
    LineColor = Colors.Green,
    MarkerFillColor = Colors.Green,
    MarkerLineColor = Colors.Green,
    LineWidth = 4,
    LabelText = "Beta"
};

LegendItem[] items = { item1, item2 };
myPlot.ShowLegend(items);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Legend Customization</h1>
<a href='/cookbook/5.0/Legend/LegendStyle' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Access the Legend object directly for advanced customization options.

[![](/cookbook/5.0/images/LegendStyle.png?250822231048)](/cookbook/5.0/images/LegendStyle.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5.0/images/LegendStyle.png?250822231048" >}}ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.LegendText = "Sin";

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.LegendText = "Cos";

myPlot.Legend.IsVisible = true;
myPlot.Legend.Alignment = Alignment.UpperCenter;

myPlot.Legend.OutlineColor = Colors.Navy;
myPlot.Legend.OutlineWidth = 5;
myPlot.Legend.BackgroundColor = Colors.LightBlue;

myPlot.Legend.ShadowColor = Colors.Blue.WithOpacity(.2);
myPlot.Legend.ShadowOffset = new(10, 10);

myPlot.Legend.FontSize = 22;
myPlot.Legend.FontName = Fonts.Serif;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Legend Marker Shape Override</h1>
<a href='/cookbook/5.0/Legend/LegendOverrideSymbol' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Use the legend shape override to force all legend items to display using the given marker shape.

[![](/cookbook/5.0/images/LegendOverrideSymbol.png?250822231048)](/cookbook/5.0/images/LegendOverrideSymbol.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5.0/images/LegendOverrideSymbol.png?250822231048" >}}ScottPlot.Plot myPlot = new();

// this shape will be used for legend items without defined markers
myPlot.Legend.MarkerShapeOverride = MarkerShape.FilledCircle;

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.LegendText = "Sin";

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.LegendText = "Cos";

LegendItem item1 = new()
{
    MarkerColor = Colors.Red,
    MarkerShape = MarkerShape.Cross,
    LabelText = "Alpha"
};

LegendItem item2 = new()
{
    MarkerColor = Colors.Green,
    MarkerShape = MarkerShape.FilledSquare,
    LabelText = "Beta"
};

myPlot.Legend.ManualItems.Add(item1);
myPlot.Legend.ManualItems.Add(item2);

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Legend Orientation</h1>
<a href='/cookbook/5.0/Legend/LegendOrientation' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Legend items may be arranged horizontally instead of vertically

[![](/cookbook/5.0/images/LegendOrientation.png?250822231048)](/cookbook/5.0/images/LegendOrientation.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5.0/images/LegendOrientation.png?250822231048" >}}ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin(51, phase: .2));
var sig2 = myPlot.Add.Signal(Generate.Sin(51, phase: .4));
var sig3 = myPlot.Add.Signal(Generate.Sin(51, phase: .6));

sig1.LegendText = "Signal 1";
sig2.LegendText = "Signal 2";
sig3.LegendText = "Signal 3";

myPlot.ShowLegend(Alignment.UpperLeft, Orientation.Horizontal);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Legend Wrapping</h1>
<a href='/cookbook/5.0/Legend/LegendWrapping' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Legend items may wrap to improve display for a large number of items

[![](/cookbook/5.0/images/LegendWrapping.png?250822231048)](/cookbook/5.0/images/LegendWrapping.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5.0/images/LegendWrapping.png?250822231048" >}}ScottPlot.Plot myPlot = new();

for (int i = 1; i &lt;= 10; i++)
{
    double[] data = Generate.Sin(51, phase: .02 * i);
    var sig = myPlot.Add.Signal(data);
    sig.LegendText = $"#{i}";
}

myPlot.Legend.IsVisible = true;
myPlot.Legend.Orientation = Orientation.Horizontal;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Multiple Legends</h1>
<a href='/cookbook/5.0/Legend/LegendMultiple' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Multiple legends may be added to a plot

[![](/cookbook/5.0/images/LegendMultiple.png?250822231048)](/cookbook/5.0/images/LegendMultiple.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5.0/images/LegendMultiple.png?250822231048" >}}ScottPlot.Plot myPlot = new();

for (int i = 1; i &lt;= 5; i++)
{
    double[] data = Generate.Sin(51, phase: .02 * i);
    var sig = myPlot.Add.Signal(data);
    sig.LegendText = $"Signal #{i}";
    sig.LineWidth = 2;
}

// default legend
var leg1 = myPlot.ShowLegend();
leg1.Alignment = Alignment.LowerRight;
leg1.Orientation = Orientation.Vertical;

// additional legend
var leg2 = myPlot.Add.Legend();
leg2.Alignment = Alignment.UpperCenter;
leg2.Orientation = Orientation.Horizontal;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Legend Outside the Plot</h1>
<a href='/cookbook/5.0/Legend/LegendOutside' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Use the ShowLegend() overload that accepts an Edge to display the legend outside the data area.

[![](/cookbook/5.0/images/LegendOutside.png?250822231048)](/cookbook/5.0/images/LegendOutside.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5.0/images/LegendOutside.png?250822231048" >}}ScottPlot.Plot myPlot = new();

var sig1 = myPlot.Add.Signal(Generate.Sin());
var sig2 = myPlot.Add.Signal(Generate.Cos());

sig1.LegendText = "Sine";
sig2.LegendText = "Cosine";

myPlot.ShowLegend(Edge.Right);

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Automatic Legend Items Custom Font</h1>
<a href='/cookbook/5.0/Legend/LegendCustomFontAutomaticItems' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Use custom fonts from TTF files in the legend.

[![](/cookbook/5.0/images/LegendCustomFontAutomaticItems.png?250822231048)](/cookbook/5.0/images/LegendCustomFontAutomaticItems.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5.0/images/LegendCustomFontAutomaticItems.png?250822231048" >}}ScottPlot.Plot myPlot = new();

Fonts.AddFontFile("Alumni Sans", Path.Combine(GetFontsBasePath(), @"AlumniSans/AlumniSans-Regular.ttf"), bold: false, italic: false);

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.LegendText = "Sin";

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.LegendText = "Cos";

myPlot.Legend.FontName = "Alumni Sans";
myPlot.Legend.FontSize = 48;
myPlot.Legend.FontColor = Colors.Red;

myPlot.ShowLegend();

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Manual Legend Items Custom Font</h1>
<a href='/cookbook/5.0/Legend/LegendCustomFontManualItems' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Use custom fonts from TTF files in the legend (manual legend items).

[![](/cookbook/5.0/images/LegendCustomFontManualItems.png?250822231048)](/cookbook/5.0/images/LegendCustomFontManualItems.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/Legend.cs" imageUrl="/cookbook/5.0/images/LegendCustomFontManualItems.png?250822231048" >}}ScottPlot.Plot myPlot = new();

// Add a font file to use its typeface for fonts with a given name
Fonts.AddFontFile(
    name: "Alumni Sans",
    path: Path.Combine(Paths.FontFolder, @"AlumniSans/AlumniSans-Regular.ttf"));

var sig1 = myPlot.Add.Signal(Generate.Sin(51));
sig1.LegendText = "Sin";

var sig2 = myPlot.Add.Signal(Generate.Cos(51));
sig2.LegendText = "Cos";

myPlot.Legend.ManualItems.Add(new LegendItem()
{
    LabelText = "Custom",
    LabelFontName = "Alumni Sans",
    LabelFontSize = 18,
    LabelFontColor = Colors.Magenta,
    LinePattern = LinePattern.Dotted,
    LineWidth = 2,
    LineColor = Colors.Magenta,
});

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


