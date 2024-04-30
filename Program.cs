namespace Eleventh_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Напишите обобщенный класс, который может хранить в массиве объекты любого
            //типа.Кроме того, данный класс должен иметь методы для добавления данных в
            //массив, удаления из массива, получения элемента из массива по индексу и
            //метод, возвращающий длину массива.
            //Для упрощения работы можно пересоздавать массив при каждой операции добавления
            //и удаления


            //New_T_class<int> asd = new New_T_class<int>();
            // asd.AddObject(1);
            // asd.AddObject(2);
            // asd.AddObject(3);

            // foreach (int i in asd.massOne)
            // {
            //     Console.WriteLine(i);
            // }
            // Console.WriteLine();
            // asd.RemoveObject(1);
            // foreach (int i in asd.massOne)
            // {
            //     Console.WriteLine(i);
            // }

            //      2.Реализовать класс Point, который определяет точку на координатной плоскости.
            //      В классе реализовать:
            //            внутренние поля x, y;
            //            конструктор с 2 параметрами;
            //            свойства доступа к внутренним полям класса;
            //            метод, выводящий значения внутренних полей класса


            //Point point = new Point(5,5);
            //point.WherePoint();
            //point.x = 6;
            //point.WherePoint();


         //     3.Реализовать класс машина у который будет поле обобщенное двигатель.
         //     Создать иерархию наследования для двигателей(абстрактный, дизельный, бензиновый, електро).
         //     Сделать так чтобы создать автомобиль можно было только передавая туда один из типов двигателя.Реализовать методы для движения автомобиля.

            ElectricEngine electricEngine = new ElectricEngine();
            Car<ElectricEngine> car = new Car<ElectricEngine>(electricEngine);

            car.StartCar();
        }
    }
}
