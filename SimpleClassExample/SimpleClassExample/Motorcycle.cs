using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;
        public string driverName;
        // Единственный конструктор, использующий необязательные аргументы.
         public Motorcycle(int intensity = 0, string name = "")
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            driverName = name;
        }
        //Связывание конструкторов в цепочку.
        public Motorcycle()
        { }
        public Motorcycle(int intensity)
            : this (intensity,"") {}
        public Motorcycle(string name)
            : this (0, name) {}
        // Это главный конструктор, выполняющий всю реальную работу.
       
        //Новые члены для предоставления имени водителя.
        public string name;
        public void SetDriverName(string name)
        {
            this.name = name;
        }
        public void PopAWheely()
        {
            for (int i = 0; i <= driverIntensity; i++)
            {
                Console.WriteLine("Yeeeeeee Haaaeeww!");
            }
        }

        /*Вернуть стандартный конструктор, который будет устанавливать
        //для всех членов данных стандартные значения.
        public Motorcycle(int intensity)
        {
           
        }

        Специальный конструктор.*/
    }
}

