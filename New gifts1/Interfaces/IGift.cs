using ConsoleApp5.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.interfaces
{
    public interface IGift
    {
        double Vec { get; }
        int CountOfSweet { get; }
        string NameGift { get; }
        IEnumerable<ISweetness> Items { get; }
        IEnumerable<ISweetness> SortSweetnessByWeight();
        IEnumerable<ISweetness> FindSweetnessBySugar(int min, int max);
        void AddSweet(Sweet sweet);
        void RemoveSweet(Sweet sweet);
    }
}
