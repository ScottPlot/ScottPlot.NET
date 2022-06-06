---
Title: PowerShell Quickstart
description: How to plot data from PowerShell using ScottPlot
url: "quickstart/powershell"
---


**Step 1: Get PowerShell Core** 

* Do not use Windows PowerShell
* PowerShell Core can run on Windows, Linux, and MacOS
* Download from https://github.com/PowerShell/PowerShell

**Step 2: Build an empty .NET app using ScottPlot**

* `dotnet new console`
* `dotnet add package scottplot`
* `dotnet build`

**Step 3: Create a PowerShell script**
* Enter the builder folder containing `ScottPlot.dll`
* Create `myScript.ps1` and copy the following contents into it
* Run the script using PowerShell Core (not Windows PowerShell)

```ps1
Add-Type -Path .\ScottPlot.dll
[double[]] $dataX = @( 1, 2, 3, 4, 5 )
[double[]] $dataY = @( 1, 4, 9, 16, 25 )
$plt = [ScottPlot.Plot]::new(400, 300)
[Void] $plt.AddScatter($dataX, $dataY)
[Void] $plt.SaveFig("$pwd\quickstart.png")
```

![](../console/scottplot-quickstart-console.png)
