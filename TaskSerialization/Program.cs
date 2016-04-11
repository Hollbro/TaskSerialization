using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Xml.Serialization;

namespace TaskSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productBD = new List<Product>()
            {
                new SmallProduct("спички",100,500),
                new SmallProduct("сигареты",50,5000),
                new SmallProduct("ручки",20,300),
                new SmallProduct("конфеты",60,200),
                new SmallProduct("телефон мобильный",1,23000),
                new LargeProduct("тушенка",40,4000),
                new LargeProduct("системный блок",10,30000),
                new LargeProduct("колеса",20,120000),
                new LargeProduct("телевизор",40,800000),
                new LargeProduct("запчасти",5,77777),
            };
            var sortedProd = from a in productBD
                             orderby a.Cost, a.NameProduct
                             select a;
            Console.WriteLine("sorted product \n");
            foreach (var a in sortedProd)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\n");
            Console.ReadKey();

            Console.WriteLine("first 6 sorted product \n");
            var giveFirstFive = sortedProd.Take(6);
            foreach (var a in giveFirstFive)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\n");

            using (FileStream threadOne = new FileStream(@"C:\Users\ibs_admin\Desktop\task\bd.xml", FileMode.OpenOrCreate, FileAccess.Write))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Product>));
                ser.Serialize(threadOne, productBD);
            }

            using (FileStream threadTwo = new FileStream(@"C:\Users\ibs_admin\Desktop\task\bd.xml", FileMode.Open, FileAccess.Read))
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Product>));
                List<Product> deserializBD = (List<Product>)ser.Deserialize(threadTwo);
            }
            Console.ReadKey();
        }
    }
}
