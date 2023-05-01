using System;
using _22WebApiDependencyInjectionProject.Interfaces;

namespace _22WebApiDependencyInjectionProject.Services
{
    public class ExampleTransientService : IExampleTransientService
    {
        private readonly Guid Id;

        public ExampleTransientService()
        {
            Id = Guid.NewGuid();
        }

        public string GetGuid() => Id.ToString();
    }
}