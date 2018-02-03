using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Human
    {
        //'Состояние' объекта Human.
        public string Name;
        public int Year;

        //Специальный стандартный конструктор.
        public Human()
        {
            Name = "Perry";
            Year = 10;
        }

        //Здесь currSpeed получает стандартные значения для типа int (0).
        public Human(string pn)
        {
            Name = pn;
        }
        //Позволяет вызывающему коду установить полное состояние Car.
        public Human(string pn, int cs)
        {
           Name = pn;
           Year = cs;
        }

        // Функциональность Car.
        public void PrintState()
{
    Console.WriteLine("{0}  {1} years", Name, Year);
}
    }
}
