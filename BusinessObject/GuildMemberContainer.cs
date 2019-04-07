using System;
using System.Collections.Generic;
using System.Text;

namespace IncomeSourceLibrary
{
    public class GuildMemberContainer
    {
        private List<GuildMember> guildMembers;

        public List<GuildMember> GuildMembers
        {
            get { return guildMembers; }
            set { guildMembers = value; }
        }

    }
}
