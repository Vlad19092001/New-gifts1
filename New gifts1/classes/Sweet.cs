using New_gifts1.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_gifts1.classes
{
    public abstract class Sweet : ISweetness
    {
        

        public double Vec { get; }

        

        public double SugarPerUnit { get; }

        public string Name { get; }

        public double Colories { get; }
        public abstract string TypeOfSweetness { get; }
        public abstract string ItemInfo { get; }

        public Sweet(string name, double weight,  double sugar, double colories)
        {
            Name = name;
            Colories = colories;
            Vec = weight;
            
            SugarPerUnit = sugar;
            
        }
    }

}
