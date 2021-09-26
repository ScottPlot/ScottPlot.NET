using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharedAxes
{
    public partial class Form1 : Form
    {
        readonly FormsPlot[] FormsPlots;

        public Form1()
        {
            InitializeComponent();

            // plot sample data with greatly different Y scales
            Random rand = new Random(0);
            double[] ysSmall = DataGen.RandomWalk(1000, 1);
            double[] ysBig = DataGen.RandomWalk(1000, 1e6);

            formsPlot1.Plot.AddSignal(ysSmall, color: Color.Red);
            formsPlot2.Plot.AddSignal(ysBig, color: Color.Blue);

            // manually define the Y axis size to ensure plots line-up
            float yAxisSize = 70;
            formsPlot1.Plot.YAxis.SetSizeLimit(min: yAxisSize, max: yAxisSize);
            formsPlot2.Plot.YAxis.SetSizeLimit(min: yAxisSize, max: yAxisSize);

            // populate array of plots for easy iteration later
            FormsPlots = new FormsPlot[] { formsPlot1, formsPlot2 };
            foreach (var fp in FormsPlots)
                fp.AxesChanged += OnAxesChanged;
        }
        private void OnAxesChanged(object sender, EventArgs e)
        {
            FormsPlot changedPlot = (FormsPlot)sender;
            var newAxisLimits = changedPlot.Plot.GetAxisLimits();

            foreach (var fp in FormsPlots)
            {
                if (fp == changedPlot)
                    continue;

                // disable events briefly to avoid an infinite loop
                fp.Configuration.AxesChangedEventEnabled = false;
                fp.Plot.SetAxisLimitsX(newAxisLimits.XMin, newAxisLimits.XMax);
                fp.Render();
                fp.Configuration.AxesChangedEventEnabled = true;
            }
        }
    }
}
