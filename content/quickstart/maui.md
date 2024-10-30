---
Title: .NET Maui Quickstart
description: How to create an interactive plot using ScottPlot in a .NET Maui application
date: 2024-10-12
---

# .NET Maui Quickstart

**Step 0:** Create a new .NET MAUI App

**Step 1**: Install the [`ScottPlot.Maui`](https://www.nuget.org/packages/ScottPlot.Maui) NuGet package. Linux & MacOS users must follow these [additional steps](https://scottplot.net/faq/dependencies/).

**Step 2**: Add the following to your `MauiProgram.cs` file:

```cs
using SkiaSharp.Views.Maui.Controls.Hosting;
```

```csharp
var builder = MauiApp.CreateBuilder();
builder
    .UseMauiApp<App>()
    .UseSkiaSharp()
        ...
```

**Step 3**: Edit your `.csproj` file to define a SDK version explicitly if developing for Windows:
```xml
<Project Sdk="Microsoft.NET.Sdk">
    <PropertyGroup>
        <WindowsSdkPackageVersion>10.0.19041.34</WindowsSdkPackageVersion>
		<TargetFrameworks>net8.0-windows10.0.19041.0</TargetFrameworks>
            ...
```

**Step 4**: Edit your `.xaml` file to add the `ScottPlot.Maui` namespace:

```xml
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:ScottPlot="clr-namespace:ScottPlot.Maui;assembly=ScottPlot.Maui"
        ... 
```

**Step 5**: Add a `MauiPlot` to your layout and give it a unique name:
```xml
<ScottPlot:MauiPlot x:Name="MauiPlot1" />
```

**Step 6**: Plot some data in your start-up sequence:
```csharp
double[] dataX = { 1, 2, 3, 4, 5 };
double[] dataY = { 1, 4, 9, 16, 25 };

MauiPlot1.Plot.Add.Scatter(dataX, dataY);
MauiPlot1.Refresh();
```

**Tip:** The .NET Maui app may be launched from the command window using the following command:

```
dotnet run -f net8.0-windows10.0.19041.0 -p:WindowsPackageType=None
```
