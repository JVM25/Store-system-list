using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Store_System.Store_System_V1
{
    class Product
    {
        public string NameP;
        public string Color;
        public float Cost;
        public int UnitsAvailable;

        public float GTotalAmount()
        {
            return Cost;
        }

        public float Unist()
        {
            float units = 0;
            units = units + 1;

            return units;
        }


    }
}
