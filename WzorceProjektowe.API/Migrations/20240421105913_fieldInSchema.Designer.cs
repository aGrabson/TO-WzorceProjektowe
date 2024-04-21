﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WzorceProjektowe.API.Data;

#nullable disable

namespace WzorceProjektowe.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240421105913_fieldInSchema")]
    partial class fieldInSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WzorceProjektowe.API.Entities.PatternEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DynamicsCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Schema")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToInterpret")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Patterns");

                    b.HasData(
                        new
                        {
                            Id = new Guid("27eb0b5b-ed8e-4756-878d-630ba53ec970"),
                            Description = "The Adapter pattern allows objects with incompatible interfaces to collaborate.",
                            DynamicsCode = "",
                            Name = "Adapter",
                            Schema = "interface ITarget {\r\n    void Request();\r\n}\r\n\r\nclass Adaptee {\r\n    public void SpecificRequest() {\r\n        Console.WriteLine(\"Specific request\");\r\n    }\r\n}\r\n\r\nclass Adapter : ITarget {\r\n    private Adaptee _adaptee;\r\n\r\n    public Adapter(Adaptee adaptee) {\r\n        _adaptee = adaptee;\r\n    }\r\n\r\n    public void Request() {\r\n        _adaptee.SpecificRequest();\r\n    }\r\n}\r\n\r\nclass Client {\r\n    static void Main(string[] args) {\r\n        Adaptee adaptee = new Adaptee();\r\n        ITarget adapter = new Adapter(adaptee);\r\n        adapter.Request();\r\n    }\r\n}",
                            ToInterpret = "",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("2cb4e620-aabc-4675-bd36-56c9e2f32b46"),
                            Description = "The Bridge pattern decouples an abstraction from its implementation so that the two can vary independently.",
                            DynamicsCode = "",
                            Name = "Bridge",
                            Schema = "",
                            ToInterpret = "",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("73fbda00-c67e-4660-8641-eabd35ba44db"),
                            Description = "The Composite pattern composes objects into tree structures to represent part-whole hierarchies.",
                            DynamicsCode = "",
                            Name = "Composite",
                            Schema = "",
                            ToInterpret = "",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("cfefc139-0065-4d98-b73d-9e4cd5d3c2d4"),
                            Description = "The Decorator pattern attaches additional responsibilities to objects dynamically.",
                            DynamicsCode = "\r\n#splitfile#\r\nusing System;\r\npublic class #C# : #AC1#\r\n{\r\n    #F;#C#\r\n    #M;#C#\r\n    public #C#(#I1# component) : base(component)\r\n    {\r\n    }\r\n\r\n    public override void Operation()\r\n    {\r\n        base.Operation();\r\n        AddedBehavior();\r\n    }\r\n\r\n    private void AddedBehavior()\r\n    {\r\n        Console.WriteLine(\"Added behavior by ConcreteDecorator\");\r\n    }\r\n}\r\n",
                            Name = "Decorator",
                            Schema = "#splitfile#\r\npublic interface #I1#\r\n{\r\n    #F;#I1#\r\n    #M;#I1#\r\n    void Operation();\r\n}\r\n#splitfile#\r\npublic class #CC1# : #I1#\r\n{\r\n    #F;#CC1#\r\n    #M;#CC1#\r\n    public void Operation()\r\n    {\r\n        Console.WriteLine(\"ConcreteComponent operation\");\r\n    }\r\n}\r\n#splitfile#\r\npublic abstract class #AC1# : #I1#\r\n{\r\n    protected #I1# component;\r\n    \r\n    #F;#AC1#\r\n    #M;#AC1#\r\n\r\n    public #AC1#(#I1# component)\r\n    {\r\n        this.component = component;\r\n    }\r\n\r\n    public virtual void Operation()\r\n    {\r\n        component.Operation();\r\n    }\r\n}\r\n\r\n#DYNAMICS#\r\n#splitfile#\r\npublic class Program\r\n{\r\n    static void Main(string[] args)\r\n    {\r\n        // Tworzymy konkretne komponenty i dekorujemy je\r\n        #I1# component = new #CC1#();\r\n        #I1# decoratedComponent = new #C2#(component);\r\n\r\n        // Wywołujemy operację na dekoratorze, która przejdzie przez wszystkie dekoratory\r\n        decoratedComponent.Operation();\r\n\r\n        /*\r\n            Wynik działania programu:\r\n            ConcreteComponent operation\r\n            Added behavior by ConcreteDecorator\r\n        */\r\n    }\r\n}",
                            ToInterpret = "#I1#FajnyInterfejs# #CC1#Klasa# #AC1#AbstrakcyjnaKlasa# #C2#KlasaDekoratora#",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("622b0bc2-1bb7-466e-9eee-a2931bc4ebda"),
                            Description = "The Facade pattern provides a unified interface to a set of interfaces in a subsystem.",
                            DynamicsCode = "",
                            Name = "Facade",
                            Schema = "",
                            ToInterpret = "",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("039cf74b-3ed6-470b-97a4-c5d0b5ff51f9"),
                            Description = "The Flyweight pattern minimizes memory usage and improves performance by sharing as much as possible with similar objects.",
                            DynamicsCode = "",
                            Name = "Flyweight",
                            Schema = "",
                            ToInterpret = "",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("0c583dc0-a077-465b-a728-dcb395306340"),
                            Description = "The Proxy pattern provides a surrogate or placeholder for another object to control access to it.",
                            DynamicsCode = "",
                            Name = "Proxy",
                            Schema = "",
                            ToInterpret = "",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("e2d0fdb9-110f-46b7-a623-c91b81c28a56"),
                            Description = "The Factory Method pattern defines an interface for creating objects, but allows subclasses to alter the type of objects that will be created.",
                            DynamicsCode = "",
                            Name = "Factory Method",
                            Schema = "",
                            ToInterpret = "",
                            Type = "Creational"
                        },
                        new
                        {
                            Id = new Guid("d707e54c-de56-4ad6-a453-ec34a63da594"),
                            Description = "The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.",
                            DynamicsCode = "",
                            Name = "Abstract Factory",
                            Schema = "",
                            ToInterpret = "",
                            Type = "Creational"
                        },
                        new
                        {
                            Id = new Guid("a8605a70-b59f-4658-ab70-d275a39c5c79"),
                            Description = "The Builder pattern separates the construction of a complex object from its representation, allowing the same construction process to create different representations.",
                            DynamicsCode = "",
                            Name = "Builder",
                            Schema = "",
                            ToInterpret = "",
                            Type = "Creational"
                        },
                        new
                        {
                            Id = new Guid("5808f582-29ec-49a3-b87c-461323f8cef5"),
                            Description = "The Prototype pattern creates new objects by copying an existing object, known as the prototype.",
                            DynamicsCode = "",
                            Name = "Prototype",
                            Schema = "",
                            ToInterpret = "",
                            Type = "Creational"
                        },
                        new
                        {
                            Id = new Guid("78a6d753-bb49-4769-8fce-448de83578cc"),
                            Description = "The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance.",
                            DynamicsCode = "",
                            Name = "Singleton",
                            Schema = "",
                            ToInterpret = "",
                            Type = "Creational"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
