---
Title: Visual Basic Quickstart
Description: How to plot data using ScottPlot in a VB.NET application
date: 2023-12-13
---

# Visual Basic Quickstart

**Step 1:** Install the [`ScottPlot`](https://www.nuget.org/packages/ScottPlot) NuGet package

**Step 2:** Plot some data and save the figure as an image file

```vb
Dim xs = New Double() { 1, 2, 3, 4, 5 }
Dim ys = New Double() { 1, 4, 9, 16, 25 }

Dim plt = New ScottPlot.Plot()
plt.Add.Scatter(xs, ys)

plt.SavePng("quickstart.png", 600, 400)
```

![](/images/quickstart/scottplot-quickstart-console.png)

## Visual Basic Windows Forms App

**Step 1:** Install the [`ScottPlot.WinForms`](https://www.nuget.org/packages/ScottPlot.WinForms) NuGet package

**Step 2:** Drag a `FormsPlot` control from the toolbox onto your Form

**Step 3:** Plot some data and call the control's `Refresh()` method

```vb
Public Class Form1
    Public Sub New()
        InitializeComponent()

        Dim xs = New Double() { 1, 2, 3, 4, 5 }
        Dim ys = New Double() { 1, 4, 9, 16, 25 }

        Dim plt = New ScottPlot.Plot()
        FormsPlot1.Plot.Add.Scatter(xs, ys)
        FormsPlot1.Refresh()
    End Sub
End Class
```

![](/images/quickstart/scottplot-quickstart-winforms.png)

## Visual Basic WPF App

Install the [`ScottPlot.WPF`](https://www.nuget.org/packages/ScottPlot.WPF) NuGet package then modify your code to resemble the following:

```xaml
<Window x:Class="MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfApp12" 
        xmlns:ScottPlot="clr-namespace:ScottPlot.WPF;assembly=ScottPlot.WPF"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
    <ScottPlot:WpfPlot x:Name="WpfPlot1" />
</Window>
```

```vb
Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Dim xs = New Double() {1, 2, 3, 4, 5}
        Dim ys = New Double() {1, 4, 9, 16, 25}
        WpfPlot1.Plot.Add.Scatter(xs, ys)
        WpfPlot1.Plot.Axes.AutoScale()
        WpfPlot1.Refresh()
    End Sub
End Class
```
