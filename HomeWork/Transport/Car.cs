using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Transport
{
    /// <summary>
    /// 2.	Разработать абстрактный класс «автомобиль» (класс Car). 
    ///     Собрать в нем все общие поля, свойства (например, скорость) методы (например, ехать).  
    /// </summary>
    public abstract class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }

        public event EventHandler<string> RaceFinished;

        protected Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public void StartRace()
        {
            Console.WriteLine($"{Model} выходит на старт.");
        }

        public void Move()
        {
            Console.WriteLine($"{Model} движется со скоростью {Speed}.");
            if (RaceFinished != null && Speed > 0 && Speed < 100)
            {
                RaceFinished(this, $"{Model} проехал {Speed} расстояния.");
            }
        }
    }
}
