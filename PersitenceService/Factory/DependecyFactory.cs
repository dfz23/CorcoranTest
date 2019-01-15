using LightInject;

namespace PersitenceService.Factory
{
    public class DependecyFactory
    {
        public static T GetInstance<T>()
        {
            return new ServiceContainer()
                .GetInstance<T>();
        }
    }
}
