---
Title: User Defined Scaling - ScottPlot FAQ
Description: How to create a plot with a known units-per-pixel scaling
date: 2025-02-24
---

## User Defined Scaling

Plots which require a known "real world" scaling can setup a custom axis rule to
enforce desired pixels-per-unit scaling at render time. Examples include:

* Create a plot where the horizontal axis units is millimeters when printed
* Create a plot where the horizontal axis is pixels
* Place a tick mark every 50 pixels apart

## Static Example

This example demonstrates how to create a plot in a Console Application where each unit on the horizontal axis spans exactly 5 pixels.

```cs
using ScottPlot;

// create a plot and add sample data
Plot myPlot = new();
myPlot.Add.Signal(Generate.Sin(100, oscillations: 5));

// use a fixed layout system so we know how large the plot is in pixel units
PixelRect dataRect = new(left: 50, right: 350, bottom: 250, top: 50);
myPlot.Layout.Fixed(dataRect);

// set axis limits to achieve a desired "pixels per unit" scaling
float pixelsPerUnit = 5;
float leftEdge = 0;
float rightEdge = dataRect.Width / pixelsPerUnit;
myPlot.Axes.SetLimitsX(leftEdge, rightEdge);

// The final figure should be the data rectangle expanded to allow for axis labels
PixelRect figureRect = dataRect.Expand(50);
myPlot.SavePng("test.png", (int)figureRect.Width, (int)figureRect.Height);
```

![](/images/faq/fixed-scale/fixed-scale-console.png)

## Interactive Example

This example uses Windows Forms, but the strategy can be applied to any interactive
user control or console application.

```cs
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        // add sample data
        formsPlot1.Plot.Add.Signal(Generate.Sin(200, oscillations: 5));

        // add our custom scaling rule
        FixedScalingAxisRule rule = new();
        formsPlot1.Plot.Axes.Rules.Add(rule);
    }

    class FixedScalingAxisRule : IAxisRule
    {
        float PixelsPerUnit { get; set; } = 5;
        float LeftEdge { get; set; } = 0;

        public void Apply(RenderPack rp, bool beforeLayout)
        {
            if (beforeLayout)
                return;

            float rightEdge = rp.DataRect.Width / PixelsPerUnit;
            rp.Plot.Axes.SetLimitsX(LeftEdge, rightEdge);
        }
    }
}
```

![](/images/faq/fixed-scale/fixed-scale-resize.gif)