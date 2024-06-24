using HW2.compositePattern;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HW2.Charts
{
    internal class BarCharts : Charts
    {
        private Panel panel1;

        public BarCharts( concreteSub sub, System.Windows.Forms.Panel barChartPanel) : base(sub)
        {
            this.panel1 = barChartPanel; 
        }

        public override void createCharts(List<StorageElement> observerState)
        {
            panel1.Controls.Clear();
            int i = 0;
            foreach (StorageElement element in observerState) 
            {
                Label label = new Label();
                label.Text = element.ToString();
                label.Width = (int)(200+(element.getSize()/1000));
                label.Height = 25;
                if(element is folder)
                {
                    label.BackColor = Color.LightBlue;
                }
                else 
                {
                    label.BackColor = Color.Orange;
                }
                if (element.getSize()/1000 < 1)
                {
                    label.BackColor = Color.Transparent;
                }
                label.Location = new Point(10, i * 45);
                panel1.Controls.Add(label);
                i++;
            }
            
        }
    }
}
