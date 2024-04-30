using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eleventh_lesson
{
    public class Car<T> where T : AbstractEngine
    {
        public Car() { }
        public Car(T engine)
        {
            this.Engine = engine;
        }

        public T Engine { get; set; }

        public void StartCar()
        {
            Console.WriteLine($"Машина едет");
        }

        public void StopCar()
        {
            Console.WriteLine("Машина остановилась");
        }

    }
}
