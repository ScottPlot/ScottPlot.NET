---
Title: How to Create Custom Plot Types - ScottPlot FAQ
Description: By creating a class that implements IPlottable, users can create custom plot types and have full control over styling and data management.
date: 2023-12-13
---

# How to Create Custom Plot Types

**ScottPlot comes with dozens of plot types (bar, scatter, pie, etc.), but users can create their own to achieve full control over styling and behavior.** Custom plot types can be created and added to plots without having to modify ScottPlot's source code. Custom plot types implement `IPlottable` and have a `Render()` method which holds logic for drawing on the `Plot`.

## Example

This custom plot type is like a scatter plot but it draws points as large circles colored like a rainbow:

```cs
class RainbowPlot : IPlottable
{
    // data and customization options
    double[] Xs { get; }
    double[] Ys { get; }
    public float Radius { get; set; } = 10;
    IColormap Colormap { get; set; } = new ScottPlot.Colormaps.Turbo();

    // items required by IPlottable
    public bool IsVisible { get; set; } = true;
    public IAxes Axes { get; set; } = new Axes();
    public IEnumerable<LegendItem> LegendItems => LegendItem.None;
    public AxisLimits GetAxisLimits() => new(Xs.Min(), Xs.Max(), Ys.Min(), Ys.Max());

    public RainbowPlot(double[] xs, double[] ys) { Xs = xs; Ys = ys; }

    public void Render(RenderPack rp)
    {
        FillStyle FillStyle = new();
        using SKPaint paint = new();
        for (int i = 0; i < Xs.Length; i++)
        {
            // convert coordinate location to screen location
            Coordinates centerCoordinates = new(Xs[i], Ys[i]);
            Pixel centerPixel = Axes.GetPixel(centerCoordinates);

            // draw the colored circle
            FillStyle.Color = Colormap.GetColor(i / (Xs.Length - 1.0));
            ScottPlot.Drawing.DrawCircle(rp.Canvas, centerPixel, Radius, FillStyle, paint);
        }
    }
}
```

A custom plot typ can be instantiated and added to the plot:

```cs
// instantiate the custom plottable
double[] xs = ScottPlot.Generate.Consecutive(20);
double[] ys = ScottPlot.Generate.Sin(20);
RainbowPlot rainbowPlot = new(xs, ys);

// add it to the plot
formsPlot1.Plot.Add.Plottable(rainbowPlot);
```

![](/images/faq/custom-plot-type/rainbow.png)

See the [**ScottPlot Demo**](/demo) for full additional resources.

## The official plot types are a useful reference

Learn more about how plottables are commonly constructed by inspecting the code behind the simplest plot types distributed with ScottPlot. We recommend looking in [ScottPlot's GitHub repository](https://github.com/scottplot/scottplot/) to review source code for simple types like `Text`, `Rectangle`, `Line`, and `Arrow`.