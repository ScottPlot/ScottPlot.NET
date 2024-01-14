---
title: History of ScottPlot - ScottPlot FAQ
description: Where did ScottPlot come from and who is Scott?
date: 2023-12-13
---

{{< banner-sp5 >}}

{{< specific-sp4 >}}

# History of ScottPlot

**Hi, I'm Scott!** I'm a biological research scientist, but I occasionally write code to accomplish science-related tasks. You can read more about me here: [swharden.com/about](https://swharden.com/about/)

**Like many scientists, I have experience using [matplotlib](https://matplotlib.org) for Python.** Matplotlib is a fantastic plotting library and is very easy to learn. Unfortunately, it can be difficult to distribute Python applications that run easily on other peoples computers (especially if they are not strong computer users). Managing interpreter versions, setting up dev environments, and debugging dependency errors is beyond the scope of capabilities for most non-programmers who just want to run a program to analyze some data. In 2017 I decided to learn C# and the .NET stack to improve my ability to make scientific desktop applications.

**I tried to plot data from a WAV file with C# and found it was surprisingly difficult.** This trivial task in Python seemed prohibitively difficult in C#. There were free charting libraries, but they choked when I loaded tens of millions of points. There were commercial charting libraries which seemed like they could handle the task, but they were complex and expensive. Some libraries were WinForms only, some were WPF only, and many had complex data object models that were extremely difficult for someone new to .NET to understand. I implemented my own simple solution using native libraries, and after a few years of incremental refinement and lots of input from the user community ScottPlot grew to have a life of its own!

## What's With the Name?

**When I made ScottPlot, I thought I would be its only user.** I made it open-source so that others could _learn_ from it, but I didn't really intend people to _use_ it out of the box. Many improvements later, and after a great amount of input and contribution from the open-source community, ScottPlot is maturing into a very useful package, but it retains its original silly name.