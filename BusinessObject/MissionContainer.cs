using System;
using System.Collections.Generic;
using System.Text;

namespace IncomeSourceLibrary
{
    public class MissionContainer
    {
        private List<Mission> missions;

        public List<Mission> Missions
        {
            get { return missions; }
            set { missions = value; }
        }

    }
}
