using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary
{
    public class Automobiles
    {
        //Properties
        public bool IsNew { get; private set; }
        public string Type { get; private set; }
        public string Make { get; private set; }
        public string Color { get; private set; }
        public string Trans { get; private set; }
        public string ListBoxDisplay
        {
            get { return string.Format($"{Type} {Make} {Color}"); }
        }

        //Constructors
        public Automobiles(string type, bool isNew, string make, string color, string trans)
        {
            Type = type;
            IsNew = isNew;
            Make = make;
            Color = color;
            Trans = trans;
        }



    }
}
