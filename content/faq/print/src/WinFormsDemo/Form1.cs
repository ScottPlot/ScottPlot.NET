using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            formsPlot1.Plot.AddSignal(ScottPlot.DataGen.Sin(51));
            formsPlot1.Plot.AddSignal(ScottPlot.DataGen.Cos(51));
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Determine how large you want the plot to be on the page and resize accordingly
            int width = e.MarginBounds.Width;
            int height = (int)(e.MarginBounds.Width * .5);
            formsPlot1.Plot.Resize(width, height);

            // Give the plot a white background so it looks good on white paper
            formsPlot1.Plot.Style(figureBackground: Color.White);

            // Render the plot as a Bitmap and draw it onto the page
            Bitmap bmp = formsPlot1.Plot.Render();
            e.Graphics.DrawImage(bmp, e.MarginBounds.Left, e.MarginBounds.Top);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
            var printDialog = new PrintDialog { Document = printDocument };
            var printDiagResult = printDialog.ShowDialog();
            if (printDiagResult == DialogResult.OK)
                printDocument.Print();
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            var printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage);
            var printDialog = new PrintPreviewDialog { Document = printDocument };
            printDialog.ShowDialog();
        }
    }
}
