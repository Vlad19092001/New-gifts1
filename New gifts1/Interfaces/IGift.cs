using New_gifts1.classes;
using System.Collections.Generic;

namespace NewGifts1.interfaces
{
    public interface IGift
    {
        double Vec { get; }
        int CountOfSweet { get; }
        string NameGift { get; }
        IEnumerable<ISweetness> Items { get; }
        IEnumerable<ISweetness> SortSweetnessByWeight();
        IEnumerable<ISweetness> FindSweetnessBySugar(double min, double max);
        void AddSweet(Sweet sweet);
        void RemoveSweet(Sweet sweet);
    }
}
