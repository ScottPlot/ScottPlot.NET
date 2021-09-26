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

            // plot sample data
            formsPlot1.Plot.AddSignal(DataGen.Sin(51), color: Color.Red);
            formsPlot2.Plot.AddSignal(DataGen.Cos(51), color: Color.Blue);

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
                fp.Plot.SetAxisLimits(newAxisLimits);
                fp.Render();
                fp.Configuration.AxesChangedEventEnabled = true;
            }
        }
    }
}
