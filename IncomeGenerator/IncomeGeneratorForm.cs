using IncomeSourceLibrary;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace IncomeGenerator
{
    public partial class IncomeGeneratorForm : Form
    {
        private const int MissionCutoff = 14;
        private BusinessContainer busCon;
        private MissionContainer misCon;
        private AdventurerContainer advCon;

        public IncomeGeneratorForm()
        {
            InitializeComponent();
        }

        //Add Buttons
        private void BTNAddBusiness_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBBusName.Text))
            {
                busCon.Add(new Business(TBBusName.Text, (int)NUDMaint.Value, (int)NUDProfit.Value, (int)NUDDays.Value));
                PopulateBusinessLV();
            }
            else
            {
                MessageBox.Show("Business Name should not be empty.", "Errors Validating", MessageBoxButtons.OK);
            }
        }

        private void BTNAddAdventurer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBAdventurerName.Text))
            {
                advCon.Add(new Adventurer(TBAdventurerName.Text, (int)NUDMod.Value));
                PopulateAdventurerLV();
            }
            else
            {
                MessageBox.Show("Adventurer should not be empty.", "Errors Validating", MessageBoxButtons.OK);
            }
        }

        //Remove Buttons
        private void BTNRemoveBusiness_Click(object sender, EventArgs e)
        {
            if(LVBusinesses.FocusedItem != null)
            {
                busCon.Remove(LVBusinesses.FocusedItem.Text);
            }
            PopulateBusinessLV();
        }

        private void BTNRemoveAdventurer_Click(object sender, EventArgs e)
        {
            if(LVAdventurers.FocusedItem != null)
            {
                advCon.Remove(LVAdventurers.FocusedItem.Text);
            }
            PopulateAdventurerLV();
        }

        private void BTNSimulate_Click(object sender, EventArgs e)
        {
            string fileName = $"IncomeGeneration{DateTime.Now.ToString("MMddyyyy-hhmmss")}.txt";
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                //determine how many missions there will be
                int missionCount = (int)NUDDays.Value / MissionCutoff;
                for (int i = 0; i < missionCount; i++)
                {
                    misCon.Container.Add(new Mission(100 + (i * 50), 10 + (i), advCon.Container));
                }

                //simulate business ventures
                foreach (Business bus in busCon.Container)
                {
                    sw.WriteLine(bus.SimulateBusiness());
                }

                //simulate mission space
                foreach (Mission mis in misCon.Container)
                {
                    sw.WriteLine(mis.SimulateMission());
                }

                sw.Flush();
            }

            //display final tallies
            Process.Start(fileName);
        }

        private void PopulateBusinessLV()
        {
            LVBusinesses.Items.Clear();
            foreach(Business b in busCon.Container)
            {
                LVBusinesses.Items.Add(new ListViewItem(b.ToString().Split('|')));
            }
        }

        private void PopulateAdventurerLV()
        {
            LVAdventurers.Items.Clear();
            foreach(Adventurer gm in advCon.Container)
            {
                LVAdventurers.Items.Add(new ListViewItem(gm.ToString().Split('|')));
            }
        }

        private void IncomeGeneratorForm_Load(object sender, EventArgs e)
        {
            advCon = new AdventurerContainer();
            misCon = new MissionContainer();
            busCon = new BusinessContainer();

            //setup business listview column list
            LVBusinesses.Columns.Add("Name", 100);
            LVBusinesses.Columns.Add("Maint. Cost", 100);
            LVBusinesses.Columns.Add("Profit Mult.", 100);

            //setup adventurers listview column list
            LVAdventurers.Columns.Add("Name", 100);
            LVAdventurers.Columns.Add("Modifier", 100);
        }
    }
}
