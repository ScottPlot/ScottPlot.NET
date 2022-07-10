---
title: "Colors - ScottPlot 4.1 Cookbook"
description: "List of Colors from all ScottPlot Palettes"
date: 7/9/2022 10:17:22 PM
url: /cookbook/4.1/colors/
---

Palettes are collections of colors. 
The palette in `Plot.Palette` defines default colors for new objects added to plots. 
Users can access palettes directly to get color values for any use. 

```cs
var pal = ScottPlot.Palette.Category10;
for (int i = 0; i < pal.Count(); i++)
{
    var color = pal.GetColor(i);
    Console.WriteLine(color);
}
```


### Amber

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #FF6F00;'>#FF6F00</div>
<div class='px-3 py-2' style='background-color: #FF8F00;'>#FF8F00</div>
<div class='px-3 py-2' style='background-color: #FFA000;'>#FFA000</div>
<div class='px-3 py-2' style='background-color: #FFB300;'>#FFB300</div>
<div class='px-3 py-2' style='background-color: #FFC107;'>#FFC107</div>
</div>


### Aurora

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #BF616A;'>#BF616A</div>
<div class='px-3 py-2' style='background-color: #D08770;'>#D08770</div>
<div class='px-3 py-2' style='background-color: #EBCB8B;'>#EBCB8B</div>
<div class='px-3 py-2' style='background-color: #A3BE8C;'>#A3BE8C</div>
<div class='px-3 py-2' style='background-color: #B48EAD;'>#B48EAD</div>
</div>


### Category10

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


### Category20

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


### ColorblindFriendly

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


### DarkPastel

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

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #8FBCBB;'>#8FBCBB</div>
<div class='px-3 py-2' style='background-color: #88C0D0;'>#88C0D0</div>
<div class='px-3 py-2' style='background-color: #81A1C1;'>#81A1C1</div>
<div class='px-3 py-2' style='background-color: #5E81AC;'>#5E81AC</div>
</div>


### Microcharts

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

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #013A20;'>#013A20</div>
<div class='px-3 py-2' style='background-color: #478C5C;'>#478C5C</div>
<div class='px-3 py-2' style='background-color: #94C973;'>#94C973</div>
<div class='px-3 py-2' style='background-color: #BACC81;'>#BACC81</div>
<div class='px-3 py-2' style='background-color: #CDD193;'>#CDD193</div>
</div>


### Nord

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #BF616A;'>#BF616A</div>
<div class='px-3 py-2' style='background-color: #A3BE8C;'>#A3BE8C</div>
<div class='px-3 py-2' style='background-color: #EBCB8B;'>#EBCB8B</div>
<div class='px-3 py-2' style='background-color: #81A1C1;'>#81A1C1</div>
<div class='px-3 py-2' style='background-color: #B48EAD;'>#B48EAD</div>
<div class='px-3 py-2' style='background-color: #88C0D0;'>#88C0D0</div>
<div class='px-3 py-2' style='background-color: #E5E9F0;'>#E5E9F0</div>
</div>


### OneHalf

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #383A42;'>#383A42</div>
<div class='px-3 py-2' style='background-color: #E4564A;'>#E4564A</div>
<div class='px-3 py-2' style='background-color: #50A14F;'>#50A14F</div>
<div class='px-3 py-2' style='background-color: #C18402;'>#C18402</div>
<div class='px-3 py-2' style='background-color: #0084BC;'>#0084BC</div>
<div class='px-3 py-2' style='background-color: #A626A4;'>#A626A4</div>
<div class='px-3 py-2' style='background-color: #0897B3;'>#0897B3</div>
</div>


### OneHalfDark

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #E06C75;'>#E06C75</div>
<div class='px-3 py-2' style='background-color: #98C379;'>#98C379</div>
<div class='px-3 py-2' style='background-color: #E5C07B;'>#E5C07B</div>
<div class='px-3 py-2' style='background-color: #61AFF0;'>#61AFF0</div>
<div class='px-3 py-2' style='background-color: #C678DD;'>#C678DD</div>
<div class='px-3 py-2' style='background-color: #56B6C2;'>#56B6C2</div>
<div class='px-3 py-2' style='background-color: #DCDFE4;'>#DCDFE4</div>
</div>


### PolarNight

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #2E3440;'>#2E3440</div>
<div class='px-3 py-2' style='background-color: #3B4252;'>#3B4252</div>
<div class='px-3 py-2' style='background-color: #434C5E;'>#434C5E</div>
<div class='px-3 py-2' style='background-color: #4C566A;'>#4C566A</div>
</div>


### Redness

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #FF0000;'>#FF0000</div>
<div class='px-3 py-2' style='background-color: #FF4F00;'>#FF4F00</div>
<div class='px-3 py-2' style='background-color: #FFA900;'>#FFA900</div>
<div class='px-3 py-2' style='background-color: #900303;'>#900303</div>
<div class='px-3 py-2' style='background-color: #FF8181;'>#FF8181</div>
</div>


### Snowstorm

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #D8DEE9;'>#D8DEE9</div>
<div class='px-3 py-2' style='background-color: #E5E9F0;'>#E5E9F0</div>
<div class='px-3 py-2' style='background-color: #ECEFF4;'>#ECEFF4</div>
</div>


### SummerSplash

<div class='d-flex flex-wrap'>
<div class='px-3 py-2' style='background-color: #05445E;'>#05445E</div>
<div class='px-3 py-2' style='background-color: #189AB4;'>#189AB4</div>
<div class='px-3 py-2' style='background-color: #75E6DA;'>#75E6DA</div>
<div class='px-3 py-2' style='background-color: #D4F1F4;'>#D4F1F4</div>
</div>


### Tsitsulin

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


