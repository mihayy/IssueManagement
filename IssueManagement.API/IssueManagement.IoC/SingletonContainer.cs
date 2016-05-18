using Castle.Windsor;

namespace IssueManagement.IoC
{
    public class SingletonContainer : ISingletonContainer
    {
        private static volatile SingletonContainer _instance;
        private static readonly object SyncRoot = new object();

        private SingletonContainer() { }

        public static SingletonContainer Instance
        {
            get
            {
                if (_instance != null) return _instance;
                lock (SyncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonContainer();
                    }
                }
                return _instance;
            }
        }

        public IWindsorContainer GetContainer { get; private set; }

        public void Initialize(IWindsorContainer container)
        {
            GetContainer = container;
        }
    }
}
