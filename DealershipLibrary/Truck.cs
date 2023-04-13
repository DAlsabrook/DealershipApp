using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary
{
    public class Truck : Automobiles, ISaleProp
    {
        //Properties
        public double BedLength { get; private set; }
        public string CabSize { get; private set; }
        public bool Hitch { get; private set; }

        public double Price { get; private set; }
        public bool Sold { get; private set; }

        //Constructors
        public Truck(
            string type,
            int price,
            bool isNew,
            string make,
            string color,
            string trans,
            double bedlength,
            string cabsize,
            bool hitch,
            bool sold) :
            base(type, isNew, make, color, trans)
        {
            BedLength = bedlength;
            CabSize = cabsize;
            Hitch = hitch;
            Price = price;
            Sold = sold;
        }
        //Methods
    }
}
