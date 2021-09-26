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

namespace ChangingFixedSignal
{
    public partial class Form1 : Form
    {
        readonly double[] Values = new double[500];
        readonly Stopwatch Stopwatch = Stopwatch.StartNew();
        readonly ScottPlot.Plottable.VLine VerticalLine;
        int NextIndex = 0;

        public Form1()
        {
            InitializeComponent();
            formsPlot1.Plot.AddSignal(Values);
            VerticalLine = formsPlot1.Plot.AddVerticalLine(0, Color.Red, 2);
            formsPlot1.Plot.SetAxisLimits(0, Values.Length, -2, 2);
        }

        public void AddDataPoint()
        {
            Values[NextIndex] = Math.Sin(Stopwatch.Elapsed.TotalSeconds * 3);

            NextIndex += 1;
            if (NextIndex >= Values.Length)
                NextIndex = 0;

            VerticalLine.X = NextIndex;
        }

        // This timer adds data frequently (every 1 ms)
        private void timer1_Tick(object sender, EventArgs e)
        {
            AddDataPoint();
        }

        // This timer renders infrequently (every 20 ms)
        private void timer2_Tick(object sender, EventArgs e)
        {
            formsPlot1.Render();
        }
    }
}
