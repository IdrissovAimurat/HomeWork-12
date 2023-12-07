using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork.Transport;

namespace HomeWork
{
    /// <summary>
    /// 1.	В игре использовать несколько типов автомобилей: спортивные, легковые, грузовые и автобусы. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            RacingGame racingGame = new RacingGame();

            SportCars Gran_Turismo = new SportCars("Мак Ларен");
            Camryuha kazakhCar = new Camryuha("Камри");
            Truck truck = new Truck("ЗИЛ");
            Bus bus = new Bus("Автобус №63");

            racingGame.RaceStarted += (sender, message) => Console.WriteLine(message);
            Gran_Turismo.RaceFinished += racingGame.FinishRace;
            kazakhCar.RaceFinished += racingGame.FinishRace;
            truck.RaceFinished += racingGame.FinishRace;
            bus.RaceFinished += racingGame.FinishRace;

            racingGame.StartRace(Gran_Turismo);
            racingGame.StartRace(kazakhCar);
            racingGame.StartRace(truck);
            racingGame.StartRace(bus);

            racingGame.PrintResults();
        }
    }
}
