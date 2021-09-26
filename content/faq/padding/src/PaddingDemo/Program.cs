using System;
using System.Linq;

// create a sample plot tightly fitted to the data
var plt = new ScottPlot.Plot(600, 400);
plt.AddSignal(ScottPlot.DataGen.Sin(51));
plt.AddSignal(ScottPlot.DataGen.Cos(51));
plt.Style(ScottPlot.Style.Light2);

// save an image showing the default padding
plt.SaveFig("padding-default.png");

// add additional padding around all axes
plt.Layout(padding: 50);
plt.SaveFig("padding-custom.png");

// define the minimum size for each axis individually
plt.Layout(left: 100, right: 50, bottom: 10, top: 10);
plt.SaveFig("padding-defined.png");

// disable visibility of all axes
plt.Frameless();
plt.SaveFig("padding-none.png");

// disable visibility of all axes with no margin
plt.Frameless();
plt.AxisAuto(0, 0);
plt.SaveFig("padding-none-tight.png");