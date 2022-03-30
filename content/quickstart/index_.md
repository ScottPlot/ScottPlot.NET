---
Title: ScottPlot Quickstart
Description: Plot data with a few lines of C#
url: "quickstart"
url: /quickstart
---

## Quickstart by Application Type

* [**ScottPlot Quickstart - Windows Forms**](winforms)

* [**ScottPlot Quickstart - WPF**](wpf)

* [**ScottPlot Quickstart - Avalonia**](avalonia)

* [**ScottPlot Quickstart - Eto**](eto)

* [**ScottPlot Quickstart - Console Application**](console)

## ScottPlot Quickstart

```cs
double[] dataX = new double[] { 1, 2, 3, 4, 5 };
double[] dataY = new double[] { 1, 4, 9, 16, 25 };
var plt = new ScottPlot.Plot(400, 300);
plt.AddScatter(dataX, dataY);
plt.SaveFig("quickstart.png");
```

![](console/scottplot-quickstart-console.png)