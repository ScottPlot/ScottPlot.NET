---
Title: "Colors - ScottPlot 4.1 Cookbook"
Description: "List of Colors from all ScottPlot Palettes"
Date: 2024-01-14
Version: ScottPlot 4.1.70
URL: /cookbook/4.1/colors/
---

# Color Palettes
Palettes are collections of colors. 
The palette in `Plot.Palette` defines default colors for new objects added to plots. 
Users can access palettes directly to get color values for any use. 

{{< code-sp4 >}}

```cs
var pal = ScottPlot.Palette.Category10;
for (int i = 0; i < pal.Count(); i++)
{
    var color = pal.GetColor(i);
    Console.WriteLine(color);
}
```

{{< /code-sp4 >}}


### Amber



{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.Amber();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #FF6F00;'>#FF6F00</div>
<div class='px-3 py-2' style='background-color: #FF8F00;'>#FF8F00</div>
<div class='px-3 py-2' style='background-color: #FFA000;'>#FFA000</div>
<div class='px-3 py-2' style='background-color: #FFB300;'>#FFB300</div>
<div class='px-3 py-2' style='background-color: #FFC107;'>#FFC107</div>
</div>


### Aurora

From the Nord collection of palettes: https://github.com/arcticicestudio/nord

{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.Aurora();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #BF616A;'>#BF616A</div>
<div class='px-3 py-2' style='background-color: #D08770;'>#D08770</div>
<div class='px-3 py-2' style='background-color: #EBCB8B;'>#EBCB8B</div>
<div class='px-3 py-2' style='background-color: #A3BE8C;'>#A3BE8C</div>
<div class='px-3 py-2' style='background-color: #B48EAD;'>#B48EAD</div>
</div>


### Building



{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.Building();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #FF6F00;'>#FF6F00</div>
<div class='px-3 py-2' style='background-color: #FF8F00;'>#FF8F00</div>
<div class='px-3 py-2' style='background-color: #FFA000;'>#FFA000</div>
<div class='px-3 py-2' style='background-color: #FFB300;'>#FFB300</div>
<div class='px-3 py-2' style='background-color: #FFC107;'>#FFC107</div>
</div>


### Category 10

A set of 10 unque colors used in many data visualization libraries such as Matplotlib, Vega, and Tableau

{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.Category10();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #1F77B4;'>#1F77B4</div>
<div class='px-3 py-2' style='background-color: #FF7F0E;'>#FF7F0E</div>
<div class='px-3 py-2' style='background-color: #2CA02C;'>#2CA02C</div>
<div class='px-3 py-2' style='background-color: #D62728;'>#D62728</div>
<div class='px-3 py-2' style='background-color: #9467BD;'>#9467BD</div>
<div class='px-3 py-2' style='background-color: #8C564B;'>#8C564B</div>
<div class='px-3 py-2' style='background-color: #E377C2;'>#E377C2</div>
<div class='px-3 py-2' style='background-color: #7F7F7F;'>#7F7F7F</div>
<div class='px-3 py-2' style='background-color: #BCBD22;'>#BCBD22</div>
<div class='px-3 py-2' style='background-color: #17BECF;'>#17BECF</div>
</div>


### Category 20

A set of 20 unque colors used in many data visualization libraries such as Matplotlib, Vega, and Tableau

{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.Category20();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #1F77B4;'>#1F77B4</div>
<div class='px-3 py-2' style='background-color: #AEC7E8;'>#AEC7E8</div>
<div class='px-3 py-2' style='background-color: #FF7F0E;'>#FF7F0E</div>
<div class='px-3 py-2' style='background-color: #FFBB78;'>#FFBB78</div>
<div class='px-3 py-2' style='background-color: #2CA02C;'>#2CA02C</div>
<div class='px-3 py-2' style='background-color: #98DF8A;'>#98DF8A</div>
<div class='px-3 py-2' style='background-color: #D62728;'>#D62728</div>
<div class='px-3 py-2' style='background-color: #FF9896;'>#FF9896</div>
<div class='px-3 py-2' style='background-color: #9467BD;'>#9467BD</div>
<div class='px-3 py-2' style='background-color: #C5B0D5;'>#C5B0D5</div>
<div class='px-3 py-2' style='background-color: #8C564B;'>#8C564B</div>
<div class='px-3 py-2' style='background-color: #C49C94;'>#C49C94</div>
<div class='px-3 py-2' style='background-color: #E377C2;'>#E377C2</div>
<div class='px-3 py-2' style='background-color: #F7B6D2;'>#F7B6D2</div>
<div class='px-3 py-2' style='background-color: #7F7F7F;'>#7F7F7F</div>
<div class='px-3 py-2' style='background-color: #C7C7C7;'>#C7C7C7</div>
<div class='px-3 py-2' style='background-color: #BCBD22;'>#BCBD22</div>
<div class='px-3 py-2' style='background-color: #DBDB8D;'>#DBDB8D</div>
<div class='px-3 py-2' style='background-color: #17BECF;'>#17BECF</div>
<div class='px-3 py-2' style='background-color: #9EDAE5;'>#9EDAE5</div>
</div>


### Colorblind Friendly

A set of 8 colorblind-friendly colors from Bang Wong's Nature Methods paper https://www.nature.com/articles/nmeth.1618.pdf

{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.ColorblindFriendly();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #000000;'>#000000</div>
<div class='px-3 py-2' style='background-color: #E69F00;'>#E69F00</div>
<div class='px-3 py-2' style='background-color: #56B4E9;'>#56B4E9</div>
<div class='px-3 py-2' style='background-color: #009E73;'>#009E73</div>
<div class='px-3 py-2' style='background-color: #F0E442;'>#F0E442</div>
<div class='px-3 py-2' style='background-color: #0072B2;'>#0072B2</div>
<div class='px-3 py-2' style='background-color: #D55E00;'>#D55E00</div>
<div class='px-3 py-2' style='background-color: #CC79A7;'>#CC79A7</div>
</div>


### Dark

A qualitative 8-color palette generated using colorbrewer2.org

{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.Dark();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #1B9E77;'>#1B9E77</div>
<div class='px-3 py-2' style='background-color: #D95F02;'>#D95F02</div>
<div class='px-3 py-2' style='background-color: #7570B3;'>#7570B3</div>
<div class='px-3 py-2' style='background-color: #E7298A;'>#E7298A</div>
<div class='px-3 py-2' style='background-color: #66A61E;'>#66A61E</div>
<div class='px-3 py-2' style='background-color: #E6AB02;'>#E6AB02</div>
<div class='px-3 py-2' style='background-color: #A6761D;'>#A6761D</div>
<div class='px-3 py-2' style='background-color: #666666;'>#666666</div>
</div>


### Dark Pastel

A qualitative 8-color palette generated using colorbrewer2.org

{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.DarkPastel();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #66C2A5;'>#66C2A5</div>
<div class='px-3 py-2' style='background-color: #FC8D62;'>#FC8D62</div>
<div class='px-3 py-2' style='background-color: #8DA0CB;'>#8DA0CB</div>
<div class='px-3 py-2' style='background-color: #E78AC3;'>#E78AC3</div>
<div class='px-3 py-2' style='background-color: #A6D854;'>#A6D854</div>
<div class='px-3 py-2' style='background-color: #FFD92F;'>#FFD92F</div>
<div class='px-3 py-2' style='background-color: #E5C494;'>#E5C494</div>
<div class='px-3 py-2' style='background-color: #B3B3B3;'>#B3B3B3</div>
</div>


### Frost

From the Nord collection of palettes: https://github.com/arcticicestudio/nord

{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.Frost();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #8FBCBB;'>#8FBCBB</div>
<div class='px-3 py-2' style='background-color: #88C0D0;'>#88C0D0</div>
<div class='px-3 py-2' style='background-color: #81A1C1;'>#81A1C1</div>
<div class='px-3 py-2' style='background-color: #5E81AC;'>#5E81AC</div>
</div>


### Light ocean

A 9-color palette by Arthurits created by a mixture of light greens, blues, and purples

{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.LightOcean();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #DFEDD9;'>#DFEDD9</div>
<div class='px-3 py-2' style='background-color: #DBECDC;'>#DBECDC</div>
<div class='px-3 py-2' style='background-color: #DBEDE4;'>#DBEDE4</div>
<div class='px-3 py-2' style='background-color: #DAEEEC;'>#DAEEEC</div>
<div class='px-3 py-2' style='background-color: #DAEEF3;'>#DAEEF3</div>
<div class='px-3 py-2' style='background-color: #DAE6F2;'>#DAE6F2</div>
<div class='px-3 py-2' style='background-color: #DADEF1;'>#DADEF1</div>
<div class='px-3 py-2' style='background-color: #DEDAEE;'>#DEDAEE</div>
<div class='px-3 py-2' style='background-color: #E5DAED;'>#E5DAED</div>
</div>


### Light spectrum

A 9-color palette by Arthurits created by lightening the colors in the visible spectrum

{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.LightSpectrum();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #FCE5E6;'>#FCE5E6</div>
<div class='px-3 py-2' style='background-color: #FFF8E7;'>#FFF8E7</div>
<div class='px-3 py-2' style='background-color: #FFFCE8;'>#FFFCE8</div>
<div class='px-3 py-2' style='background-color: #EFF5E4;'>#EFF5E4</div>
<div class='px-3 py-2' style='background-color: #E7F2E6;'>#E7F2E6</div>
<div class='px-3 py-2' style='background-color: #DDF0F5;'>#DDF0F5</div>
<div class='px-3 py-2' style='background-color: #E6F2FC;'>#E6F2FC</div>
<div class='px-3 py-2' style='background-color: #E6EAF7;'>#E6EAF7</div>
<div class='px-3 py-2' style='background-color: #EEE0F0;'>#EEE0F0</div>
</div>


### Microcharts

Soft color palette sourced from the Microcharts project: https://github.com/microcharts-dotnet/Microcharts

{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.Microcharts();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #266489;'>#266489</div>
<div class='px-3 py-2' style='background-color: #68B9C0;'>#68B9C0</div>
<div class='px-3 py-2' style='background-color: #90D585;'>#90D585</div>
<div class='px-3 py-2' style='background-color: #F3C151;'>#F3C151</div>
<div class='px-3 py-2' style='background-color: #F37F64;'>#F37F64</div>
<div class='px-3 py-2' style='background-color: #424856;'>#424856</div>
<div class='px-3 py-2' style='background-color: #8F97A4;'>#8F97A4</div>
<div class='px-3 py-2' style='background-color: #DAC096;'>#DAC096</div>
<div class='px-3 py-2' style='background-color: #76846E;'>#76846E</div>
<div class='px-3 py-2' style='background-color: #DABFAF;'>#DABFAF</div>
<div class='px-3 py-2' style='background-color: #A65B69;'>#A65B69</div>
<div class='px-3 py-2' style='background-color: #97A69D;'>#97A69D</div>
</div>


### Nero



{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.Nero();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #013A20;'>#013A20</div>
<div class='px-3 py-2' style='background-color: #478C5C;'>#478C5C</div>
<div class='px-3 py-2' style='background-color: #94C973;'>#94C973</div>
<div class='px-3 py-2' style='background-color: #BACC81;'>#BACC81</div>
<div class='px-3 py-2' style='background-color: #CDD193;'>#CDD193</div>
</div>


### Nord

From the Nord ConEmu color scheme: https://github.com/arcticicestudio/nord-conemu

{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.Nord();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #BF616A;'>#BF616A</div>
<div class='px-3 py-2' style='background-color: #A3BE8C;'>#A3BE8C</div>
<div class='px-3 py-2' style='background-color: #EBCB8B;'>#EBCB8B</div>
<div class='px-3 py-2' style='background-color: #81A1C1;'>#81A1C1</div>
<div class='px-3 py-2' style='background-color: #B48EAD;'>#B48EAD</div>
<div class='px-3 py-2' style='background-color: #88C0D0;'>#88C0D0</div>
<div class='px-3 py-2' style='background-color: #E5E9F0;'>#E5E9F0</div>
</div>


### Xgfs Normal 6

A color palette adapted from Tsitsulin's 6-color normal xgfs palette: http://tsitsul.in/blog/coloropt

{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.Normal();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #4053D3;'>#4053D3</div>
<div class='px-3 py-2' style='background-color: #DDB310;'>#DDB310</div>
<div class='px-3 py-2' style='background-color: #B51D14;'>#B51D14</div>
<div class='px-3 py-2' style='background-color: #00BEFF;'>#00BEFF</div>
<div class='px-3 py-2' style='background-color: #FB49B0;'>#FB49B0</div>
<div class='px-3 py-2' style='background-color: #00B25D;'>#00B25D</div>
<div class='px-3 py-2' style='background-color: #CACACA;'>#CACACA</div>
</div>


### One Half

A Sublime color scheme by Son A. Pham: https://github.com/sonph/onehalf

{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.OneHalf();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #383A42;'>#383A42</div>
<div class='px-3 py-2' style='background-color: #E4564A;'>#E4564A</div>
<div class='px-3 py-2' style='background-color: #50A14F;'>#50A14F</div>
<div class='px-3 py-2' style='background-color: #C18402;'>#C18402</div>
<div class='px-3 py-2' style='background-color: #0084BC;'>#0084BC</div>
<div class='px-3 py-2' style='background-color: #A626A4;'>#A626A4</div>
<div class='px-3 py-2' style='background-color: #0897B3;'>#0897B3</div>
</div>


### One Half (Dark)

A Sublime color scheme by Son A. Pham: https://github.com/sonph/onehalf

{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.OneHalfDark();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #E06C75;'>#E06C75</div>
<div class='px-3 py-2' style='background-color: #98C379;'>#98C379</div>
<div class='px-3 py-2' style='background-color: #E5C07B;'>#E5C07B</div>
<div class='px-3 py-2' style='background-color: #61AFF0;'>#61AFF0</div>
<div class='px-3 py-2' style='background-color: #C678DD;'>#C678DD</div>
<div class='px-3 py-2' style='background-color: #56B6C2;'>#56B6C2</div>
<div class='px-3 py-2' style='background-color: #DCDFE4;'>#DCDFE4</div>
</div>


### Pastel wheel

A 12-color palette by Arthurits created by lightening the color wheel

{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.PastelWheel();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #F8C5C7;'>#F8C5C7</div>
<div class='px-3 py-2' style='background-color: #FADEC3;'>#FADEC3</div>
<div class='px-3 py-2' style='background-color: #FBF6C4;'>#FBF6C4</div>
<div class='px-3 py-2' style='background-color: #E1ECC8;'>#E1ECC8</div>
<div class='px-3 py-2' style='background-color: #D7E8CB;'>#D7E8CB</div>
<div class='px-3 py-2' style='background-color: #DAEBD7;'>#DAEBD7</div>
<div class='px-3 py-2' style='background-color: #D9EEF3;'>#D9EEF3</div>
<div class='px-3 py-2' style='background-color: #CADBED;'>#CADBED</div>
<div class='px-3 py-2' style='background-color: #C7D2E6;'>#C7D2E6</div>
<div class='px-3 py-2' style='background-color: #D4D1E5;'>#D4D1E5</div>
<div class='px-3 py-2' style='background-color: #E8D3E6;'>#E8D3E6</div>
<div class='px-3 py-2' style='background-color: #F8C7DE;'>#F8C7DE</div>
</div>


### Penumbra

A perceptually uniform color palette by Neal McKee: https://github.com/nealmckee/penumbra

{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.Penumbra();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #CB7459;'>#CB7459</div>
<div class='px-3 py-2' style='background-color: #A38F2D;'>#A38F2D</div>
<div class='px-3 py-2' style='background-color: #46A473;'>#46A473</div>
<div class='px-3 py-2' style='background-color: #00A0BE;'>#00A0BE</div>
<div class='px-3 py-2' style='background-color: #7E87D6;'>#7E87D6</div>
<div class='px-3 py-2' style='background-color: #BD72A8;'>#BD72A8</div>
</div>


### Polar Night

From the Nord collection of palettes: https://github.com/arcticicestudio/nord

{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.PolarNight();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #2E3440;'>#2E3440</div>
<div class='px-3 py-2' style='background-color: #3B4252;'>#3B4252</div>
<div class='px-3 py-2' style='background-color: #434C5E;'>#434C5E</div>
<div class='px-3 py-2' style='background-color: #4C566A;'>#4C566A</div>
</div>


### Redness



{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.Redness();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #FF0000;'>#FF0000</div>
<div class='px-3 py-2' style='background-color: #FF4F00;'>#FF4F00</div>
<div class='px-3 py-2' style='background-color: #FFA900;'>#FFA900</div>
<div class='px-3 py-2' style='background-color: #900303;'>#900303</div>
<div class='px-3 py-2' style='background-color: #FF8181;'>#FF8181</div>
</div>


### Snow Storm

From the Nord collection of palettes: https://github.com/arcticicestudio/nord

{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.SnowStorm();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #D8DEE9;'>#D8DEE9</div>
<div class='px-3 py-2' style='background-color: #E5E9F0;'>#E5E9F0</div>
<div class='px-3 py-2' style='background-color: #ECEFF4;'>#ECEFF4</div>
</div>


### Summer Splash



{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.SummerSplash();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #05445E;'>#05445E</div>
<div class='px-3 py-2' style='background-color: #189AB4;'>#189AB4</div>
<div class='px-3 py-2' style='background-color: #75E6DA;'>#75E6DA</div>
<div class='px-3 py-2' style='background-color: #D4F1F4;'>#D4F1F4</div>
</div>


### Xgfs 25

A 25-color palette by Arthurits adapted from Tsitsulin's 12-color xgfs palette: http://tsitsul.in/blog/coloropt

{{< code-sp4 >}}

```cs
var myPalette = new ScottPlot.Palettes.Tsitsulin();
foreach (var color in myPalette)
    Console.WriteLine(color);
```

{{< /code-sp4 >}}

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #EBAC23;'>#EBAC23</div>
<div class='px-3 py-2' style='background-color: #B80058;'>#B80058</div>
<div class='px-3 py-2' style='background-color: #008CF9;'>#008CF9</div>
<div class='px-3 py-2' style='background-color: #006E00;'>#006E00</div>
<div class='px-3 py-2' style='background-color: #00BBAD;'>#00BBAD</div>
<div class='px-3 py-2' style='background-color: #D163E6;'>#D163E6</div>
<div class='px-3 py-2' style='background-color: #B24502;'>#B24502</div>
<div class='px-3 py-2' style='background-color: #FF9287;'>#FF9287</div>
<div class='px-3 py-2' style='background-color: #5954D6;'>#5954D6</div>
<div class='px-3 py-2' style='background-color: #00C6F8;'>#00C6F8</div>
<div class='px-3 py-2' style='background-color: #878500;'>#878500</div>
<div class='px-3 py-2' style='background-color: #00A76C;'>#00A76C</div>
<div class='px-3 py-2' style='background-color: #F6DA9C;'>#F6DA9C</div>
<div class='px-3 py-2' style='background-color: #FF5CAA;'>#FF5CAA</div>
<div class='px-3 py-2' style='background-color: #8ACCFF;'>#8ACCFF</div>
<div class='px-3 py-2' style='background-color: #4BFF4B;'>#4BFF4B</div>
<div class='px-3 py-2' style='background-color: #6EFFF4;'>#6EFFF4</div>
<div class='px-3 py-2' style='background-color: #EDC1F5;'>#EDC1F5</div>
<div class='px-3 py-2' style='background-color: #FEAE7C;'>#FEAE7C</div>
<div class='px-3 py-2' style='background-color: #FFC8C3;'>#FFC8C3</div>
<div class='px-3 py-2' style='background-color: #BDBBEF;'>#BDBBEF</div>
<div class='px-3 py-2' style='background-color: #BDF2FF;'>#BDF2FF</div>
<div class='px-3 py-2' style='background-color: #FFFC43;'>#FFFC43</div>
<div class='px-3 py-2' style='background-color: #65FFC8;'>#65FFC8</div>
<div class='px-3 py-2' style='background-color: #AAAAAA;'>#AAAAAA</div>
</div>


