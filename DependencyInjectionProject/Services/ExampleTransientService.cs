using System;
using DependencyInjectionProject.Interfaces;

namespace DependencyInjectionProject.Services
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