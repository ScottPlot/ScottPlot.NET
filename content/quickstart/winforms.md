---
Title: Windows Forms Quickstart
description: How to create an interactive plot in a C# Windows Forms application
date: 2021-09-26
---

# Windows Forms Quickstart

**Step 1:** Install the [`ScottPlot.WinForms`](https://www.nuget.org/packages/ScottPlot.WinForms) NuGet package

**Step 2:** Drag a `FormsPlot` from the Toolbox onto your Form

_Note: If `FormsPlot` does not appear in the Visual Studio Toolbox or it produces an error when used, [add a FormsPlot programmatically](/faq/add-winforms-programmatically/)._

**Step 3:** Plot some data in your start-up sequence

```cs
double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };

formsPlot1.Plot.Add.Scatter(dataX, dataY);
formsPlot1.Refresh();
```

![](/images/quickstart/scottplot-quickstart-winforms.png)
