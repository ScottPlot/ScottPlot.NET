---
Title: ScottPlot Versions
Description: Information about the major ScottPlot versions
url: "versions"
---

**ScottPlot 4.1 is the current stable version of ScottPlot** recommended for new users and production applications.

<code>ScottPlot 5.0 beta</code> is an experimental version of ScottPlot available on NuGet as a preview package.

> 💡 **Why ScottPlot 5?** ScottPlot 4 was created using the cross-platform `System.Drawing.Common` graphics library for rendering, but then Microsoft ended cross-platform support for this package, motivating creation of a new version of ScottPlot using a different graphics library (SkiaSharp). This transition required numerous breaking changes to ScottPlot's API, so the major version was incremented and learnings from the last several years of ScottPlot 4 development and support were channelled into creating ScottPlot 5 with improved performance, better cross-platform support, additional features, and a simpler API.

## ScottPlot Version Chart

<div class="text-center"><div class="d-inline-block">

Feature | ScottPlot 5 | ScottPlot 4 | ScottPlot 3
---|---|---|---
Stable API | ❌ | ✔️ | ⚠️ obsolete
Performance | 🚀🚀🚀 | 🚀 | 🚀
Graphics | SkiaSharp | System.Drawing.Common | System.Drawing.Common
Windows | ✔️ | ✔️
Linux | ✔️ | ⚠️ only .NET 6 | ❌
MacOS | ✔️ | ⚠️ only .NET 6 | ❌
.NET Framework | ✔️ ≥4.6.2 | ✔️ ≥4.6.2 | ✔️ ≥4.5
Nullable annotations | ✔️ | ❌ | ❌

</div></div>