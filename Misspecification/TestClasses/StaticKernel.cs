using Ninject;

namespace Misspecification.TestClasses
{
    public class StaticKernel
    {
        private static IKernel _instance;
        static StaticKernel()
        {
            _instance = new StandardKernel();
        }

        public static IKernel Instance { get { return _instance; } }
    }
}
