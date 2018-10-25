
using NewGifts1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_gifts1.classes
{

    public class Chocolate : Sweet
    {
        public TypeOfChocolate TypeOfChocolate;
        public Chocolate(string name, double weight, double sugar, double colories
            , TypeOfChocolate typeOfChocolate) : base(name, weight, sugar, colories)
        {
            TypeOfChocolate = typeOfChocolate;
            
        }
        
        public override string TypeOfSweetness => "Chocolate";

        public override string ItemInfo => string.Format("{0}, weight: {1}, sugar: {2}, coloriess: {3}", Name, Colories, Vec, SugarPerUnit);
    }
}
