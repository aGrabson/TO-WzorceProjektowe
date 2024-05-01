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
                DynamicsCode = "",
                ToInterpret = "",
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Bridge",
                Description = "The Bridge pattern decouples an abstraction from its implementation so that the two can vary independently.",
                Type = "Structural",
                Schema = "",
                DynamicsCode = "",
                ToInterpret = "",
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Composite",
                Description = "The Composite pattern composes objects into tree structures to represent part-whole hierarchies.",
                Type = "Structural",
                Schema = "",
                DynamicsCode = "",
                ToInterpret = "",
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Decorator",
                Description = "The Decorator pattern attaches additional responsibilities to objects dynamically.",
                Type = "Structural",
                Schema = @"#splitfile#
public interface #I1#
{
    #F;#I1#
    #M;#I1#
    void Operation();
}
#splitfile#
public class #CC1# : #I1#
{
    #F;#CC1#
    #M;#CC1#
    public void Operation()
    {
        Console.WriteLine(""ConcreteComponent operation"");
    }
}
#splitfile#
public abstract class #AC1# : #I1#
{
    protected #I1# component;
    
    #F;#AC1#
    #M;#AC1#

    public #AC1#(#I1# component)
    {
        this.component = component;
    }

    public virtual void Operation()
    {
        component.Operation();
    }
}

#DYNAMICS#
#splitfile#
public class Program
{
    static void Main(string[] args)
    {
        // Tworzymy konkretne komponenty i dekorujemy je
        #I1# component = new #CC1#();
        #I1# decoratedComponent = new #C2#(component);

        // Wywołujemy operację na dekoratorze, która przejdzie przez wszystkie dekoratory
        decoratedComponent.Operation();

        /*
            Wynik działania programu:
            ConcreteComponent operation
            Added behavior by ConcreteDecorator
        */
    }
}",
                DynamicsCode = @"
#splitfile#
using System;
public class #C# : #AC1#
{
    #F;#C#
    #M;#C#
    public #C#(#I1# component) : base(component)
    {
    }

    public override void Operation()
    {
        base.Operation();
        AddedBehavior();
    }

    private void AddedBehavior()
    {
        Console.WriteLine(""Added behavior by ConcreteDecorator"");
    }
}
",
                ToInterpret = "#I1#FajnyInterfejs# #CC1#Klasa# #AC1#AbstrakcyjnaKlasa# #C2#KlasaDekoratora# ",
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Facade",
                Description = "The Facade pattern provides a unified interface to a set of interfaces in a subsystem.",
                Type = "Structural",
                Schema = "",
                DynamicsCode = "",
                ToInterpret= "",
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Flyweight",
                Description = "The Flyweight pattern minimizes memory usage and improves performance by sharing as much as possible with similar objects.",
                Type = "Structural",
                Schema = "",
                DynamicsCode = "",
                ToInterpret = "",
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Proxy",
                Description = "The Proxy pattern provides a surrogate or placeholder for another object to control access to it.",
                Type = "Structural",
                Schema = "",
                DynamicsCode = "",
                ToInterpret = "",
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Factory Method",
                Description = "The Factory Method pattern defines an interface for creating objects, but allows subclasses to alter the type of objects that will be created.",
                Type = "Creational",
                Schema = "",
                DynamicsCode = "",
                ToInterpret = "",
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Abstract Factory",
                Description = "The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.",
                Type = "Creational",
                Schema = "",
                DynamicsCode = "",
                ToInterpret = "",
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Builder",
                Description = "The Builder pattern separates the construction of a complex object from its representation, allowing the same construction process to create different representations.",
                Type = "Creational",
                Schema = "",
                DynamicsCode = "",
                ToInterpret = "",
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Prototype",
                Description = "The Prototype pattern creates new objects by copying an existing object, known as the prototype.",
                Type = "Creational",
                Schema = "",
                DynamicsCode = "",
                ToInterpret = "",
            },
            new PatternEntity
            {
                Id = Guid.NewGuid(),
                Name = "Singleton",
                Description = "The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance.",
                Type = "Creational",
                Schema = "",
                DynamicsCode = "",
                ToInterpret = "",
            }
            );
        }
    }
}
