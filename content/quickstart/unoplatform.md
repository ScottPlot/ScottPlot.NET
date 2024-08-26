---
Title: Uno Platform Quickstart
description: How to create an interactive plot using ScottPlot in an Uno Platform application
date: 2024-07-24
---

# Uno Platform Quickstart

**Step 1:** Setup your environment first by following the [QuickStart Get Started instructions for Uno Platform](https://aka.platform.uno/get-started).

**Step 2:** Create a new Blank Uno Platform project by choosing the 'Blank' preset while following these [instructions](https://aka.platform.uno/vs-create-an-app).

**Step 2:** Upgrade the Windows SDK version, `Microsoft.Windows.SDK.NET.Ref` and `Microsoft.WindowsAppSDK` to the latest (non-prerelease) versions supported.

To do that you will need to update the TargetFramework version for Windows and the `WindowsSdkPackageVersion`, `WinAppSdkVersion` properties in your project's `csproj` file.

For example in your `PROJECT_NAME.csproj`:

```xml
<TargetFrameworks>
    <!-- Code for other TargetFrameworks omitted for brevity -->
    net8.0-windows10.0.22621;
</TargetFrameworks>
```

```xml
<PropertyGroup>
    <WindowsSdkPackageVersion>10.0.22621.34</WindowsSdkPackageVersion>
    <WinAppSdkVersion>1.5.240627000</WinAppSdkVersion>
</PropertyGroup>
```

For more detailed information, please see the [Windows SDK references](https://aka.platform.uno/adjusting-windows-sdk-references) and [implicit packages](https://aka.platform.uno/using-uno-sdk#implicit-packages) details.

**Step 3:** Install the [ScottPlot.WinUI](https://www.nuget.org/packages/ScottPlot.WinUI/) NuGet package.

To do that you can use the Nuget Package Manager in Visual Studio or manually:

1. Edit your project file `PROJECT_NAME.csproj` and add the reference:

    ```xml
    <ItemGroup>
        <PackageReference Include="ScottPlot.WinUI" />
    </ItemGroup>
    ```

2. Edit `Directory.Packages.props` and add the reference version:

    ```xml
    <ItemGroup>
        <PackageVersion Include="ScottPlot.WinUI" Version="5.0.36" />
    </ItemGroup>
    ```

**Step 5:** Edit `MainPage.xaml` to reference the `ScottPlot.WinUI` package and add a `WinUIPlot` control to the page.

```xml
<Page x:Class="QuickstartApp.MainPage"
      xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
      xmlns:local="using:QuickstartApp"
      xmlns:ScottPlot="using:ScottPlot.WinUI"
      Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">

  <ScottPlot:WinUIPlot x:Name="WinUIPlot1" />
</Page>
```

**Step 6:** Edit `MainPage.xaml.cs` to add data to the plot and initiate a render

```cs
using ScottPlot;

namespace QuickstartApp;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
        WinUIPlot1.Plot.Add.Signal(Generate.Sin(51));
        WinUIPlot1.Plot.Add.Signal(Generate.Cos(51));
        WinUIPlot1.Refresh();
    }
}
```

## Screenshots

<div class="container">
    <div class="row">
        <div class="col-lg-6">
            <h3>Windows</h3>
            <a href="/images/quickstart/scottplot-winui-quickstart.png" target="_blank" alt="ScottPlot - Uno Platform Quickstart - Windows"><img src="/images/quickstart/scottplot-winui-quickstart.png"></a>
        </div>
        <div class="col-lg-6">
            <h3>WebAssembly</h3>
            <a href="/images/quickstart/unoplatform-quickstart-webassembly.png" target="_blank" alt="ScottPlot - Uno Platform Quickstart - Android"><img src="/images/quickstart/unoplatform-quickstart-webassembly.png"></a>
        </div>
        <div class="col-lg-6">
            <h3>Android</h3>
            <a href="/images/quickstart/unoplatform-quickstart-android.png" target="_blank" alt="ScottPlot - Uno Platform Quickstart - Android"><img src="/images/quickstart/unoplatform-quickstart-android.png"></a>
        </div>
        <div class="col-lg-6">
            <h3>iOS</h3>
            <a href="/images/quickstart/unoplatform-quickstart-iOS.png" target="_blank" alt="ScottPlot - Uno Platform Quickstart - iOS"><img src="/images/quickstart/unoplatform-quickstart-iOS.png"></a>
        </div>
        <div class="col-lg-6">
            <h3>Mac Catalyst</h3>
            <a href="/images/quickstart/unoplatform-quickstart-mac-catalyst.png" target="_blank" alt="ScottPlot - Uno Platform Quickstart - Mac Catalyst"><img src="/images/quickstart/unoplatform-quickstart-mac-catalyst.png"></a>
        </div>
        <div class="col-lg-6">
            <h3>Desktop</h3>
            <a href="/images/quickstart/unoplatform-quickstart-desktop.png" target="_blank" alt="ScottPlot - Uno Platform Quickstart - Desktop"><img src="/images/quickstart/unoplatform-quickstart-desktop.png"></a>
        </div>
        <div class="col-lg-6">
            <h3>Desktop WSL</h3>
            <a href="/images/quickstart/unoplatform-quickstart-desktop-wsl.png" target="_blank" alt="ScottPlot - Uno Platform Quickstart - WSL"><img src="/images/quickstart/unoplatform-quickstart-desktop-wsl.png"></a>
        </div>
    </div>
</div>

## What is the Uno Platform?

The Uno Platform is an [Open-source platform](https://github.com/unoplatform/uno) for building single codebase native mobile, web, desktop and embedded apps quickly.

- Flexible: Your choice of OS (Windows, macOS, Linux), IDE (Visual Studio, VS Code, JetBrains Rider, Codespaces/Gitpod), state management, design systems. Use only what works for you.

- Productive: Visual Studio, VS Code, JetBrains Rider XAML & C# Hot Reload built-in. One-click Figma design exports.

- Rich: Reuse 100’s of .NET UI components or 1st party native controls for beautiful apps.

- Beautiful: Pixel-perfect, Material, Fluent or Cupertino-themed apps on all platforms.

Visit their [website](https://platform.uno/) and [documentation](https://aka.platform.uno/uno-docs-intro) for more details.

## Uno Platform Support
If you have questions about the Uno Platform, they have an engineering team and community that can help!
* Uno Platform website: [Frequently Asked Quetsions (FAQ)](https://aka.platform.uno/uno-faq)
* Uno Platform on GitHub: [create an issue](https://github.com/unoplatform/uno/issues) or [start a discussion](https://github.com/unoplatform/uno/discussions) 
* [Uno Platform Discord Server](https://discord.com/invite/XjsmQHdKfq) (all are welcome!)