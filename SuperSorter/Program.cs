using System;

namespace SuperSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            int size, maxSize, seed;
            int [] array;
            Console.WriteLine("Insert size");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert Max");
            maxSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert seed");
            seed = Convert.ToInt32(Console.ReadLine());
            
            RandomTal RandomProgram = new RandomTal();
            Context context = new Context(new BogoSort());
            Context context2 = new Context(new QuickSort());
            
            array = RandomProgram.Generator(size, maxSize, seed);
                        
            foreach (var item in array)
                Console.WriteLine("Unsorted: " +item.ToString());
            
            context.ExecuteStrategy(array,maxSize,seed);
            context2.ExecuteStrategy();
            foreach (var item in array)
                Console.WriteLine("Sorted: " + item.ToString());
        }
    }
}