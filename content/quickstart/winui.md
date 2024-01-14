---
Title: WinUI Quickstart
description: How to create an interactive plot using ScottPlot in a WinUI application
date: 2023-07-04
---

{{< banner-sp5 >}}

# WinUI Quickstart

**Step 1:** Create a new WinUI project: `Blank App, Packaged (WinUI 3 in Desktop)`

**Step 2:** Upgrade the `Microsoft.WindowsAppSDK` to the latest (non-prerelease) version

**Step 3:** Install the [ScottPlot.WinUI](https://www.nuget.org/packages/ScottPlot.WinUI/) NuGet package

**Step 4:** In the solution explorer, right-click the app, and select properties. In the Application settings (General section) set the "Target OS version" to `10.0.22200.0` or later.

**Step 5:** Edit `MainWindow.xaml` to reference the `ScottPlot.WinUI` package and add a `WinUIPlot` control to the window

```xml
<?xml version="1.0" encoding="utf-8"?>
<Window
    x:Class="QuickstartApp.MainWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:QuickstartApp"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    xmlns:ScottPlot="using:ScottPlot.WinUI"
    mc:Ignorable="d">

    <ScottPlot:WinUIPlot x:Name="WinUIPlot1"/>
</Window>
```

**Step 6:** Edit `MainWindow.xaml.cs` to add data to the plot and initiate a render

{{< code-sp5 >}}

```cs
using Microsoft.UI.Xaml;
using ScottPlot;

namespace QuickstartApp;

public sealed partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        WinUIPlot1.Plot.Add.Signal(Generate.Sin(51));
        WinUIPlot1.Plot.Add.Signal(Generate.Cos(51));
        WinUIPlot1.Refresh();
    }
}
```

{{< /code-sp5 >}}

![](/images/quickstart/scottplot-winui-quickstart.png)