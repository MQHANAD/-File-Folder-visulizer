using HW2.compositePattern;
using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace HW2.Charts
{
    internal class pieChart :Charts 
    {
        private Chart  chart1;
        
        public pieChart(concreteSub sub, Chart chart1) : base(sub)
        {
            this.chart1 = chart1;
        }

        public override void createCharts(List<StorageElement> observerState)
        {
            chart1.Series["S1"].Points.Clear();
            foreach (StorageElement element in observerState)
            {
                chart1.Series["S1"].Points.AddXY(element.ToString(),element.getSize());
            }
        } 
    }
}
