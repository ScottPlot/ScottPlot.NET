using ScottPlot.Plottable;
using ScottPlot;
using ScottPlot.SnapLogic;

ScottPlot.Plot myPlot = new();
Random rand = new();
double[] xs = ScottPlot.DataGen.Random(rand, 50, 10);
double[] ys = ScottPlot.DataGen.Random(rand, 50, 10);
RainbowPlot myPlottable = new(xs, ys);
myPlot.Add(myPlottable);

new ScottPlot.FormsPlotViewer(myPlot).ShowDialog();


class RainbowPlot : IPlottable, IDraggable
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
    public bool DragEnabled { get; set; } = true;

    public ScottPlot.Cursor DragCursor => ScottPlot.Cursor.Hand;

    public ISnap2D DragSnap { get; set; } = new NoSnap2D();

    public event EventHandler Dragged = delegate { };

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

    private int IndexUnderMouse;

    public bool IsUnderMouse(double coordinateX, double coordinateY, double snapX, double snapY)
    {
        double distanceThreshold = .25;
        for (int i = 0; i < Xs.Length; i++)
        {
            double dx = Xs[i] - coordinateX;
            double dy = Ys[i] - coordinateY;
            double distance = Math.Sqrt(dx * dx + dy * dy);
            if (distance < distanceThreshold)
            {
                IndexUnderMouse = i;
                return true;
            }
        }

        return false;
    }

    public void DragTo(double coordinateX, double coordinateY, bool fixedSize)
    {
        Xs[IndexUnderMouse] = coordinateX;
        Ys[IndexUnderMouse] = coordinateY;
    }
}