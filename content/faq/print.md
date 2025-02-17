---
title: Printing Plots with Windows Forms - ScottPlot FAQ
description: How to print a plot using ScottPlot
date: 2025-02-12
---

# Printing Plots with Windows Forms

**The easiest way to print a plot is to render it as a `Bitmap` by calling `Plot.Render()`, then print the `Bitmap`.** Many resources are available online to indicate how to print an image using your framework of choice. This page demonstrates how I prefer to print plots using WinForms.

![](/images/faq/print/print-preview.png)

```cs
public Form1()
{
    InitializeComponent();
    formsPlot1.Plot.Add.Signal(Generate.Sin(51));
    formsPlot1.Plot.Add.Signal(Generate.Cos(51));
}

private void PrintPage(object sender, PrintPageEventArgs e)
{
    // Determine how large you want the plot to be on the page and resize accordingly
    int width = e.MarginBounds.Width;
    int height = (int)(e.MarginBounds.Width * .5);

    // Give the plot a white background so it looks good on white paper
    formsPlot1.Plot.FigureBackground.Color = Colors.White;

    // Render the plot as a Bitmap and draw it onto the page
    using (var ms = new MemoryStream(formsPlot1.Plot.GetImageBytes(width, height)))
    {
        Bitmap bmp = new Bitmap(ms);
        e.Graphics.DrawImage(bmp, e.MarginBounds.Left, e.MarginBounds.Top);
    }
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
```
