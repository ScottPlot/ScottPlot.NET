---
title: Add ScottPlot WinForms Control Programmatically
description: How to create and place an interactive ScottPlot control in a Form without using the Visual Studio designer
date: 2023-12-13
---

# Add ScottPlot WinForms Control Programmatically

**The FormsPlot control may not appear in the Visual Studio Toolbox or it might throw a `TypeInitializationException` when first used.** This is an known issue affecting old versions of Visual Studio or projects that target .NET Framework. The recommended fix is to place a `Panel` where you want the plot instead, then create a `FormsPlot` programmatically to go inside it.

**Step 1:** Open Visual Studio and create a new Windows Forms App

**Step 2:** Right-click the project, select "Manage NuGet Packages", and install the "ScottPlot.WinForms" package

**Step 3:** Drop a `Panel` onto your window and give it a unique color

**Step 4:** Edit your Form's .cs file as follows

```cs
using ScottPlot.WinForms;
using System.Windows.Forms;

namespace WindowsFormsApp33
{
    public partial class Form1 : Form
    {
        // Create an instance of a FormsPlot like this
        readonly FormsPlot FormsPlot1 = new FormsPlot() { Dock = DockStyle.Fill };

        public Form1()
        {
            InitializeComponent();

            // Add the FormsPlot to the panel
            panel1.Controls.Add(FormsPlot1);

            // Plot data using the control
            double[] data = ScottPlot.Generate.Sin();
            FormsPlot1.Plot.Add.Signal(data);
            FormsPlot1.Refresh();
        }
    }
}
```

![](/images/faq/add-winforms-programmatically/screenshot3.png)

![](/images/faq/add-winforms-programmatically/screenshot4.png)
