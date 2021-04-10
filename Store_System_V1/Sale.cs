using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Store_System.Store_System_V1
{
    class Sale
    {
        public Client Client;
        public Product Product;
        public int Amount;

        public float TotalAmount()
        {
            return Amount;
        }

     

    }
}
