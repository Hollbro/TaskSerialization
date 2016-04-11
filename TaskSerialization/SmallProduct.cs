using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TaskSerialization
{
    public class SmallProduct:Product
    {
        public double costSmall { get; set; }
        public SmallProduct() : base()
        { }
        public SmallProduct(string name, int quant, double cost) : base(name, quant)
        {
            costSmall = cost;
            Cost = CostTransit();
        }
        public override double CostTransit()
        {
            return costSmall;
        }
    }
}
