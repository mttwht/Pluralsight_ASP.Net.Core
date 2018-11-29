using Microsoft.Extensions.Configuration;

namespace OdeToFood.Services
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        private IConfiguration _config;

        public Greeter (IConfiguration config)
        {
            _config = config;
        }

        public string GetMessageOfTheDay()
        {
            return _config["Greeting"];
        }
    }
}