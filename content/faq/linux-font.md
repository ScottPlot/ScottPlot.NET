---
title: Linux Font Issues - ScottPlot FAQ
description: Commonly encountered issues related to font rendering on Linux and MacOS
date: 2023-12-13
---

{{< banner-sp5 >}}

{{< specific-sp4 >}}

# Font Issues on Linux

ScottPlot 4 uses `System.Drawing.Common` to render text in cross-platform environments, but not having the proper dependencies installed may result in unexpected font rendering behavior.

## Example Font Rendering Issue

<figure class="figure w-100 text-center">
    <img src="linux-font-error.png" class="figure-img img-fluid">
    <figcaption class="figure-caption">
        A common problem is that letters appear as squares or rectangles
    </figcaption>
</figure>

## Solution

* Linux and MacOS may need to install additional packages described on the [ScottPlot dependencies](/faq/dependencies/)  page.
