using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealershipLibrary
{
    public interface ISaleProp
    {
        bool Sold { get; }
        double Price { get; }
    }
}
