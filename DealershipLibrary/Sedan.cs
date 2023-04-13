using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary
{
    public class Sedan : Automobiles, ISaleProp
    {
        //Properties
        public bool RearHeatSeat { get; set; }
        public double Price { get; private set; }
        public bool Sold { get; private set; }


        //Constructors
        public Sedan(
            string type,
            int price,
            bool isNew,
            string make,
            string color,
            string trans,
            bool rearHeatedSeat,
            bool sold) :
            base(type, isNew, make, color, trans)
        {
            RearHeatSeat = rearHeatedSeat;
            Price = price;
            Sold = sold;
        }

        //Methods
    }
}
