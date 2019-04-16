using System;
using System.Collections.Generic;
using System.Text;

namespace IncomeSourceLibrary
{
    public class Mission
    {
        public int GoldPaid { get; private set; }
        public int Difficulty { get; private set; }
        public List<Adventurer> Adventurers { get; private set; }
        private readonly Random roller = new Random();

        public Mission(int gp, int diff, List<Adventurer> advs)
        {
            GoldPaid = gp;
            Difficulty = diff;
            Adventurers = advs;
        }

        public string SimulateMission()
        {
            StringBuilder result = new StringBuilder();
            int diceRoll;
            int totalPaid = 0;

            result.AppendLine($"Results for {GoldPaid}GP Mission");

            foreach (Adventurer ad in Adventurers)
            {
                diceRoll = roller.Next(1, 20) + ad.Modifier;
                if (diceRoll > Difficulty)
                {
                    //member succeeded! + GoldPaid to total!
                    result.AppendLine($"\t{ad.Name} Succeeded! +{GoldPaid} to total!");
                    totalPaid += GoldPaid;
                }
                else
                {
                    //member failed! No Gold Awarded!
                    result.AppendLine($"\t{ad.Name} Failed... No gold awarded.");
                }
            }

            result.AppendLine($"Results: {totalPaid} Gold obtained!");

            return result.ToString();
        }
    }
}
