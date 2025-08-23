---
Title: Color - ScottPlot 5.0 Cookbook
Description: Color tools and features built into ScottPlot
URL: /cookbook/5.0/ColorRecipes/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Color"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/ColorRecipes"]
Date: 2025-08-23
Version: ScottPlot 5.0.56
Version: ScottPlot 5.0.56
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Color</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Color Quickstart</h1>
<a href='/cookbook/5.0/ColorRecipes/ColorQuickstart' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

ScottPlot.Colors contains many colors

[![](/cookbook/5.0/images/ColorQuickstart.png?250822231048)](/cookbook/5.0/images/ColorQuickstart.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/ColorRecipes.cs" imageUrl="/cookbook/5.0/images/ColorQuickstart.png?250822231048" >}}ScottPlot.Plot myPlot = new();

var circle1 = myPlot.Add.Circle(0, 0, 1);
var circle2 = myPlot.Add.Circle(1, 0, 1);
var circle3 = myPlot.Add.Circle(2, 0, 1);

circle1.FillColor = Colors.Red;
circle2.FillColor = Colors.Green;
circle3.FillColor = Colors.Blue;

// set outline style for all circles on the plot
foreach (var circle in myPlot.GetPlottables&lt;ScottPlot.Plottables.Ellipse&gt;())
    circle.LineColor = Colors.Black;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Creating Colors</h1>
<a href='/cookbook/5.0/ColorRecipes/ColorHex' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

ScottPlot.Colors can be constructed from RGB values (0-255), HTML style hexadecimal color codes (00-FF), or System.Drawing.Color objects.

[![](/cookbook/5.0/images/ColorHex.png?250822231048)](/cookbook/5.0/images/ColorHex.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/ColorRecipes.cs" imageUrl="/cookbook/5.0/images/ColorHex.png?250822231048" >}}ScottPlot.Plot myPlot = new();

var circle1 = myPlot.Add.Circle(0, 0, 1);
var circle2 = myPlot.Add.Circle(1, 0, 1);
var circle3 = myPlot.Add.Circle(2, 0, 1);

circle1.FillColor = new Color(red: 255, green: 0, blue: 0);
circle2.FillColor = new Color(System.Drawing.Color.Green);
circle3.FillColor = new Color("#0000FF");

// set outline style for all circles on the plot
foreach (var circle in myPlot.GetPlottables&lt;ScottPlot.Plottables.Ellipse&gt;())
    circle.LineColor = Colors.Black;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Alpha Channel</h1>
<a href='/cookbook/5.0/ColorRecipes/ColorTransparency' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The Alpha channel sets transparency of a color

[![](/cookbook/5.0/images/ColorTransparency.png?250822231048)](/cookbook/5.0/images/ColorTransparency.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/ColorRecipes.cs" imageUrl="/cookbook/5.0/images/ColorTransparency.png?250822231048" >}}ScottPlot.Plot myPlot = new();

var circle1 = myPlot.Add.Circle(0, 0, 1);
var circle2 = myPlot.Add.Circle(1, 0, 1);
var circle3 = myPlot.Add.Circle(2, 0, 1);
var circle4 = myPlot.Add.Circle(3, 0, 1);

circle1.FillColor = new Color(red: 255, green: 0, blue: 0, alpha: 128);
circle2.FillColor = Colors.Green.WithAlpha(.5);
circle3.FillColor = Colors.Blue.WithAlpha(.5);
circle4.FillColor = Colors.Magenta.WithOpacity(Colors.Magenta.WithOpacity(0.9).Opacity / 2);

// set outline style for all circles on the plot
foreach (var circle in myPlot.GetPlottables&lt;ScottPlot.Plottables.Ellipse&gt;())
    circle.LineColor = Colors.Black;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Color Mixing</h1>
<a href='/cookbook/5.0/ColorRecipes/ColorMixing' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Colors have a MixWith() method that can be used to blend two colors

[![](/cookbook/5.0/images/ColorMixing.png?250822231048)](/cookbook/5.0/images/ColorMixing.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/ColorRecipes.cs" imageUrl="/cookbook/5.0/images/ColorMixing.png?250822231048" >}}ScottPlot.Plot myPlot = new();

Color color1 = Colors.Blue;
Color color2 = Colors.Green;

for (int i = 0; i &lt; 10; i++)
{
    var circle = myPlot.Add.Circle(i, 0, 1);
    double fraction = (double)i / 10;
    circle.FillColor = color1.MixedWith(color2, fraction);
    circle.LineColor = Colors.Black;
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Color HSL</h1>
<a href='/cookbook/5.0/ColorRecipes/ColorHSL' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Colors may be generated from HSL (hue, saturation, luminosity) values.

[![](/cookbook/5.0/images/ColorHSL.png?250822231048)](/cookbook/5.0/images/ColorHSL.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/ColorRecipes.cs" imageUrl="/cookbook/5.0/images/ColorHSL.png?250822231048" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 10; i++)
{
    var circle = myPlot.Add.Circle(i, 0, 1);
    float fraction = (float)i / 10;
    circle.FillColor = Color.FromHSL(hue: fraction, saturation: 1, luminosity: .5f);
    circle.LineColor = Colors.Black;
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Interpolating Colors</h1>
<a href='/cookbook/5.0/ColorRecipes/ColorInterpolate' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

A collection of colors can be generated from the linear interpolation between two colors.

[![](/cookbook/5.0/images/ColorInterpolate.png?250822231048)](/cookbook/5.0/images/ColorInterpolate.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/ColorRecipes.cs" imageUrl="/cookbook/5.0/images/ColorInterpolate.png?250822231048" >}}ScottPlot.Plot myPlot = new();

Color[] colors = Color.InterpolateRgbArray(Colors.Blue, Colors.Green, steps: 20);

for (int i = 0; i &lt; colors.Length; i++)
{
    var sig = myPlot.Add.Signal(Generate.Sin());
    sig.Data.XOffset = i * 3;
    sig.Data.YOffset = i * .1;
    sig.LineWidth = 3;
    sig.LineColor = colors[i];
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Random Colors</h1>
<a href='/cookbook/5.0/ColorRecipes/ColorRandom' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The simplest way to generate random colors is to create colors which have same saturation and luminosity but random hue.

[![](/cookbook/5.0/images/ColorRandom.png?250822231048)](/cookbook/5.0/images/ColorRandom.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/ColorRecipes.cs" imageUrl="/cookbook/5.0/images/ColorRandom.png?250822231048" >}}ScottPlot.Plot myPlot = new();

for (int i = 0; i &lt; 20; i++)
{
    var sig = myPlot.Add.Signal(Generate.Sin());
    sig.Data.XOffset = i * 3;
    sig.Data.YOffset = i * .1;
    sig.LineWidth = 3;
    sig.LineColor = Color.RandomHue();
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Colors from Colormap</h1>
<a href='/cookbook/5.0/ColorRecipes/ColorsFromColormap' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Colormaps may be used to source a collection of colors.

[![](/cookbook/5.0/images/ColorsFromColormap.png?250822231048)](/cookbook/5.0/images/ColorsFromColormap.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/ColorRecipes.cs" imageUrl="/cookbook/5.0/images/ColorsFromColormap.png?250822231048" >}}ScottPlot.Plot myPlot = new();

IColormap colormap = new ScottPlot.Colormaps.Viridis();
Color[] colors = colormap.GetColors(20);

for (int i = 0; i &lt; colors.Length; i++)
{
    var sig = myPlot.Add.Signal(Generate.Sin());
    sig.Data.XOffset = i * 3;
    sig.Data.YOffset = i * .1;
    sig.LineWidth = 3;
    sig.LineColor = colors[i];
}

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Color Lighten and Darken</h1>
<a href='/cookbook/5.0/ColorRecipes/ColorLightenAndDarken' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

Helper methods make it easy to lighten or darken colors.

[![](/cookbook/5.0/images/ColorLightenAndDarken.png?250822231048)](/cookbook/5.0/images/ColorLightenAndDarken.png?250822231048)

{{< recipe-sp5 sourceUrl="https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot5/ScottPlot5%20Cookbook/Recipes/General/ColorRecipes.cs" imageUrl="/cookbook/5.0/images/ColorLightenAndDarken.png?250822231048" >}}ScottPlot.Plot myPlot = new();

Color color1 = Colors.Blue;
Color color2 = Colors.Blue;

for (int i = 0; i &lt; 10; i++)
{
    var circle1 = myPlot.Add.Circle(i, 3, 1);
    var circle2 = myPlot.Add.Circle(i, 0, 1);
    circle1.FillColor = color1;
    circle2.FillColor = color2;
    color1 = color1.Lighten(.2);
    color2 = color2.Darken(.2);
}

// set outline style for all circles on the plot
foreach (var circle in myPlot.GetPlottables&lt;ScottPlot.Plottables.Ellipse&gt;())
    circle.LineColor = Colors.Black;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


