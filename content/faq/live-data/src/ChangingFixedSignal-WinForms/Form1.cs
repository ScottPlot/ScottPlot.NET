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
        readonly double[] Values = new double[25];
        readonly Stopwatch Stopwatch = Stopwatch.StartNew();

        public Form1()
        {
            InitializeComponent();
            UpdateValues();
            formsPlot1.Plot.AddSignal(Values);
        }

        public void UpdateValues()
        {
            double phase = Stopwatch.Elapsed.TotalSeconds;
            double multiplier = 2 * Math.PI / Values.Length;
            for (int i = 0; i < Values.Length; i++)
                Values[i] = Math.Sin(i * multiplier + phase);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateValues();
            formsPlot1.Render();
        }
    }
}
