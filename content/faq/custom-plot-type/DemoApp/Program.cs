using ScottPlot.Plottable;
using ScottPlot;

ScottPlot.Plot myPlot = new();
double[] xs = ScottPlot.Generate.Consecutive(51);
double[] ys = ScottPlot.Generate.Sin(51);
RainbowPlot myPlottable = new(xs, ys);
myPlot.Add(myPlottable);

new ScottPlot.FormsPlotViewer(myPlot).ShowDialog();


class RainbowPlot : IPlottable
{
    double[] Xs { get; }
    double[] Ys { get; }
    Color[] Colors { get; }

    public RainbowPlot(double[] xs, double[] ys)
    {
        Xs = xs;
        Ys = ys;
        Colors = new Color[Xs.Length];

        // precalculate the color for each data point
        Color[] rainbowColors = { Color.Red, Color.Orange, Color.Yellow,
            Color.Green, Color.Blue, Color.Indigo, Color.Violet };

        for (int i = 0; i < Xs.Length; i++)
            Colors[i] = rainbowColors[i % rainbowColors.Length];
    }

    // Additional properties facilitate advanced customization
    public float Radius { get; set; } = 10;

    // These default values are fine for most cases
    public bool IsVisible { get; set; } = true;
    public int XAxisIndex { get; set; } = 0;
    public int YAxisIndex { get; set; } = 0;
    public void ValidateData(bool deep = false) { }

    // Return an empty array for plottables that do not appear in the legend
    public LegendItem[] GetLegendItems()
        => Array.Empty<LegendItem>();

    // This method returns the bounds of the data
    public AxisLimits GetAxisLimits() =>
        new AxisLimits(Xs.Min(), Xs.Max(), Ys.Min(), Ys.Max());

    // This method describes how to plot the data on the cart.
    public void Render(PlotDimensions dims, System.Drawing.Bitmap bmp, bool lowQuality = false)
    {
        // Use ScottPlot's GDI helper functions to create System.Drawing objects
        using var gfx = ScottPlot.Drawing.GDI.Graphics(bmp, dims, lowQuality);
        using var brush = (SolidBrush)ScottPlot.Drawing.GDI.Brush(Color.Black);

        // Render data by drawing on the Graphics object
        for (int i = 0; i < Xs.Length; i++)
        {
            // Use 'dims' methods to convert between axis coordinates and pixel positions
            float xPixel = dims.GetPixelX(Xs[i]);
            float yPixel = dims.GetPixelY(Ys[i]);

            brush.Color = Colors[i];
            gfx.FillEllipse(brush,
                x: xPixel - Radius,
                y: yPixel - Radius,
                width: Radius * 2,
                height: Radius * 2);
        }
    }
}