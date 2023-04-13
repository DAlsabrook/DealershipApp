using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary
{
    public class Dealership
    {
        //Properties
        public string Name { get; set; }
        public List<Employees> Employees { get; set; } = new List<Employees>();
        public List<Automobiles> Automobiles { get; set; } = new List<Automobiles>();


        public string ComboDisplay
        {
            get
            {
                return string.Format($"{Name}");
            }
        }

        
    }
}
