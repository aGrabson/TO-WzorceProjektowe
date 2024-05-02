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
                Id = Guid.Parse("21ada38f-cd9b-4231-b564-d6c5f3412260"),
                Name = "Adapter",
                Description = "The Adapter pattern allows objects with incompatible interfaces to collaborate.",
                Type = "Structural",
                Schema = "interface ITarget {\r\n    void Request();\r\n}\r\n\r\nclass Adaptee {\r\n    public void SpecificRequest() {\r\n        Console.WriteLine(\"Specific request\");\r\n    }\r\n}\r\n\r\nclass Adapter : ITarget {\r\n    private Adaptee _adaptee;\r\n\r\n    public Adapter(Adaptee adaptee) {\r\n        _adaptee = adaptee;\r\n    }\r\n\r\n    public void Request() {\r\n        _adaptee.SpecificRequest();\r\n    }\r\n}\r\n\r\nclass Client {\r\n    static void Main(string[] args) {\r\n        Adaptee adaptee = new Adaptee();\r\n        ITarget adapter = new Adapter(adaptee);\r\n        adapter.Request();\r\n    }\r\n}",
                DynamicsCode = "",
                ToInterpret = "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
            },
            new PatternEntity
            {
                Id = Guid.Parse("249dbdc9-acc3-449d-8968-634c089e7ba1"),
                Name = "Bridge",
                Description = "The Bridge pattern decouples an abstraction from its implementation so that the two can vary independently.",
                Type = "Structural",
                Schema = "",
                DynamicsCode = "",
                ToInterpret = "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
            },
            new PatternEntity
            {
                Id = Guid.Parse("493b34a1-12e1-4967-aa6c-a54cd9d147f9"),
                Name = "Composite",
                Description = "The Composite pattern composes objects into tree structures to represent part-whole hierarchies.",
                Type = "Structural",
                Schema = "",
                DynamicsCode = "",
                ToInterpret = "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
            },
            new PatternEntity
            {
                Id = Guid.Parse("6469a535-507a-44fd-b9d7-dcf831847a21"),
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
        #I1# component = new #CC1#();
        #I1# decoratedComponent = new #C2#(component);

        decoratedComponent.Operation();
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
                DynamicMethodI = $"#TYPE# #NAME# (#PARAMS#);\n    ",
                DynamicMethodC = @$"
    public virtual #TYPE# #NAME#(#PARAMS#){{
        component.#NAME#(#NOTYPEPARAMS#);
    }}",
                DynamicMethodAC = @$"
    public #TYPE# #NAME#(#PARAMS#){{
        throw new NotImplementedException();
    }}",
            },
            new PatternEntity
            {
                Id = Guid.Parse("6706a7fc-0d05-4484-a9eb-54d4a47723a1"),
                Name = "Facade",
                Description = "The Facade pattern provides a unified interface to a set of interfaces in a subsystem.",
                Type = "Structural",
                Schema = "",
                DynamicsCode = "",
                ToInterpret= "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
            },
            new PatternEntity
            {
                Id = Guid.Parse("6c2afb6f-bcc5-4d02-92ef-b7df12fd0fac"),
                Name = "Flyweight",
                Description = "The Flyweight pattern minimizes memory usage and improves performance by sharing as much as possible with similar objects.",
                Type = "Structural",
                Schema = "",
                DynamicsCode = "",
                ToInterpret = "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
            },
            new PatternEntity
            {
                Id = Guid.Parse("752a9281-8840-4d7b-8fd6-5da1b3eee655"),
                Name = "Proxy",
                Description = "The Proxy pattern provides a surrogate or placeholder for another object to control access to it.",
                Type = "Structural",
                Schema = "",
                DynamicsCode = "",
                ToInterpret = "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
            },
            new PatternEntity
            {
                Id = Guid.Parse("bfdf0acd-cb53-4f6d-8502-5369af29c23f"),
                Name = "Factory Method",
                Description = "The Factory Method pattern defines an interface for creating objects, but allows subclasses to alter the type of objects that will be created.",
                Type = "Creational",
                Schema = "",
                DynamicsCode = "",
                ToInterpret = "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
            },
            new PatternEntity
            {
                Id = Guid.Parse("d5842261-670b-4896-8697-4e4c263cd86f"),
                Name = "Abstract Factory",
                Description = "The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.",
                Type = "Creational",
                Schema = "",
                DynamicsCode = "",
                ToInterpret = "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
            },
            new PatternEntity
            {
                Id = Guid.Parse("da697d34-84c0-476a-a083-6e8b00209367"),
                Name = "Builder",
                Description = "The Builder pattern separates the construction of a complex object from its representation, allowing the same construction process to create different representations.",
                Type = "Creational",
                Schema = "",
                DynamicsCode = "",
                ToInterpret = "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
            },
            new PatternEntity
            {
                Id = Guid.Parse("f83fc61f-16b4-4160-9116-12d7c8c0c734"),
                Name = "Prototype",
                Description = "The Prototype pattern creates new objects by copying an existing object, known as the prototype.",
                Type = "Creational",
                Schema = "",
                DynamicsCode = "",
                ToInterpret = "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
            },
            new PatternEntity
            {
                Id = Guid.Parse("ffb8c2cb-3b24-4bbe-b4bd-35061073ee98"),
                Name = "Singleton",
                Description = "The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance.",
                Type = "Creational",
                Schema = "",
                DynamicsCode = "",
                ToInterpret = "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
            }
            );
        }
    }
}
