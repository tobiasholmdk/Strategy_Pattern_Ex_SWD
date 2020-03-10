using System;

namespace SuperSorter
{
    public class RandomTal
    {
        private int i = 0;
        public int[]Generator(int size, int maxSize, int seed)
        {
            int[] tallene = new int[size];
            var rand = new Random(seed);
            while(i != size)
            {
                tallene[i] = rand.Next(0, maxSize);
                i++;
            }
            return tallene;
        }
        
    }
}