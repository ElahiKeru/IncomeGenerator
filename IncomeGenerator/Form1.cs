using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IncomeSourceLibrary;

namespace IncomeGenerator
{
    public partial class IncomeGeneratorForm : Form
    {
        public const int MissionCutoff = 14;

        public IncomeGeneratorForm()
        {
            InitializeComponent();
        }

        private void BTNAddBusiness_Click(object sender, EventArgs e)
        {
            LVBusinesses.Items.Add(new Business(TBBusName.Text, (int)NUDMaint.Value, (int)NUDProfit.Value, (int)NUDDays.Value).ToString());
        }

        private void BTNRemoveBusiness_Click(object sender, EventArgs e)
        {

        }

        private void BTNAddAdventurer_Click(object sender, EventArgs e)
        {

        }

        private void BTNRemoveAdventurer_Click(object sender, EventArgs e)
        {

        }

        private void BTNSimulate_Click(object sender, EventArgs e)
        {

        }
    }
}
