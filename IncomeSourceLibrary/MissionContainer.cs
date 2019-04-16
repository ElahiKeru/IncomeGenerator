using System.Collections.Generic;

namespace IncomeSourceLibrary
{
    public class MissionContainer
    {
        private List<Mission> missions;

        public List<Mission> Container
        {
            get
            {
                if (missions == null) missions = new List<Mission>();
                return missions;
            }
            set { missions = value; }
        }

    }
}
