---
Title: Layout - ScottPlot 5.0 Cookbook
Description: How to customize data area size and figure padding
URL: /cookbook/5.0/Layout/
BreadcrumbNames: ["ScottPlot 5.0 Cookbook", "Layout"]
BreadcrumbUrls: ["/cookbook/5.0/", "/cookbook/5.0/Layout"]
Date: 2024-11-01
Version: ScottPlot 5.0.42
Version: ScottPlot 5.0.42
SearchUrl: "/cookbook/5.0/search/"
ShowEditLink: false
---

<h1>Layout</h1>


<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Frameless Plot</h1>
<a href='/cookbook/5.0/Layout/Frameless' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

How to create a plot containing only the data area and no axes.

[![](/cookbook/5.0/images/Frameless.png?241101192719)](/cookbook/5.0/images/Frameless.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

// make the data area cover the full figure
myPlot.Layout.Frameless();

// set the data area background so we can observe its size
myPlot.DataBackground.Color = Colors.WhiteSmoke;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Fixed Padding</h1>
<a href='/cookbook/5.0/Layout/FixedPadding' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The plot can be arranged to achieve a fixed amount of padding on each side of the data area

[![](/cookbook/5.0/images/FixedPadding.png?241101192719)](/cookbook/5.0/images/FixedPadding.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// add sample data to the plot
myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

// use a fixed amount of of pixel padding on each side
PixelPadding padding = new(100, 50, 100, 50);
myPlot.Layout.Fixed(padding);

// darken the figure background so we can observe its dimensions
myPlot.FigureBackground.Color = Colors.LightBlue;
myPlot.DataBackground.Color = Colors.White;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>



<div class='d-flex align-items-center mt-5'>
<h1 class='me-2 text-dark my-0 border-0'>Fixed Rectangle</h1>
<a href='/cookbook/5.0/Layout/FixedRectangle' target='_blank'>
<img src='/images/icons/new-window.svg' style='height: 2rem;' class='new-window-icon'>
</a>
</div>

The plot can be arranged so the data is drawn inside a fixed rectangle defined in pixel units

[![](/cookbook/5.0/images/FixedRectangle.png?241101192719)](/cookbook/5.0/images/FixedRectangle.png?241101192719)

{{< recipe-sp5 >}}ScottPlot.Plot myPlot = new();

// add sample data to the plot
myPlot.Add.Signal(Generate.Sin(51));
myPlot.Add.Signal(Generate.Cos(51));

// set the data area to render inside a fixed rectangle
PixelSize size = new(300, 200);
Pixel offset = new(50, 50);
PixelRect rect = new(size, offset);
myPlot.Layout.Fixed(rect);

// darken the figure background so we can observe its dimensions
myPlot.FigureBackground.Color = Colors.LightBlue;
myPlot.DataBackground.Color = Colors.White;

myPlot.SavePng("demo.png", 400, 300);
{{< /recipe-sp5 >}}

<hr class='my-5 invisible'>


