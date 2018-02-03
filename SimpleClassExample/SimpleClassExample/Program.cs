using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Class Types *****\n");

             /*//Создать объект Human по имени Perry имеет возрост 10 лет.
            Human chuck = new Human();
            chuck.PrintState();

            //Создать объект Human по имени Mary имеет возрост 15 лет.
            Human mary = new Human("Ted",15);
            mary.PrintState();

            //Создать объект Human по имени Daisy имеет возрост 45 лет.
            Human daisy = new Human("Daisy", 45);
            daisy.PrintState();*/

           //Вызов стандартного конструктора.
            Car chuck = new Car();
            //Выводит "Chuck is going 10 MPH."
            chuck.PrintState();
            //Разместитьв памяти и сконфигурировать объект Car.
            Car myCar;
            myCar = new Car();
            myCar.petName = "Fred";
            myCar.currSpeed = 10;

            // Увеличить скорость автомобиля в несколько раз и вывести новое состояние.
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }
            Console.ReadLine();
        }
    }
}
