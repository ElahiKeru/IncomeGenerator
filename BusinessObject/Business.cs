using System;

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

        }

        public override string ToString()
        {
            return $"{Name} | {MaintenanceCost} | {ProfitAmount}";
        }
    }
}
