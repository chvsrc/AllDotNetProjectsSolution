using System.Text;
using _22WebApiDependencyInjectionProject.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace _22WebApiDependencyInjectionProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IExampleTransientService _exampleTransientService1;
        private readonly IExampleTransientService _exampleTransientService2;

        private readonly IExampleScopedService _exampleScopedService1;
        private readonly IExampleScopedService _exampleScopedService2;

        private readonly IExampleSingletonService _exampleSingletonService1;
        private readonly IExampleSingletonService _exampleSingletonService2;

        public WeatherForecastController(IExampleTransientService exampleTransientService1,
            IExampleTransientService exampleTransientService2,
            IExampleScopedService exampleScopedService1,
            IExampleScopedService exampleScopedService2,
            IExampleSingletonService exampleSingletonService1,
            IExampleSingletonService exampleSingletonService2)
        {
            _exampleTransientService1 = exampleTransientService1;
            _exampleTransientService2 = exampleTransientService2;

            _exampleScopedService1 = exampleScopedService1;
            _exampleScopedService2 = exampleScopedService2;

            _exampleSingletonService1 = exampleSingletonService1;
            _exampleSingletonService2 = exampleSingletonService2;
        }

        [HttpGet]
        public string Get()
        {
            var exampleTransientServiceGuid1 = _exampleTransientService1.GetGuid();
            var exampleTransientServiceGuid2 = _exampleTransientService2.GetGuid();

            var exampleScopedServiceGuid1 = _exampleScopedService1.GetGuid();
            var exampleScopedServiceGuid2 = _exampleScopedService2.GetGuid();

            var exampleSingletonServiceGuid1 = _exampleSingletonService1.GetGuid();
            var exampleSingletonServiceGuid2 = _exampleSingletonService2.GetGuid();

            StringBuilder messages = new StringBuilder();
            messages.Append($"AddTransient : Create object for every Method.\n");
            messages.Append($"Transient 1: {exampleTransientServiceGuid1}\n");
            messages.Append($"Transient 2: {exampleTransientServiceGuid2}\n\n");

            messages.Append($"AddScoped : Create object for every REST call.\n");
            messages.Append($"Scoped 1: {exampleScopedServiceGuid1}\n");
            messages.Append($"Scoped 2: {exampleScopedServiceGuid2}\n\n");

            messages.Append($"AddSingleton : Create object only one time. \n");
            // i.e. at the time of published the application
            messages.Append($"Singleton 1: {exampleSingletonServiceGuid1}\n");
            messages.Append($"Singleton 2: {exampleSingletonServiceGuid2}");

            return messages.ToString();
        }
    }
}


