using System;
using DependencyInjectionProject.Interfaces;

namespace DependencyInjectionProject.Services
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
