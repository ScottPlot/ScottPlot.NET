---
title: History of ScottPlot - ScottPlot FAQ
description: Where did ScottPlot come from and who is Scott?
---

**Hi, I'm Scott!** I'm a biological research scientist, but I occasionally write code to accomplish science-related tasks. You can read more about me here: [swharden.com/about](https://swharden.com/about/)

**Like many scientists, I have experience using [matplotlib](https://matplotlib.org) for Python.** Matplotlib is a fantastic plotting library and is very easy to learn. Unfortunately, it can be difficult to distribute Python applications that run easily on other peoples computers (especially if they are not strong computer users). Managing interpreter versions, setting up dev environments, and debugging dependency errors is beyond the scope of capabilities for most non-programmers who just want to run a program to analyze some data. In 2017 I decided to learn C# and the .NET stack to improve my ability to make scientific desktop applications.

**I tried to plot data from a WAV file with C# and found it was surprisingly difficult.** This trivial task in Python seemed prohibitively difficult in C#. There were free charting libraries, but they choked when I loaded tens of millions of points. There were commercial charting libraries which seemed like they could handle the task, but they were complex and expensive. Some libraries were WinForms only, some were WPF only, and many had complex data object models that were extremely difficult for someone new to .NET to understand. I implemented my own simple solution using native libraries, and after a few years of incremental refinement and lots of input from the user community ScottPlot grew to have a life of its own!

## What's With the Name?

**When I made ScottPlot, I thought I would be its only user.** I made it open-source so that others could _learn_ from it, but I didn't really intend people to _use_ it out of the box. Many improvements later, and after a great amount of input and contribution from the open-source community, ScottPlot is maturing into a very useful package, but it retains its original silly name.

## ScottPlot Milestones

* **June, 2017:** I first created a 150-line `swhPlot.cs` file that used `System.Drawing` to render a scatter plot onto a `Bitmap`. I found it useful, so I kept using it and incrementally improved it to add features.

* **Jan, 2018:** I used the plotting class in several projects, so I decided to give it its own repository and called it `ScottPlot`. At the time I thought I would be the only one to use it (hence the ridiculous name), but I left it open-source and indicated in the readme it was only to be considered for experimental and educational value.

* **May, 2019:** The first ScottPlot package was uploaded to NuGet. Around this time I decided I'd try harder to keep the API and documentation clean because it was apparent other people had started using it. A few pull requests had come in through GitHub too, which was a surprise but great motivation for me to continue refining this package. I was still pretty new to the .NET stack, but developing and maintaining ScottPlot catalyzed my learning.

* **November, 2019:** ScottPlot stopping being a WinForms-only package and split into separate packages for ScottPlot (.NET Standard), the WinForms control (.NET Framework), and the WPF control (.NET Framework and .NET Core). This new version was ScottPlot 4.0

* **March, 2021:** ScottPlot 4.1 was released which was the result of over a year of focus on internal refactoring to improve performance and add complex features (such as multi-axis support). It also was an opportunity to reflect on the previous few years of emails, pull requests, and hundreds of issue tickets and try to refine the API and improve the documentation to make common difficulties less confusing and more discoverable.