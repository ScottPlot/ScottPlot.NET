:: GitHub Actions checks-out the latest ScottPlot from the web.
:: This script copies it from a local source.
rmdir %~dp0\..\ScottPlot\src\ /s /q
xcopy %~dp0\..\..\ScottPlot\src\ %~dp0\..\ScottPlot\src\ /E/H