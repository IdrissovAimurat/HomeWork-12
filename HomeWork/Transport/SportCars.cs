using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Transport
{
    public class SportCars : Car
    {
        public SportCars(string model) : base(model, new Random().Next(80, 120))
        {
            //Console.WriteLine("Кчау");
        }
    }
}
