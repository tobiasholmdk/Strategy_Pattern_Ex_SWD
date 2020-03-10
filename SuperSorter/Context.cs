namespace SuperSorter
{
    public class Context
    {
        private ISort strategy;

        public Context(ISort strategy)
        {
            this.strategy = strategy;
        }
        
        public void ExecuteStrategy(int[] arr, int maxSize, int seed)
        {
            strategy.SortArray(arr, maxSize,seed);
        }
    }
}