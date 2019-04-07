using System;
using System.Collections.Generic;
using System.Text;

namespace IncomeSourceLibrary
{
    public class BusinessContainer
    {
        private List<Business> businesses;

        public List<Business> Businesses
        {
            get { return businesses; }
            set { businesses = value; }
        }


    }
}
