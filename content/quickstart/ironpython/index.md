---
Title: IronPython Quickstart
description: How to plot data using ScottPlot using IronPython
url: "quickstart/ironpython"
date: 2023-12-13
---

# IronPython Quickstart

**Step 1:** Setup IronPython according to instructions on https://ironpython.net (full installation including GAC)

**Step 2:** Get the latest ScottPlot NuGet package
  * Download the `.nupkg` file from https://www.nuget.org/packages/ScottPlot/ 
  * Rename the file to `.zip` and extract its contents
  * Place ScottPlot.dll in the same directory as your python script

**Step 3:** Create a python script to plot data and save the output as an image

```py
import clr
clr.AddReference("ScottPlot.dll")   
clr.AddReferenceByPartialName("System.Drawing")
import ScottPlot

dataX = (0, 0, 415, 483, 526, 505, 511, 367, 452, 0)
dataY = (4209, 3367, 2553, 1960, 1532, 913, 862, 0, 0, -1487)

myPlot = ScottPlot.Plot(500,500)
myPlot.AddScatter(dataX, dataY)
myPlot.Title("RC Column Interaction Diagram")
myPlot.XLabel("phi*Mn (kN.m)")
myPlot.YLabel("phi*Pn (kN)")
myPlot.AddHorizontalLine(0,width=3)
myPlot.AddVerticalLine(0,width=3)

myPlot.SaveFig("ironpython.png")
```

![](/images/plots/ironpython.png)

## Additional Resources

* https://github.com/ScottPlot/ScottPlot/discussions/2946