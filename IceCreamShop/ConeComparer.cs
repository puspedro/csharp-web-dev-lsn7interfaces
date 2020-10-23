using System;
using System.Collections.Generic;
using System.Text;

namespace IceCreamShop
{
    class ConeComparer : IComparer<Cone>
    {
        public int Compare(Cone x, Cone y)
        {
            if(x.Cost < y.Cost)
            {
                return -1;
            }
            if(x.Cost > y.Cost)
            {
                return 1;
            }
            return 0;
        }
    }
}
