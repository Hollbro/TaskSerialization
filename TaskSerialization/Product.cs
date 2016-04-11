using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TaskSerialization
{
    [XmlInclude(typeof(SmallProduct))]
    [XmlInclude(typeof(LargeProduct))]
    public abstract class Product
    {
            public Product()
            { }
            public Product(string nameP, int quantity)
            {
                NameProduct = nameP;
                QuantityProduct = quantity;
            }

            public string NameProduct { get; set; }
            public int QuantityProduct { get; set; }
            public double Cost { get; set; }
            public abstract double CostTransit();
            public override string ToString()
            {
                return ("Product Name = " + NameProduct + " Quantity Products = " + QuantityProduct + " Cost = " + Cost);
            }
        }
}
