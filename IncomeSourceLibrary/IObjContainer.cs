using System.Collections.Generic;

namespace IncomeSourceLibrary
{
    public interface IObjContainer<T>
    {
        List<T> Container
        {
            get;
        }

        T this[int index]
        {
            get;
        }

        T this[string index]
        {
            get;
        }

        void Remove(string target);
        void Add(T target);
    }
}
