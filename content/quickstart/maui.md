---
Title: .NET Maui Quickstart
description: How to create an interactive plot using ScottPlot in a .NET Maui application
date: 2024-10-12
---

# .NET Maui Quickstart

**Step 1:** Create a new .NET MAUI App

**Step 2**: Install the [`ScottPlot.Maui`](https://www.nuget.org/packages/ScottPlot.Maui) NuGet package.

**Step 3**: Edit `MauiProgram.cs` to `UseScottPlot()` at startup:

```csharp
builder
    .UseMauiApp<App>()
    .UseScottPlot() // ADD THIS LINE
        ...
```

**Step 4**: Edit `MainPage.xaml` to look add a `MauiPlot` control:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:ScottPlot="clr-namespace:ScottPlot.Maui;assembly=ScottPlot.Maui"
             x:Class="MauiApp5.MainPage">
    <ScottPlot:MauiPlot x:Name="MauiPlot1" />
</ContentPage>
```

**Step 5**: Edit `MainPage.xaml.cs` to setup the plot in the start-up sequence
```csharp
public MainPage()
{
    InitializeComponent();

    // create a scatter plot with sample data
    double[] dataX = { 1, 2, 3, 4, 5 };
    double[] dataY = { 1, 4, 9, 16, 25 };
    MauiPlot1.Plot.Add.Scatter(dataX, dataY);

    // increase scale factor for high resolution displays
    MauiPlot1.Plot.ScaleFactor = 3; 
    MauiPlot1.Refresh();
}
```

![](/images/quickstart/android.png)

## Notes for Windows Desktop

Builds targeting Windows Desktop may require `WindowsSdkPackageVersion` to be defined ([read more](https://learn.microsoft.com/en-us/windows/apps/windows-app-sdk/stable-channel#c-project-changes-1))

```xml
<Project Sdk="Microsoft.NET.Sdk">
	<PropertyGroup>
		<WindowsSdkPackageVersion>10.0.19041.34</WindowsSdkPackageVersion>
                ...
```

A .NET Maui targeting Windows Desktop app may be launched from the command line like this:

```sh
dotnet run -f net8.0-windows10.0.19041.0 -p:WindowsPackageType=None
```
