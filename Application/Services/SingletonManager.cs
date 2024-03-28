namespace Application.Services
{
    public class SingletonManager
    {
        private static SingletonManager instance = null;
        private static readonly object padlock = new object();

        SingletonManager()
        {
        }

        public static SingletonManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonManager();
                    }
                    return instance;
                }
            }
        }

        // Add methods and properties here that will be accessible through the SingletonManager.Instance
    }

}
