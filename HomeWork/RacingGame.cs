using HomeWork.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    /// <summary>
    /// 1.	Реализовать игру «Гонки». Принцип игры: 
    ///     Автомобили двигаются от старта к финишу со скоростями, которые изменяются в установленных пределах случайным образом. 
    ///     Победителем считается автомобиль, пришедший к финишу первым.
    /// 3.	Разработать классы автомобилей с конкретной реализацией конструкторов и методов, свойств. 
    ///     В классы автомобилей добавить необходимые события (например, финиш).
    /// 4.	Класс игры должен производить запуск соревнований автомобилей, 
    ///     выводить сообщения о текущем положении автомобилей, выводить сообщение об автомобиле, победившем в гонках. 
    ///     Создать делегаты, обеспечивающие вызов методов из классов автомобилей 
    ///     (например, выйти на старт, начать гонку).
    /// </summary>
    public class RacingGame
    {
        private List<string> results = new List<string>();

        public delegate void RaceEventHandler(object sender, string message);

        public event RaceEventHandler RaceStarted;

        public void StartRace(Car car)
        {
            RaceStarted?.Invoke(this, $"{car.Model} начинает гонку!\n");
            car.StartRace();
            car.Move();
        }

        public void FinishRace(object sender, string message)
        {
            string resultMessage = $"{((Car)sender).Model} пришел к финишу и занял {results.Count + 1}-е место!";
            results.Add(resultMessage);
            Console.WriteLine(message);
            Console.WriteLine($"Гонка завершена. {resultMessage}\n");
        }

        public void PrintResults()
        {
            Console.WriteLine("\nРезультаты гонки:\n");
            foreach (string result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
