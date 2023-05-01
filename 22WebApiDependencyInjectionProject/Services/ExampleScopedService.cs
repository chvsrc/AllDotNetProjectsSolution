using System;
using _22WebApiDependencyInjectionProject.Interfaces;

namespace _22WebApiDependencyInjectionProject.Services
{
    public class ExampleScopedService : IExampleScopedService
    {
        private readonly Guid Id;

        public ExampleScopedService()
        {
            Id = Guid.NewGuid();
        }

        public string GetGuid() => Id.ToString();
    }
}
