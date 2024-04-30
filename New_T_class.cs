namespace Eleventh_lesson
{
    public class New_T_class<T>
    {
        public New_T_class() { }

        public T[] massOne { get; set; } = new T[0];

        

        public void AddObject(T obj)
        {
            var massTwo = massOne;

            Array.Resize(ref massTwo, massTwo.Length + 1);

            massTwo[massTwo.Length - 1] = obj;

            massOne = massTwo;

        
        }
        public void RemoveObject(T obj)
        {
            var indexToRemove = Array.IndexOf(massOne, obj);

            var massTwo = new T[massOne.Length - 1];

            Array.Copy(massOne, 0, massTwo, 0, indexToRemove);
            Array.Copy(massOne, indexToRemove + 1, massTwo, indexToRemove, massOne.Length - indexToRemove - 1);

            massOne = massTwo;
        }

        public T TakeObject(int index)
        {
            return massOne[index];
        }

        public int CountMass()
        {
            return massOne.Length;
        }
    }
}
