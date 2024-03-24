using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WzorceProjektowe.API.Entities;

namespace WzorceProjektowe.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<PatternEntity> Patterns { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PatternEntity>().HasData(
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Adapter",
                Description = "The Adapter pattern allows objects with incompatible interfaces to collaborate.",
                Type = "Structural",
                Schema = "interface ITarget {\r\n    void Request();\r\n}\r\n\r\nclass Adaptee {\r\n    public void SpecificRequest() {\r\n        Console.WriteLine(\"Specific request\");\r\n    }\r\n}\r\n\r\nclass Adapter : ITarget {\r\n    private Adaptee _adaptee;\r\n\r\n    public Adapter(Adaptee adaptee) {\r\n        _adaptee = adaptee;\r\n    }\r\n\r\n    public void Request() {\r\n        _adaptee.SpecificRequest();\r\n    }\r\n}\r\n\r\nclass Client {\r\n    static void Main(string[] args) {\r\n        Adaptee adaptee = new Adaptee();\r\n        ITarget adapter = new Adapter(adaptee);\r\n        adapter.Request();\r\n    }\r\n}",
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Bridge",
                Description = "The Bridge pattern decouples an abstraction from its implementation so that the two can vary independently.",
                Type = "Structural",
                Schema = ""
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Composite",
                Description = "The Composite pattern composes objects into tree structures to represent part-whole hierarchies.",
                Type = "Structural",
                Schema = ""
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Decorator",
                Description = "The Decorator pattern attaches additional responsibilities to objects dynamically.",
                Type = "Structural",
                Schema = ""
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Facade",
                Description = "The Facade pattern provides a unified interface to a set of interfaces in a subsystem.",
                Type = "Structural",
                Schema = ""
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Flyweight",
                Description = "The Flyweight pattern minimizes memory usage and improves performance by sharing as much as possible with similar objects.",
                Type = "Structural",
                Schema = ""
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Proxy",
                Description = "The Proxy pattern provides a surrogate or placeholder for another object to control access to it.",
                Type = "Structural",
                Schema = ""
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Factory Method",
                Description = "The Factory Method pattern defines an interface for creating objects, but allows subclasses to alter the type of objects that will be created.",
                Type = "Creational",
                Schema = ""
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Abstract Factory",
                Description = "The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.",
                Type = "Creational",
                Schema = ""
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Builder",
                Description = "The Builder pattern separates the construction of a complex object from its representation, allowing the same construction process to create different representations.",
                Type = "Creational",
                Schema = ""
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Prototype",
                Description = "The Prototype pattern creates new objects by copying an existing object, known as the prototype.",
                Type = "Creational",
                Schema = ""
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Singleton",
                Description = "The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance.",
                Type = "Creational",
                Schema = ""
            }
            );
        }
    }
}
