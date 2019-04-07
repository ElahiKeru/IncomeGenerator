using System;
using System.Collections.Generic;
using System.Text;

namespace IncomeSourceLibrary
{
    public class Mission
    {
        public int GoldPaid { get; private set; }
        public int Difficulty { get; private set; }
        public List<GuildMember> GuildMembers { get; private set; }

        public Mission(int gp, int diff, List<GuildMember> gmem)
        {
            GoldPaid = gp;
            Difficulty = diff;
            GuildMembers = gmem;
        }

        public string SimulateMission()
        {

        }
    }
}
