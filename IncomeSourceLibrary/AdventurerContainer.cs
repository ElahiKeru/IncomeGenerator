using System.Collections.Generic;

namespace IncomeSourceLibrary
{
    public class AdventurerContainer : IObjContainer<Adventurer>
    {
        private List<Adventurer> adventurers;

        public List<Adventurer> Container
        {
            get
            {
                if (adventurers == null) adventurers = new List<Adventurer>();
                return adventurers;
            }
            private set { adventurers = value; }
        }

        public Adventurer this[int index]
        {
            get
            {
                if (adventurers == null) adventurers = new List<Adventurer>();
                return adventurers[index];
            }
        }

        public Adventurer this[string index]
        {
            get
            {
                if (adventurers == null) adventurers = new List<Adventurer>();
                Adventurer target = null;
                foreach (Adventurer gm in adventurers)
                {
                    if (gm.Name.Equals(index))
                    {
                        target = gm;
                    }
                }
                return target;
            }
        }

        public void Remove(string target)
        {
            Container.Remove(this[target]);
        }

        public void Add(Adventurer target)
        {
            Container.Add(target);
        }
    }
}
