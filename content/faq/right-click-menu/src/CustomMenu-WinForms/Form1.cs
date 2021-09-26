using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            formsPlot1.RightClicked += CustomRightClickEvent;
        }

        private void CustomRightClickEvent(object sender, EventArgs e)
        {
            ContextMenuStrip customMenu = new ContextMenuStrip();
            customMenu.Items.Add(new ToolStripMenuItem("Add Sine Wave", null, new EventHandler(AddSine)));
            customMenu.Items.Add(new ToolStripMenuItem("Clear Plot", null, new EventHandler(ClearPlot)));
            customMenu.Show(Cursor.Position);
        }

        private void AddSine(object sender, EventArgs e)
        {
            Random rand = new Random();
            double[] data = ScottPlot.DataGen.Sin(51, phase: rand.NextDouble() * 1000);
            formsPlot1.Plot.AddSignal(data);
            formsPlot1.Plot.AxisAuto();
            formsPlot1.Render();
        }

        private void ClearPlot(object sender, EventArgs e)
        {
            formsPlot1.Plot.Clear();
            formsPlot1.Plot.AxisAuto();
            formsPlot1.Render();
        }
    }
}
