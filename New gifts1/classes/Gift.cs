using New_gifts1.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_gifts1.classes
{
    public class Gift : IGift

    {
        private ICollection<ISweetness> sweetnessitems;
        public IEnumerable<ISweetness> Items
        {
            get { return sweetnessitems; }
        }

       

        public string NameGift { get; }

        public double Vec => throw new NotImplementedException();

        public int CountOfSweet => throw new NotImplementedException();

        public Gift (string namegift, ICollection<ISweetness> items)
        {

            sweetnessitems = items;
            NameGift = namegift;

        }

       public void AddSweet(Sweet sweet)
        {
            throw new NotImplementedException();
        }

        public void RemoveSweet(Sweet sweet)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ISweetness> SortSweetnessByWeight()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ISweetness> FindSweetnessBySugar(int min, int max)
        {
            throw new NotImplementedException();
        }

        void IGift.RemoveSweet(Sweet sweet)
        {
            throw new NotImplementedException();
        }
    }
}
