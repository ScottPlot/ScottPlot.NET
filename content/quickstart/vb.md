---
Title: Visual Basic Quickstart
Description: How to plot data using ScottPlot in a VB.NET application
date: 2023-12-13
url: /quickstart/vb/
---

{{< banner-sp5 >}}

# Visual Basic Quickstart

**Step 1:** Install the [`ScottPlot`](https://www.nuget.org/packages/ScottPlot) NuGet package

**Step 2:** Plot some data and save the figure as an image file

{{< code-sp5 >}}

```vb
Dim xs = New Double() { 1, 2, 3, 4, 5 }
Dim ys = New Double() { 1, 4, 9, 16, 25 }

Dim plt = New ScottPlot.Plot()
plt.Add.Scatter(xs, ys)

plt.SaveFig("quickstart.png")
```

{{< /code-sp5 >}}

![](/images/quickstart/scottplot-quickstart-console.png)

## Visual Basic Windows Forms App

**Step 1:** Install the [`ScottPlot`](https://www.nuget.org/packages/ScottPlot) NuGet package

**Step 2:** Drag a `FormsPlot` control from the toolbox onto your Form

**Step 3:** Plot some data and call the control's `Refresh()` method

{{< code-sp5 >}}

```vb
Public Class Form1
    Public Sub New()
        InitializeComponent()

        Dim xs = New Double() { 1, 2, 3, 4, 5 }
        Dim ys = New Double() { 1, 4, 9, 16, 25 }

        Dim plt = New ScottPlot.Plot()
        FormsPlot1.Plot.Add.Scatter(xs, ys)
        FormsPlot1.Refresh();
    End Sub
End Class
```

{{< /code-sp5 >}}

![](/images/quickstart/scottplot-quickstart-winforms.png)