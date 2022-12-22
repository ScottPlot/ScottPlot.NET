---
title: Tagging - ScottPlot FAQ
description: How to pair plottables with custom objects
---

**Windows Forms controls have a [Tag property](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.tag) to allow users to store arbitrary `object` references.** ScottPlot controls and plottables intentionally do not have such a property. Plottables have public properties used to store styling and data configuration information, but storing additional unrelated state inside plottables is not advised.

**Instead, users are encouraged to create their own data structures to pair plottables with the custom objects unique to their application.** A [`Dictionary`](https://www.tutorialsteacher.com/csharp/csharp-dictionary) works well here, as the `key` can be the plottable object and the `value` can be whatever object the developer is interested in keeping track of. Here is a Windows Forms application demonstrating this concept:

```cs
public partial class Form1 : Form
{
    // this dictionary pairs plotted objects with custom objects
    readonly Dictionary<IPlottable, string> SpecialValues = new();
    
    public Form1()
    {
        InitializeComponent();
    
        // create plottables and add them to a dictionary, paring each with a special value
        SpecialValues.Add(formsPlot1.Plot.AddVerticalLine(0, Color.Red), "apple");
        SpecialValues.Add(formsPlot1.Plot.AddVerticalLine(1, Color.Blue), "grape");
        SpecialValues.Add(formsPlot1.Plot.AddVerticalLine(2, Color.Yellow), "banana");
    
        // enable dragging for all draggables
        formsPlot1.Plot.GetPlottables().OfType<IDraggable>().ToList().ForEach(x => x.DragEnabled = true);
    
        // call a function whenever a draggable is dropped
        formsPlot1.PlottableDropped += FormsPlot1_PlottableDropped;

        // refresh the screen once on load
        formsPlot1.Refresh();
    }
    
    private void FormsPlot1_PlottableDropped(object sender, EventArgs e)
    {
        IPlottable draggedPlottable = (IPlottable)sender;
    
        if (!SpecialValues.ContainsKey(draggedPlottable))
            return;
    
        // get the custom object for this plottable out of the dictionary
        string specialValue = SpecialValues[draggedPlottable];
        MessageBox.Show($"You just dropped: {specialValue}");
    }
}
```