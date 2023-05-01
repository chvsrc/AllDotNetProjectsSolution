using System;
using _22WebApiDependencyInjectionProject.Interfaces;

namespace _22WebApiDependencyInjectionProject.Services
{
    public class ExampleSingletonService : IExampleSingletonService
    {
        private readonly Guid Id;

        public ExampleSingletonService()
        {
            Id = Guid.NewGuid();
        }

        public string GetGuid() => Id.ToString();
    }
}