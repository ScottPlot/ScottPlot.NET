---
Title: ScottPlot Versions
Description: Information about the major ScottPlot versions
url: /versions/index.html
date: 2023-12-13
---

# ScottPlot Versions

**ScottPlot 4.1 is the current stable version of ScottPlot** recommended for new users and production applications. It is actively developed and maintained in parallel with ScottPlot 5.

**ScottPlot 5.0 beta is an experimental version of ScottPlot** available as a preview package on NuGet, buts its API is not yet finalized and it is currently not recommended for production use.

> 💡 **Why ScottPlot 5?** ScottPlot 4 was created using the cross-platform `System.Drawing.Common` graphics library for rendering, but then Microsoft ended cross-platform support for this package, motivating creation of a new version of ScottPlot using a different graphics library (SkiaSharp). This transition required numerous breaking changes to ScottPlot's API, so the major version was incremented and learnings from the last several years of ScottPlot 4 development and support were channelled into creating ScottPlot 5 with improved performance, better cross-platform support, additional features, and a simpler API.

## Features by Version

* [What’s New in ScottPlot 4.1](/faq/version-4.1/)
* [What’s New in ScottPlot 5.0](/faq/version-5.0/)

<div class="text-center"><div class="d-inline-block">

Feature | ScottPlot 5 | ScottPlot 4 | ScottPlot 3
---|---|---|---
Release | ❌ preview | ✔️ stable | ⚠️ obsolete
Performance | 🚀🚀🚀 | 🚀 | 🚀
Graphics | SkiaSharp | System.Drawing.Common | System.Drawing.Common
Windows | ✔️ | ✔️
Linux | ✔️ | ⚠️ only .NET 6 | ❌
MacOS | ✔️ | ⚠️ only .NET 6 | ❌
.NET Framework | ✔️ ≥4.6.2 | ✔️ ≥4.6.2 | ✔️ ≥4.5
.NET Core | ✔️ ≥4.6.2 | ✔️ ≥4.6.2 | ❌
Nullable annotations | ✔️ | ❌ | ❌
Windows Forms | ✔️ | ✔️ | ✔️
WPF | ✔️ | ✔️ | ❌
Avalonia | ✔️ | ✔️ | ❌
Eto Forms | ✔️ | ✔️ | ❌
Browser | ✔️ | ❌ | ❌
WinUI | ✔️ | ❌ | ❌
Android | ✔️ | ❌ | ❌

</div></div>
