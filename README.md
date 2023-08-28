# How to display more data in the tooltip of Xamarin.Forms Charts
SfChart provides tooltip support for all series. It is used to show information about the segment, when you tap on the segment. To enable the tooltip, you need to set EnableTooltip property as true.

## Customizing appearance
You can customize the tooltip label. For customizing, you need to add an instance of ChartTooltipBehavior to the ChartBehaviors collection property of SfChart. Following properties are used to customize the tooltip label which are available in ChartTooltipBehavior.

* **BorderColor** – used to change the label border color
* **BorderWidth** – used to change the label border width
* **BackgroundColor** – used to change the label background color
* **Margin** – used to change label border thickness
* **TextColor** – used to change the text color.
* **Font** – used to change the text size, font family, and font weight. (This is deprecated API. Use FontSize, FontFamily, and * FontAttributes properties instead of this.)
* **FontFamily**- used to change the font family for the tooltip text.
* **FontAttributes** - used to change the font style for the tooltip text.
* **FontSize** - used to change the font size for the tooltip text.
* **LabelFormat** – used to format the label
* **Duration** – used to set the visible duration of label
* **OffsetX** – used to move the label horizontally
* **OffsetY** – used to move the label vertically
  
[Xamarin Chart](https://www.syncfusion.com/xamarin-ui-controls/xamarin-charts/chart-types/pie-chart) allows to display any information over a chart series. By default, it shows Y-value with enabling tooltip. In order to display both X and Y values or else showing any other values from its model from populated items source along with Tooltip UI customization, it has been achieved with the help of [TooltipTemplate](https://help.syncfusion.com/xamarin/charts/tooltip?cs-save-lang=1&cs-lang=xaml#tooltip-template) in chart series. 

![](https://github.com/SyncfusionExamples/How-to-display-more-data-information-in-the-tooltip-of-Xamarin.Forms-Charts/blob/main/Chart-Tooltip-Template.gif)

## See also

* [How to bind the Xamarin.Forms pie chart tooltip to “Others” category values](https://support.syncfusion.com/kb/article/10323/how-to-bind-the-xamarin-forms-pie-chart-tooltip-to-others-category-values?_gl=1*ad28v4*_ga*MzIyMTA2OTEuMTY4NjAzNTEwMg..*_ga_WC4JKKPHH0*MTY5MjYwNjk2My4yNDQuMS4xNjkyNjA2OTczLjUwLjAuMA..*_ga_41J4HFMX1J*MTY5MjYwNjk2My41NS4xLjE2OTI2MDY5NzMuMC4wLjA.)
* [How to show tooltip on Xamarin.Forms Chart axis label click?](https://support.syncfusion.com/kb/article/10197/how-to-show-tooltip-on-xamarin-forms-chart-axis-label-click?_gl=1*1ywodci*_ga*MzIyMTA2OTEuMTY4NjAzNTEwMg..*_ga_WC4JKKPHH0*MTY5MjYwNjk2My4yNDQuMS4xNjkyNjA3MjEzLjYwLjAuMA..*_ga_41J4HFMX1J*MTY5MjYwNjk2My41NS4xLjE2OTI2MDY5NzMuMC4wLjA.)
