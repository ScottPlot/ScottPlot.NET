---
title: Reproducible Code Examples
description: Recommendations for preparing executable code samples that can facilitate resolving issues or answering questions.
---

**Sharing a reproducible code example with an issue or question increases the likelihood that it will be addressed rapidly and accurately.** Questions with absent or incomplete code examples are unlikely to receive an accurate or timely responses, and may even be closed the labor required to reproduce the issue is high. This page describes strategies for creating code examples that are easy for others to run and evaluate.

## Static Plot

**The preferred method for sharing ScottPlot code examples** is to create a new .NET Console Application that demonstrates the topic and saves the result as an image.


**Step 1:** Create a new .NET console project

**Step 2:** Add the ScottPlot NuGet package

**Step 3:** Create a plot and save it as an image
```cs
ScottPlot.Plot plt = new();

// use code to express information related to the the discussion
plt.AddSignal(ScottPlot.Generate.Sin());
plt.AddSignal(ScottPlot.Generate.Cos());

plt.SaveFig("demo.png");
```

**Share:** Copy and paste the code along with the image it produced. Use [syntax highlighting for code blocks](https://docs.github.com/en/get-started/writing-on-github/working-with-advanced-formatting/creating-and-highlighting-code-blocks) when posting GitHub Issues and Discussions to improve readability.

## Interactive Plot

**If your topic relates to mouse interactivity, it may be necessary to demonstrate it using a GUI.** The preferred method is to create a .NET Console Application that launches Windows Form containing a ScottPlot.

**Step 1:** Create a new .NET console project 

**Step 2:** Add the ScottPlot and ScottPlot.WinForms NuGet packages

**Step 3:** Modify the csproj file's property group to support Windows Forms

```xml
<OutputType>Exe</OutputType>
<TargetFramework>net6.0-windows</TargetFramework>
<ImplicitUsings>enable</ImplicitUsings>
<Nullable>enable</Nullable>
<UseWindowsForms>true</UseWindowsForms>
```

**Step 4:** Create a plot and display it interactively

```cs
// create a plot
ScottPlot.Plot plt = new();
plt.AddSignal(ScottPlot.Generate.Sin());
plt.AddSignal(ScottPlot.Generate.Cos());

// display it in a Windows Form
Form form = new() { Width = 600, Height = 400 };
ScottPlot.FormsPlot formsPlot1 = new() { Dock = DockStyle.Fill };
formsPlot1.Reset(plt);
formsPlot1.Refresh();
form.Controls.Add(formsPlot1);
form.ShowDialog();
```

**Share:** This code can be copy/pasted to share with others and is easy to run and evaluate. Use [syntax highlighting for code blocks](https://docs.github.com/en/get-started/writing-on-github/working-with-advanced-formatting/creating-and-highlighting-code-blocks) when posting GitHub Issues and Discussions to improve readability.

**Tip:** Consider sharing an animation that demonstrates the interactive behavior. [ScreenToGif](https://www.screentogif.com/) can be used to capture a portion of the screen and save it as an animated GIF that can be included in GitHub Issues and Discussions. For more advanced situations [OBS Studio](https://obsproject.com/) can be used to record your screen (with optional narration) and MP4 files are supported by GitHub.

## Advanced Applications

Although the majority of issues can be reproduced using strategies described above, extremely complex GUI-related topics may require developers to create a new .NET projects to evaluate them. If this is the case, provide all steps required for a developer to reproduce the issue from scratch. The code should be complete such that another developer can evaluate it by following these steps:

* Create a new WinForms (or WPF, Avalonia, etc.) project from scratch
* Copy/Paste code from your issue directly into the new project
* Press F5 to launch the program and evaluate the issue

**Tips:**
* Note any manual actions required (e.g., drag/drop a Button onto the Form)
* Consider sharing content of the `.csproj` file
* Consider sharing `.xaml` code along with the `.cs` source
* Use [syntax highlighting for code blocks](https://docs.github.com/en/get-started/writing-on-github/working-with-advanced-formatting/creating-and-highlighting-code-blocks) when posting GitHub Issues and Discussions to improve readability.

## Unit Tests

**Issues paired with pull requests containing failing unit tests** make it easier for developers to evaluate the topic and respond quickly with solutions. Although unit tests are not required for new issues or pull requests, developers comfortable with unit testing are welcome to commit failing tests to facilitate communication and increase likelihood that their issue will be adequately resolved.