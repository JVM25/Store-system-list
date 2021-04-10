using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Store_System.Store_System_V1
{
    class Program
    {
        public static void Main(String[] args)
        {
            CompanyList companyList = new CompanyList();

            Client c1 = new Client();
            c1.Name = "Jeison";
            c1.Age = 24;
            companyList.AddC(c1);

            Client c2 = new Client();
            c2.Name = "Nohelia";
            c2.Age = 40;
            companyList.AddC(c2);

            Client c3 = new Client();
            c3.Name = "Leonardo";
            c3.Age = 52;
            companyList.AddC(c3);

            Client c4 = new Client();
            c4.Name = "Valentina";
            c4.Age = 18;
            companyList.AddC(c4);


            Product p1 = new Product();
            p1.NameP = "Pillows";
            p1.Color = "Black";
            p1.Cost = 45000;
            p1.UnitsAvailable = 50;
            companyList.AddP(p1);
            
            Product p2 = new Product();
            p2.NameP = "Blanket";
            p2.Color = "White";
            p2.Cost = 55000;
            p2.UnitsAvailable = 100;
            companyList.AddP(p2);

            Product p3 = new Product();
            p3.NameP = "Quilted";
            p3.Color = "Dark blue";
            p3.Cost = 120000;
            p3.UnitsAvailable = 80;
            companyList.AddP(p3);

            Product p4 = new Product();
            p4.NameP = "Bed";
            p4.Color = "Brown";
            p4.Cost = 950000;
            p4.UnitsAvailable = 200;
            companyList.AddP(p4);

            Product p5 = new Product();
            p5.NameP = "Closet";
            p5.Color = "Black";
            p5.Cost = 650000;
            p5.UnitsAvailable = 150;
            companyList.AddP(p5);


            Sale s1 = new Sale();
            s1.Client = c1;
            s1.Product = p1;
            s1.Product = p3;
            s1.Amount = 2;
            companyList.AddS(s1);
            companyList.AddSale(s1);

            Sale s2 = new Sale();
            s2.Client = c2;
            s2.Product = p1;
            s2.Product = p2;
            s2.Product = p3;
            s2.Product = p5;
            s2.Amount = 4;
            companyList.AddS(s2);
            companyList.AddSale(s2);

            Sale s3 = new Sale();
            s3.Client = c3;
            s3.Product = p1;
            s3.Product = p2;
            s3.Product = p3;
            s3.Product = p4;
            s3.Product = p5;
            s3.Amount = 5;
            companyList.AddS(s3);
            companyList.AddSale(s3);

            Sale s4 = new Sale();
            s4.Client = c4;
            s4.Product = p2;
            s4.Product = p5;
            s4.Amount = 2;
            companyList.AddS(s4);
            companyList.AddSale(s4);


            Console.WriteLine("");
            Console.WriteLine("---------- CLIENTS ----------");
            companyList.PrintC();

            Console.WriteLine("");
            Console.WriteLine("---------- PRODUCTS ----------");
            companyList.PrintP();

            Console.WriteLine("");
            Console.WriteLine("---------- SALES ----------");
            companyList.PrintS();

            float totalCost = companyList.TotalAmount();
            float TotalPriceAverage = companyList.AverageSale();
            Sale ImportantSale = companyList.ImportantSale();
            Sale ImportantClient = companyList.ImportantClient();

            Console.WriteLine("");
            Console.WriteLine("---------- TOTAL SALES AMOUNT ----------");
            Console.WriteLine(totalCost);

            Console.WriteLine("");
            Console.WriteLine("---------- MOST IMPORTANT SALE MADE BY ----------");
            Console.WriteLine(ImportantClient.Client.Name);

            Console.WriteLine("");
            Console.WriteLine("---------- BEST SELLING PRODUCT ----------");
            Console.WriteLine(ImportantSale.Product.NameP);

            Console.WriteLine("");
            Console.WriteLine("---------- TOTAL PRICES AVERAGE ----------");
            Console.WriteLine(totalCost / TotalPriceAverage);

            Console.WriteLine("");
            Console.WriteLine("---------- PRODUCTS STOCK ----------");
            companyList.PrintStock();

            Console.WriteLine("");
            Console.WriteLine("---------- INSERT C4 AFTER C2 ----------");
            companyList.InsertAfterC(c4, c2);
            companyList.PrintC();

            Console.WriteLine("");
            Console.WriteLine("---------- REMOVE c1  ----------");
            companyList.RemoveC();
            companyList.PrintC();

            Console.WriteLine("");
            Console.WriteLine("---------- INSERT p5 AFTER p1 ----------");
            companyList.InsertAfterP(p5, p1);
            companyList.PrintP();

            Console.WriteLine("");
            Console.WriteLine("---------- REMOVE p1  ----------");
            companyList.RemoveP();
            companyList.PrintP();

























        }
    }
}


            
