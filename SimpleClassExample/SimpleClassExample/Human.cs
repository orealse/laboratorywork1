using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Human
    {
        public int driverIntensity;
        public string driverName;
        //Связывание конструкторов в цепочку.
        public Human()
        { }
        public Human(int intensity)
            : this (intensity,"") {}
        public Human(string name)
            : this (0, name) {}
        // Это главный конструктор, выполняющий всю реальную работу.
        public Human(int intensity = 0, string name = "")
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }
        //Новые члены для предоставления имени.
        public string name;
        public void SetDriverName(string name)
        {
            this.name = name;
        }
        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Hmmmmm Hmmmmm!");
            }
        }

        /*Вернуть стандартный конструктор, который будет устанавливать
        //для всех членов данных стандартные значения.
        public Motorcycle(int intensity)
        {
           
        }

        Специальный конструктор.
    }
}
        //'Состояние' объекта Human.
        public string Name;
        public int Year;

         //Связывание конструкторов в цепочку.
        public Human()
        { }
        public Human(int intensity)
            : this (intensity,"") {}
        public Human(string name)
            : this (0, name) {}

        //Специальный стандартный конструктор.
        public Human()
        {
            Name = "Perry";
            Year = 10;
        }

        //Здесь Name получает стандартные значения для типа int (0).
        public Human(string pn)
        {
            Name = pn;
        }
        //Позволяет вызывающему коду установить полное состояние Human.
        public Human(string pn, int cs)
        {
           Name = pn;
           Year = cs;
        }

        // Функциональность Human.
        public void PrintState() 
        {}

            public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaeeww!");
            }
    Console.WriteLine("{0}  {1} years", Name, Year);*/
}
    }

