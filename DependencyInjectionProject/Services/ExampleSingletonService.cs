using System;
using DependencyInjectionProject.Interfaces;

namespace DependencyInjectionProject.Services
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