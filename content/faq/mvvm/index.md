---
Title: MVVM and Data Binding - ScottPlot FAQ
Description: ScottPlot in the context of Model–View–ViewModel (MVVM) and Data Binding Patterns
---

# MVVM and Data Binding

**Many charting libraries use MVVM and data binding patterns to interact with plots. ScottPlot does not.** This intentional decision allows ScottPlot to be more performant by giving the user raw access to array values used for plotting, and also enabling users to have total control over when new frames are rendered (a potentially costly operation). Although MVVM pattern and data binding are often useful when designing interactive GUI applications, consider that virtually all ScottPlot functionality can be used to create static images from headless console applications where these patterns are less widely used.

**MVVM and data binding patterns can be used to create graphical controls that wrap ScottPlot plots.** Users who strongly desire to use data binding or MVVM patterns are probably working in a platform-specific GUI development framework (such as WPF) and only want to create a control to accomplish a single task (such as an interactive scatter plot with a specific style and layout). These users are encouraged to write their own user control to achieve this custom data-handling and rendering functionality. The ScottPlot controls have been designed to be extremely simple (only about 100 lines), and users who want to couple data management with graphical interactivity are encouraged to write their own controls using their pattern of choice.

## User Control Source Code

**The ScottPlot controls mostly just pass mouse actions to ScottPlot (a GUI-agnostic .NET Standard library), render a Bitmap, and display the image.** It should be an easy task to create a custom control that exposes data (in a format that will be highly specific for your application) and uses events to invoke rendering after data changes. Although this is easy it implement, it is also easy to implement with poor performance, so the developer is encouraged to keep careful track of how often renders are performed.

* WPF: [WpfPlot.xaml.cs](https://github.com/ScottPlot/ScottPlot/blob/master/src/controls/ScottPlot.WPF/WpfPlot.xaml.cs) / [WpfPlot.xaml](https://github.com/ScottPlot/ScottPlot/blob/master/src/controls/ScottPlot.WPF/WpfPlot.xaml)

* WinForms: [FormsPlot.cs](https://github.com/ScottPlot/ScottPlot/blob/master/src/controls/ScottPlot.WinForms/FormsPlot.cs)