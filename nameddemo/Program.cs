using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namedargdemo
{
    class product
    {
        public void printorderdetails(string sellernm,int orderno,string productnm)
        {
            Console.WriteLine("Seller Name is:" + sellernm);
            Console.WriteLine("Order No is:" + orderno);
            Console.WriteLine("Product Name is:" + productnm);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            product p1 = new product();
            //int orderno = 123;
            p1.printorderdetails(productnm: "Notebook",sellernm: "Sanket", orderno:123 );
            Console.ReadLine();
        }
    }
}
