using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Transport
{
    public class Camryuha : Car
    {
        public Camryuha(string model) : base(model, new Random().Next(60, 100))
        {
            //Console.WriteLine("80-тка");
        }
    }
}
