using System.Collections.Generic;

namespace IncomeSourceLibrary
{
    public class BusinessContainer : IObjContainer<Business>
    {
        private List<Business> businesses;

        public List<Business> Container
        {
            get
            {
                if (businesses == null) businesses = new List<Business>();
                return businesses;
            }
            private set { businesses = value; }
        }

        public Business this[int index]
        {
            get
            {
                if (businesses == null) businesses = new List<Business>();
                return businesses[index];
            }
        }

        public Business this[string index]
        {
            get
            {
                if (businesses == null) businesses = new List<Business>();
                Business target = null;
                foreach (Business b in businesses)
                {
                    if (b.Name.Equals(index))
                    {
                        target = b;
                    }
                }
                return target;
            }
        }

        public void Remove(string target)
        {
            Container.Remove(this[target]);
        }

        public void Add(Business target)
        {
            Container.Add(target);
        }
    }
}
