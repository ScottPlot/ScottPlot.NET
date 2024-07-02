---
title: Display Scaling - ScottPlot FAQ
description: How to configure ScottPlot when DPI scaling is used
date: 2023-12-13
---

# Display Scaling

Display scaling (DPI scaling) is a setting that allows the operating system to stretch a window to be larger than its original size. Viewing native resolution images on scaled displays may cause lines and text to appear very small. Increasing ScottPlot's `ScaleFactor` to match the screen's display scaling may result in a more comfortable viewing experience for the user. See the [**ScottPlot Cookbook**](/cookbook/) for more information.

<div class="d-flex">

<div class='text-center'>

<h3>Scale Factor = 1</h3>

![](/images/faq/dpi-scaling/dpi-scaling-1.png)

</div>

<div class='text-center'>

<h3>Scale Factor = 2</h3>

![](/images/faq/dpi-scaling/dpi-scaling-2.png)

</div>

</div>

```cs
ScottPlot.Plot myPlot = new();

myPlot.ScaleFactor = 2;
myPlot.Add.Signal(Generate.Sin());
myPlot.Add.Signal(Generate.Cos());

myPlot.SavePng("demo.png", 400, 300);
```



## Mouse Position in WPF Applications

WPF applications support display scaling, but the pixel position of the mouse is reported in unscaled units. Users desiring mouse-interactive behavior in WPF applications must multiple mouse position by `WpfPlot.DisplayScale` to compensate for this before passing coordinates into ScottPlot.

```cs
public partial class DisplayScaling : Window
{
    public DisplayScaling()
    {
        InitializeComponent();

        // add a crosshair to the plot
        var cross = WpfPlot1.Plot.Add.Crosshair(0, 0);

        // move the crosshair to track the cursor
        MouseMove += (s, e) => {
            Point p = e.GetPosition(WpfPlot1);
            ScottPlot.Pixel mousePixel = new(p.X * WpfPlot1.DisplayScale, p.Y * WpfPlot1.DisplayScale);
            ScottPlot.Coordinates coordinates = WpfPlot1.Plot.GetCoordinates(mousePixel);
            cross.Position = coordinates;
            WpfPlot1.Refresh();
        };
    }
}
```

Refer to the WPF demo application in the [ScottPlot GitHub repository](https://github.com/ScottPlot/ScottPlot) for full source code.