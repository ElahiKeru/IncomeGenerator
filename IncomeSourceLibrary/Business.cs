using System;
using System.Text;

namespace IncomeSourceLibrary
{
    public class Business
    {
        public int MaintenanceCost { get; private set; }
        public int ProfitAmount { get; private set; }
        public int DaysOperating { get; private set; }
        public int RemainderDays { get; private set; }
        public int FullCycles { get; private set; }
        public string Name { get; private set; }
        const int maxCycle = 30;
        private readonly Random roller = new Random();

        public Business(string name, int maintCost, int profit, int daysOperate)
        {
            Name = name;
            MaintenanceCost = maintCost;
            ProfitAmount = profit;
            DaysOperating = daysOperate;
            FullCycles = DaysOperating / maxCycle;
            RemainderDays = DaysOperating % maxCycle;
        }

        public string SimulateBusiness()
        {
            StringBuilder result = new StringBuilder();
            int diceRoll;
            double increment = 0;
            double totalPaid = 0;

            result.AppendLine($"Beginning Simulation for {Name}:");

            for (int i = 0; i < FullCycles; i++)
            {
                result.AppendLine($"\tFor Full Cycle {i}");
                diceRoll = roller.Next(1, 100) + maxCycle;
                if (diceRoll <= 20)
                {
                    increment = 1.5f * (MaintenanceCost * maxCycle);
                    result.AppendLine($"\t\tCritical Failure: The business cost you {increment}");
                    totalPaid -= increment;
                }
                else if (diceRoll > 20 && diceRoll <= 30)
                {
                    increment = 1.0f * (MaintenanceCost * maxCycle);
                    result.AppendLine($"\t\tPalpable Failure: The business cost you {increment}");
                    totalPaid -= increment;
                }
                else if (diceRoll > 30 && diceRoll <= 40)
                {
                    increment = 0.5f * (MaintenanceCost * maxCycle);
                    result.AppendLine($"\t\tA Slight Setback: the business cost you {increment}");
                    totalPaid -= increment;
                }
                else if (diceRoll > 40 && diceRoll <= 60)
                {
                    result.AppendLine("\t\tThe business broke even...");
                }
                else if (diceRoll > 60 && diceRoll <= 80)
                {
                    increment = roller.Next(1, 6) * ProfitAmount;
                    result.AppendLine($"\t\tA Modest Success: The business turned a profit of {increment}");
                    totalPaid += increment;
                }
                else if (diceRoll > 80 && diceRoll <= 90)
                {
                    increment = (roller.Next(1, 8) + roller.Next(1, 8)) * ProfitAmount;
                    result.AppendLine($"\t\tA Moderate Success: The business turned a profit of {increment}");
                    totalPaid += increment;
                }
                else if (diceRoll > 90)
                {
                    increment = (roller.Next(1, 10) + roller.Next(1, 10) + roller.Next(1, 10)) * ProfitAmount;
                    result.AppendLine($"\t\tA Critical Success: The business turned a profit of {increment}");
                    totalPaid += increment;
                }
            }

            if (RemainderDays > 0)
            {
                result.AppendLine($"\tFor Remaining Days: {RemainderDays}");
                diceRoll = roller.Next(1, 100) + RemainderDays;
                if (diceRoll <= 20)
                {
                    increment = 1.5f * (MaintenanceCost * RemainderDays);
                    result.AppendLine($"\t\tCritical Failure: The business cost you {increment}");
                    totalPaid -= increment;
                }
                else if (diceRoll > 20 && diceRoll <= 30)
                {
                    increment = 1.0f * (MaintenanceCost * RemainderDays);
                    result.AppendLine($"\t\tPalpable Failure: The business cost you {increment}");
                    totalPaid -= increment;
                }
                else if (diceRoll > 30 && diceRoll <= 40)
                {
                    increment = 0.5f * (MaintenanceCost * RemainderDays);
                    result.AppendLine($"\t\tA Slight Setback: the business cost you {increment}");
                    totalPaid -= increment;
                }
                else if (diceRoll > 40 && diceRoll <= 60)
                {
                    result.AppendLine("\t\tThe business broke even...");
                }
                else if (diceRoll > 60 && diceRoll <= 80)
                {
                    increment = roller.Next(1, 6) * ProfitAmount;
                    result.AppendLine($"\t\tA Modest Success: The business turned a profit of {increment}");
                    totalPaid += increment;
                }
                else if (diceRoll > 80 && diceRoll <= 90)
                {
                    increment = (roller.Next(1, 8) + roller.Next(1, 8)) * ProfitAmount;
                    result.AppendLine($"\t\tA Moderate Success: The business turned a profit of {increment}");
                    totalPaid += increment;
                }
                else if (diceRoll > 90)
                {
                    increment = (roller.Next(1, 10) + roller.Next(1, 10) + roller.Next(1, 10)) * ProfitAmount;
                    result.AppendLine($"\t\tA Critical Success: The business turned a profit of {increment}");
                    totalPaid += increment;
                }
            }

            result.AppendLine($"Results: {totalPaid} gained/lost!");

            return result.ToString();
        }

        public override string ToString()
        {
            return $"{Name}|{MaintenanceCost}|{ProfitAmount}";
        }
    }
}
