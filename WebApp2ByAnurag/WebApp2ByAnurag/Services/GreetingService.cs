using System;
namespace WebApp2ByAnurag.Services
{
    public class GreetingService : IGreetingService
    {
        public string GetGreeting()
        {
            return "Hello, welcome to our MVC application from GreetingService!";
        }
    }
}