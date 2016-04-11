using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TaskSerialization
{
    public class LargeProduct:Product
    {
        public double costLarge { get; set; }
        public LargeProduct() : base()
        { }
        public LargeProduct(string name, int quant, double cost) : base(name, quant)
        {
            costLarge = cost;
            Cost = CostTransit();
        }
        public override double CostTransit()
        {
            return costLarge + (costLarge * 40) / 100;
        }
    }
}
