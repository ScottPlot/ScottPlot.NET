---
Title: Button Behavior - ScottPlot FAQ
Description: How to customize actions of the left, right, or middle mouse buttons in interactive ScottPlot controls
---

ScottPlot controls map user inputs (left-click-drag, scroll wheel up, etc.) with plot actions (pan, zoom in, etc.) in the code of the user control. This means that changing these behaviors is typically achieved at the level of the user control (not the `Plot` inside it). 

### ScottPlot 4

ScottPlot 4 has a rigid user input map that can only be modified in predefined ways using a predefined collection of configuration settings.
  
  * Controls have a `Configuration` property with many customizations to enable, disable, or customize zooming, panning, and other interactions. See the [User Control Configuration page](../configuration/) for additional information.

  * Advanced modifications to user input behavior requires copy/pasting [FormsPlot.cs](https://github.com/ScottPlot/ScottPlot/blob/main/src/ScottPlot4/ScottPlot.WinForms/FormsPlot.cs) into your own custom control, and editing the source code that maps control events with plot actions.

### ScottPlot 5

ScottPlot 5 has an flexible user input map that can be totally customized by the user.

Additional information will be provided after ScottPlot 5 is released.