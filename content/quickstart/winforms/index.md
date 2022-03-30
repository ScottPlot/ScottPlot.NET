---
Title: Windows Forms Quickstart
url: "quickstart/winforms"
description: How to create an interactive plot in a C# Windows Forms application
date: 2021-09-26
---

**Step 1:** Install the [`ScottPlot.WinForms`](https://www.nuget.org/packages/ScottPlot.WinForms) NuGet package

**Step 2:** Drag a `FormsPlot` from the Toolbox onto your Form

**Step 3:** Plot some data in your start-up sequence

```cs
double[] dataX = new double[] {1, 2, 3, 4, 5};
double[] dataY = new double[] {1, 4, 9, 16, 25};
formsPlot1.Plot.AddScatter(dataX, dataY);
formsPlot1.Refresh();
```

![](scottplot-quickstart-winforms.png)
