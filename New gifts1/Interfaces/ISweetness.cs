using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.interfaces
{
    public interface ISweetness
    {
        double SugarPerUnit { get; }
        string Name { get; }
        double Colories { get; }
        string TypeOfSweetness { get; }
        double Vec { get; }
        string ItemInfo { get; }

    } 

}
