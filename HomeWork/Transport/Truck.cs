using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Transport
{
    public class Truck : Car
    {
        public Truck(string model) : base(model, new Random().Next(40, 80))
        {
        }
    }
}
