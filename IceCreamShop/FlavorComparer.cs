using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    public class FlavorComparer : IComparer<Flavor>
    {
        public int Compare(Flavor x, Flavor y)
        {
            return string.Compare(x.Name, y.Name); // returns an integer of -1, 0, or 1 depending on which Flavor object comes first alphabetically
        }
    }
}
