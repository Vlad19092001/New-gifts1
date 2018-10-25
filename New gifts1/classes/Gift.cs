using NewGifts1.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public Gift(string name, ICollection<ISweetness> items)
        {
            sweetnessitems = items;
            NameGift = name;
        }
        public void AddSweet(Sweet sweet)
        {
            sweetnessitems.Add(sweet);
        }
        public void RemoveSweet(Sweet sweet)
        {
            sweetnessitems.Remove(sweet);
        }
        public int CountOfSweet
        {
            get { return sweetnessitems.Count(); }
        }
        public double Vec
        {
            get
            {
                if (sweetnessitems != null)
                {
                    return sweetnessitems.Sum(x => x.Vec);
                }
                else
                {
                    //реализовать обработку исключения
                    throw new InvalidOperationException("Container in Gift cannot be null");
                }
            }
        }
        public IEnumerable<ISweetness> SortSweetnessByWeight()
        {
            //сделать универсальным (можно добавить вспомогательный класс)
            var temp = sweetnessitems.OrderBy(x => x.Vec).ToArray();
            return temp;
        }
        public IEnumerable<ISweetness> FindSweetnessBySugar(double min, double max)
        {

            return sweetnessitems.Where(x => (x.SugarPerUnit >= min) && (x.SugarPerUnit <= max)).ToList();

        }

    }
}
