---
title: RenderStarting Event - ScottPlot FAQ
description: How to use the RenderStarting event to style plots dynamically
date: 2024-11-06
---

# The RenderStarting Event

The `RenderStarting` event is called after a plot's layout has been determined and its ticks generated, but before it is actually rendered to the canvas. Hooking into this event lets users dynamically modify the plot using information about its layout that is not available before render time.

![](/images/faq/renderstarting/first-tick.png)

## Dynamic Styling

The pixel size of plots is not stored in `Plot`, but instead passed through the `Render()` method when a figure is requested. Plot size is dynamic and may change over time, but plots are typically only set-up once. The `RenderStarting` event may be used to customize objects on the plot using information about the dynamically generated layout at render time.

```cs
var sig = formsPlot1.Plot.Add.Signal(Generate.Sin());

formsPlot1.Plot.RenderManager.RenderStarting += (object? sender, RenderPack rp) =>
{
    // show the figure size in the title
    formsPlot1.Plot.Title($"W={rp.FigureRect.Width}px H={rp.FigureRect.Height}px");

    // style a line according to the figure dimensions
    float WidthHeightRatio = rp.DataRect.Width / rp.DataRect.Height;
    sig.LineWidth = 2 * WidthHeightRatio;
    sig.LineColor = ScottPlot.Colormap.Default.GetColor(WidthHeightRatio);
};
```

![](/images/faq/renderstarting/plottable2.gif)

## Customizing Automatic Ticks

Ticks are generated at the start of each render according to the plot's axis limits and figure size. ScottPlot has an extensive tick generation system that allows users to create and use their own `ITickGenerator` to fully customize how ticks are placed, but simple modifications may be achieved by manually editing ticks in the `Ticks` array after they have been generated:

```cs
formsPlot1.Plot.RenderManager.RenderStarting += (object? sender, RenderPack rp) =>
{
    // the ticks have been generated but may still be modified
    Tick[] ticks = formsPlot1.Plot.Axes.Bottom.TickGenerator.Ticks;

    // change the label of the first tick
    ticks[1] = Tick.Major(ticks[1].Position, "HELLO");
};
```
