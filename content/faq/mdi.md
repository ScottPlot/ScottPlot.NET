---
title: Plots in MDI applications - ScottPlot FAQ
description: How to display plots inside Windows Forms Multiple-Document Interface (MDI) applications
date: 2024-10-31
---

# Interactive Plots in MDI Containers

Windows forms allows child windows to be created inside MDI containers. See the [official Microsoft documentation](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/advanced/how-to-create-mdi-child-forms) for details. Code here shows how to create child windows that display ScottPlot plots.

```cs
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        this.IsMdiContainer = true;

        button1.Click += (s, e) =>
        {
            Form childForm = new() { MdiParent = this };
            ScottPlot.WinForms.FormsPlot FormsPlot1 = new() { Dock = DockStyle.Fill };
            childForm.Controls.Add(FormsPlot1);
            FormsPlot1.Plot.Add.Signal(ScottPlot.Generate.RandomWalk(100));
            childForm.Show();
        };
    }
}
```

<img src="/images/faq/mdi/mdi.gif" class="border shadow border-black mx-auto my-5">