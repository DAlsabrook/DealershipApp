using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary
{
    public class Coupe : Automobiles, ISaleProp
    {
        //Properties
        public double Price { get; private set; }
        public bool Sold { get; private set; }

        //Constructors
        public Coupe(
            string type,
            int price,
            bool isNew,
            string make,
            string color,
            string trans,
            bool sold) :
            base(type, isNew, make, color, trans)
        {
            Sold = sold;
            Price = price;
        }



        //Methods
    }
}
