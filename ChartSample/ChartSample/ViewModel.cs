using Syncfusion.SfChart.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ChartSample
{
    public class ChartModel
    {
        public string XValue { get; set; }

        public double YValue { get; set; }
    
    }
    public class ViewModel
    {
        public ObservableCollection<ChartModel> Data { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<ChartModel>();

            Data.Add(new ChartModel() { XValue = "United States", YValue = 370 });
            Data.Add(new ChartModel() { XValue = "India", YValue = 370 });
            Data.Add(new ChartModel() { XValue = "Australia", YValue = 390 });
            Data.Add(new ChartModel() { XValue = "Kuwait", YValue = 430 });
            Data.Add(new ChartModel() { XValue = "China", YValue = 480 });
         
        }
    }
}
