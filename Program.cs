namespace Eleventh_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
           New_T_class<int> asd = new New_T_class<int>();
            asd.AddObject(1);
            asd.AddObject(2);
            asd.AddObject(3);

            foreach (int i in asd.massOne)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            asd.RemoveObject(1);
            foreach (int i in asd.massOne)
            {
                Console.WriteLine(i);
            }
        }
    }
}
