---
Title: Launch Interactive Plots from Console Applications
Description: Interactive plot controls can be created and launched from console applications
date: 2023-12-13
---

# Interactive Plots in Console Applications 

Interactive plot controls can be created and launched from console applications.

## Launch an Interactive FormsPlot

**Step 1:** Add both the `ScottPlot` and `ScottPlot.WinForms` NuGet packages

**Step 2:** Modify your .csproj `TargetFramework` to target Windows (e.g., `net8.0-windows`)

**Step 3:** Modify your .csproj file to add `<UseWindowsForms>true</UseWindowsForms>`

**Step 4:** Create a plot, add some data, and launch it interactively:

```cs
// create a plot
ScottPlot.Plot myPlot = new();
myPlot.Add.Signal(ScottPlot.Generate.Sin());
myPlot.Add.Signal(ScottPlot.Generate.Cos());

// launch the plot in an interactive plot window
ScottPlot.WinForms.FormsPlotViewer.Launch(myPlot);
```

## Launch an Interactive WpfPlot

**Step 1:** Add both the `ScottPlot` and `ScottPlot.WPF` NuGet packages

**Step 2:** Modify your .csproj `TargetFramework` to target Windows (e.g., `net8.0-windows`)

**Step 3:** Modify your .csproj file to add `<UseWPF>true</UseWPF>`

**Step 4:** Ensure your calling application has the `STAThread` attribute

**Step 5:** Create a plot, add some data, and launch it interactively:

```cs
public static class Program
{
    [STAThread]
    static void Main()
    {
        // create a plot
        ScottPlot.Plot myPlot = new();
        myPlot.Add.Signal(ScottPlot.Generate.Sin());
        myPlot.Add.Signal(ScottPlot.Generate.Cos());

        // launch the plot in an interactive plot window
        ScottPlot.WPF.WpfPlotViewer.Launch(myPlot);
    }
}
```

## Create Interactive Plot Windows Programmatically

**Users desiring advanced customization** may benefit from creating a control from scratch, styling it as desired, adding a plot control, then launching it programmatically.

### Windows Forms

```cs
FormsPlot formsPlot = new() { Dock = DockStyle.Fill };
formsPlot.Reset(plot);
Form form = new();
form.Controls.Add(formsPlot);
/* additional customization goes here */
form.ShowDialog();
```

### WPF

Users desiring advanced customization may benefit from creating a `Window` from scratch, styling it as desired, and adding a `WpfPlot`, then launching it programmatically:

```cs
ScottPlot.WPF.WpfPlot wpfPlot = new();
wpfPlot.Reset(plt);
System.Windows.Window win = new() { Content = wpfPlot };
/* additional customization goes here */
win.ShowDialog();
```