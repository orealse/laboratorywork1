using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Car
    {
        //'Состояние' объекта Car.
        public string petName;
        public int currSpeed;

        //Специальный стандартный конструктор.
        public Car()
        {
            petName = "Cuck";
            currSpeed = 10;
        }

        //Здесь currSpeed получает стандартные значения для типа int (0).
        public Car(string pn)
        {
            petName = pn;
        }
        //Позволяет вызывающему коду установить полное состояние Car.
        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }

        // Функциональность Car.
        public void PrintState()
{
    Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);
}

        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
    }
}
