namespace ThreadSafeWithoutUsingLocks
{
    class ThreadSafeSingleton
    {
        private static readonly ThreadSafeSingleton instance = new ThreadSafeSingleton();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static ThreadSafeSingleton()
        {
        }

        private ThreadSafeSingleton()
        {
        }

        public static ThreadSafeSingleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
