using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Store_System.Store_System_V1
{
    class CompanyList
    {
        ClientNode Head;
        ProductNode Head1;
        SaleNode Head2;

        Sale[] Sales = new Sale[50];
        int saleCount = 0;

        public void AddSale(Sale newSale)
        {
            Sales[saleCount] = newSale;
            saleCount++;
        }

        public void AddC(Client clientToAdd)
        {
            ClientNode newCNode = new ClientNode();
            newCNode.Client = clientToAdd;

            if (Head == null)
            {
                Head = newCNode;
            }
            else
            {
                ClientNode last = Head;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = newCNode;
            }
        }

        public void AddP(Product productToAdd)
        {
            ProductNode newPNode = new ProductNode();
            newPNode.Product = productToAdd;

            if (Head1 == null)
            {
                Head1 = newPNode;
            }
            else
            {
                ProductNode last = Head1;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = newPNode;
            }
        }

        public void AddS(Sale saleToAdd)
        {
            SaleNode newPNode = new SaleNode();
            newPNode.Sale = saleToAdd;

            if (Head2 == null)
            {
                Head2 = newPNode;
            }
            else
            {
                SaleNode last = Head2;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = newPNode;
            }
        }

        public float TotalAmount()
        {
            float totalAmountP = 0;
            for (int i = 0; i < saleCount; i++)
            {
                totalAmountP = totalAmountP + Sales[i].Product.GTotalAmount();
            }
            return totalAmountP;
        }

        public float SalesAmount()
        {
            float totalAmount = 0;
            for (int i = 0; i < saleCount; i++)
            {
                totalAmount = totalAmount + Sales[i].Amount;
            }
            return totalAmount;
        }

        public Sale ImportantSale()
        {
            Sale sale = Sales[0];
            string product = Sales[0].Product.NameP;
            for (int i = 0; i < saleCount; i++)
            {
                if (Sales[i].Amount > sale.TotalAmount())
                {
                    sale = Sales[i];
                    product = Sales[i].Product.NameP;
                }
            }
            return sale;
        }

        public Sale ImportantClient()
        {
            Sale sale = Sales[0];
            string client = Sales[0].Client.Name;
            for (int i = 0; i < saleCount; i++)
            {
                if (Sales[i].Amount > sale.TotalAmount())
                {
                    sale = Sales[i];
                    client = Sales[i].Client.Name;
                }
            }
            return sale;
        }

        public float AverageSale()
        {
            float totalUnits = 0;
            for (int i = 0; i < saleCount; i++)
            {
                totalUnits = totalUnits + Sales[i].Product.Unist();
            }
            return totalUnits;
        }

        public void InsertAfterC(Client newClient, Client after)
        {
            ClientNode cn = Head;
            while(cn != null && cn.Client != after)
            {
                cn = cn.Next;
            }

            ClientNode newCNode = new ClientNode();
            newCNode.Client = newClient;

            newCNode.Next = cn.Next;
            cn.Next = newCNode;
        }

        public void RemoveC()
        {
            if (Head != null)
            {
                Head = Head.Next;
            }
        }

        public void InsertAfterP(Product newProduct, Product after)
        {
            ProductNode prn = Head1;
            while (prn != null && prn.Product != after)
            {
                prn = prn.Next;
            }
            ProductNode newPNode = new ProductNode();
            newPNode.Product = newProduct;

            newPNode.Next = prn.Next;
            prn.Next = newPNode;
        }

        public void RemoveP()
        {
            Head1 = Head1.Next;
        }

        public void PrintC()
        {
            ClientNode cn = Head;
            while (cn != null)
            {
                Console.WriteLine($"Name: {cn.Client.Name} - Age: {cn.Client.Age}");
                cn = cn.Next;
            }
        }

        public void PrintP()
        {
            ProductNode prn = Head1;
            while (prn != null)
            {
                Console.WriteLine($"Product name: {prn.Product.NameP} - Color: {prn.Product.Color} - Cost: {prn.Product.Cost}");
                prn = prn.Next;
            }
        }

        public void PrintS()
        {
            ClientNode cn = Head;
            ProductNode prn = Head1;
            SaleNode sn = Head2;
            while (sn != null && prn != null && sn != null)
            {
                Console.WriteLine($"Customer: {cn.Client.Name}");
                cn = cn.Next;

                Console.WriteLine($"Product name: {prn.Product.NameP} - Cost: {prn.Product.Cost}");
                prn = prn.Next;

                Console.WriteLine("");
                sn = sn.Next;
            }
        }

        public void PrintStock()
        {
            ProductNode prn = Head1;
            while (prn != null)
            {
                Console.WriteLine($"Product name: {prn.Product.NameP} - Units available: {prn.Product.UnitsAvailable}");
                prn = prn.Next;
            }
        }

    }
}
