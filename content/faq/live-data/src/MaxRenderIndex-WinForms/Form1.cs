using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxRenderIndex
{
    public partial class Form1 : Form
    {
        readonly double[] Values = new double[100_000];
        int NextPointIndex = 0;
        readonly ScottPlot.Plottable.SignalPlot SignalPlot;

        public Form1()
        {
            InitializeComponent();
            SignalPlot = formsPlot1.Plot.AddSignal(Values);
            formsPlot1.Plot.SetAxisLimits(0, 100, -2, 2);
        }

        // This timer adds data quickly (1000 times / second)
        private void timer1_Tick(object sender, EventArgs e)
        {
            Values[NextPointIndex] = Math.Sin(NextPointIndex * .05);
            SignalPlot.MaxRenderIndex = NextPointIndex;
            NextPointIndex += 1;
        }

        // This timer triggers renders slowly (10 times per second)
        private void timer2_Tick(object sender, EventArgs e)
        {
            // adjust the axis limits only when needed
            double currentRightEdge = formsPlot1.Plot.GetAxisLimits().XMax;
            if (NextPointIndex > currentRightEdge)
                formsPlot1.Plot.SetAxisLimits(xMax: currentRightEdge + 100);

            formsPlot1.Render();
        }
    }
}
