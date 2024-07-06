---
Title: Eto Quickstart
date: 2021-12-29
description: How to create an interactive plot in a C# Eto application
---

# Eto Quickstart

**Step 1:** Create a new .NET console application

**Step 2:** Install the following NuGet packages:
* [`Eto.Forms`](https://www.nuget.org/packages/Eto.Forms)
* [`Eto.Platform.Wpf`](https://www.nuget.org/packages/Eto.Platform.Wpf)
* [`ScottPlot.Eto`](https://www.nuget.org/packages/ScottPlot.Eto)

_Linux & MacOS may need to [take additional steps](/faq/dependencies)_

**Step 3:** Create `MainWindow.cs` and add the following:

```cs
partial class MainWindow : Eto.Forms.Form
{
    private readonly ScottPlot.Eto.EtoPlot EtoPlot1 = new();

    public MainWindow()
    {
        InitializeComponent();

        EtoPlot1.Plot.Add.Signal(ScottPlot.Generate.Sin());
        EtoPlot1.Plot.Add.Signal(ScottPlot.Generate.Cos());
    }

    private void InitializeComponent()
    {
        Content = EtoPlot1;
        Width = 800;
        Height = 600;
    }
}
```

**Step 4:** Edit `Program.cs` to contain the following:

```cs
static class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        new Eto.Forms.Application(Eto.Platform.Detect).Run(new MainWindow());
    }
}
```

## Screenshots

<div class="container">
    <div class="row">
        <div class="col-md">
            <h3>WPF</h3>
            <a href="/images/quickstart/eto-quickstart-wpf.png"><img src="/images/quickstart/eto-quickstart-wpf.png"></a>
        </div>
        <div class="col-md">
            <h3>GTK</h3>
            <a href="/images/quickstart/eto-quickstart-gtk.png"><img src="/images/quickstart/eto-quickstart-gtk.png"></a>
        </div>
        <div class="col-md">
            <h3>OSX</h3>
            <a href="/images/quickstart/eto-quickstart-osx.png"><img src="/images/quickstart/eto-quickstart-osx.png"></a>
        </div>
    </div>
</div>