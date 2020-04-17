using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Period_tracker
{
    public partial class PeriodTracker : Form
    {
        public PeriodTracker()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            
            DateTime lastPeriodDate = dateOfLastPeriod.Value ;
            int pLength = int.Parse(periodLenght.Text);
            int cLength = int.Parse(cyleLenght.Text);

            DateTime nextPeriod = lastPeriodDate.AddDays(cLength);
            lblNextPeriod.Text = "Beggining of your next period: "+ nextPeriod.ToShortDateString();

            DateTime nextPeriodEnd = nextPeriod.AddDays(pLength-1);

            lblNextPeriodEnd.Text = "End of your next period: " + nextPeriodEnd.ToShortDateString();
            DateTime firstFertile = lastPeriodDate.AddDays(+cLength - 18);
            if (DateTime.Now>firstFertile)
            {
                firstFertile = nextPeriod.AddDays(+cLength - 18);
                lblFirstFertile.Text = "Your first fertile day: " + firstFertile.ToShortDateString();

                DateTime lastFertile = nextPeriod.AddDays(+cLength - 12);
                lblLastFertile.Text = "Your last fertile day: " + lastFertile.ToShortDateString();
            }
            else
            {
                lblFirstFertile.Text = "Your first fertile day: " + firstFertile.ToShortDateString();
                DateTime lastFertile = lastPeriodDate.AddDays(+cLength - 12);
                lblLastFertile.Text = "Your last fertile day: " + lastFertile.ToShortDateString();
            }
        }

        
    }
}
