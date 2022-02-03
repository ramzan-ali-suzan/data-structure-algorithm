namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new Array(2);
            array.Insert(20);
            array.Insert(30);
            array.Insert(40);

            array.InsertAt(10, 0);

            array.Print();

            Console.WriteLine();
        }
    }
}