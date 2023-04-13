using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary
{
    public class Employees
    {
        //Properties

        public string Name { get; set; }
        public int ID { get; set; }
        public double TotalSales { get; set; }
        
        public double Commission { get; set; }
        public string ListBoxDisplay
        {
            get { return string.Format($"{Name} ID: {ID}"); }
        }

        public Employees()
        {
            Commission = .1;
        }

        public string Display()
        {
            return string.Format($"ID:{ID} {Name}");
        }

    }
}
