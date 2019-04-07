using System;
using System.Collections.Generic;
using System.Text;

namespace IncomeSourceLibrary
{
    public class GuildMember
    {
        public int Modifier { get; private set; }
        public string Name { get; private set; }

        /// <summary>
        /// public constructor for Guild Member
        /// </summary>
        /// <param name="name">string, character name</param>
        /// <param name="modifier">int, special modifier applied to their rolls</param>
        public GuildMember(string name, int modifier)
        {
            Name = name;
            Modifier = Modifier;
        }
 
        public override string ToString()
        {
            return $"{Name} | {Modifier}";
        }
    }
}
