using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowValue
{
    public partial class Form1 : Form
    {
        private readonly ScottPlot.Plottable.SignalPlot MySignalPlot;
        private readonly ScottPlot.Plottable.ScatterPlot HighlightedPoint;
        private int LastHighlightedIndex = -1;

        public Form1()
        {
            InitializeComponent();

            // create a signal plot from some random data and save it
            double[] ys = ScottPlot.DataGen.RandomWalk(100_000);
            MySignalPlot = formsPlot1.Plot.AddSignal(ys);

            // Add a red circle we can move around later as a highlighted point indicator
            HighlightedPoint = formsPlot1.Plot.AddPoint(0, 0);
            HighlightedPoint.Color = Color.Red;
            HighlightedPoint.MarkerSize = 10;
            HighlightedPoint.MarkerShape = ScottPlot.MarkerShape.openCircle;
            HighlightedPoint.IsVisible = false;
        }

        private void formsPlot1_MouseMove(object sender, MouseEventArgs e)
        {
            // determine point nearest the cursor
            (double mouseCoordX, _) = formsPlot1.GetMouseCoordinates();
            (double pointX, double pointY, int pointIndex) = MySignalPlot.GetPointNearestX(mouseCoordX);

            // place the highlight over the point of interest
            HighlightedPoint.Xs[0] = pointX;
            HighlightedPoint.Ys[0] = pointY;
            HighlightedPoint.IsVisible = true;

            // render if the highlighted point chnaged
            if (LastHighlightedIndex != pointIndex)
            {
                LastHighlightedIndex = pointIndex;
                formsPlot1.Render();
            }

            // update the GUI to describe the highlighted point
            Text = $"Point index {pointIndex} at ({pointX:N2}, {pointY:N2})";
        }
    }
}
