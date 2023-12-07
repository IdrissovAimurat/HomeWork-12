using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Transport
{
    public class Bus : Car
    {
        public Bus(string model) : base(model, new Random().Next(30, 60))
        {
            //Console.WriteLine("Блин, опять этот автобус мимо проехал...");
        }
    }
}
