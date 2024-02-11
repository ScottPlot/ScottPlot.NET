---
title: ScottPlot dependencies - ScottPlot FAQ
description: ScottPlot's Dependencies and their Implications
date: 2023-12-13
---

{{< banner-sp5 >}}

{{< specific-sp4 >}}

# ScottPlot Dependencies

**ScottPlot 4 depends on the [System.Drawing.Common package](https://www.nuget.org/packages/System.Drawing.Common/) to render plots.** This has special considerations for modern .NET projects depending on which operating system is being targeted.

## Windows

Applications targeting .NET 6 and newer may produce the following message:

```
Warning	CA1416	This call site is reachable on all platforms. 
'FormsPlot.Plot' is only supported on: 'Windows' 7.0 and later.	
```

**To fix this warning:** edit your .csproj file to target `.net6.0-windows`

## Linux & MacOS

Non-Windows users must take the following steps to enable System.Drawing.Common rendering support:

**Step 1:** Install [libgdiplus](https://www.mono-project.com/docs/gui/libgdiplus/)

* **Linux:** `apt-get install -y libgdiplus`

* **MacOS:** `brew install mono-libgdiplus`

**Step 2:** Manually add the `System.Drawing.Common` package to your project:

* `dotnet add package System.Drawing.Common`

**Step 3:** Follow Microsoft's [recommended action](https://docs.microsoft.com/en-us/dotnet/core/compatibility/core-libraries/6.0/system-drawing-common-windows-only#recommended-action) and edit `runtimeconfig.json` to `EnableUnixSupport`.

**Step 4:** Ensure your project does not include a version of `System.Drawing.Common` newer than `5.x` because [newer versions of System.Drawing.Common are not supported on non-Windows systems](https://learn.microsoft.com/en-us/dotnet/core/compatibility/core-libraries/6.0/system-drawing-common-windows-only)

## Docker

Docker users can find additional information in [#2366](https://github.com/ScottPlot/ScottPlot/issues/2366) and [#1677](https://github.com/ScottPlot/ScottPlot/issues/1677)

## ScottPlot 5

ScottPlot 5 does not depend on `System.Drawing.Common`, so the concerns above concerns do not apply.

Linux users that find runtime errors like _System.DllNotFoundException: Unable to load shared library 'libSkiaSharp' or one of its dependencies_ or _libSkiaSharp.so: cannot open shared object file_ may benefit from adding the [`SkiaSharp.NativeAssets.Linux.NoDependencies` NuGet package](https://www.nuget.org/packages/SkiaSharp.NativeAssets.Linux.NoDependencies/) to their project in addition to the ScottPlot package.

```xml
<ItemGroup>
    <PackageReference Include="ScottPlot" Version="5.0.21" />
    <PackageReference Include="SkiaSharp.NativeAssets.Linux.NoDependencies" Version="2.*" />
</ItemGroup>
```

The following packages may also be useful to install on non-Windows systems:

```
apt-get update
apt-get install -y libfreetype6
apt-get install -y libfontconfig1
apt-get install -y fontconfig
```
