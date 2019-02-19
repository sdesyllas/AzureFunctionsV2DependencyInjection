using Startup.Abstract;

namespace Startup.Concrete
{
    public class WelcomeService : IWelcomeService
    {
        public string WelcomeMessage()
        {
            return "Hello World";
        }
    }
}
