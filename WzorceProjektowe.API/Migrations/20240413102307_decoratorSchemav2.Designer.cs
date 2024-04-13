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
    [Migration("20240413102307_decoratorSchemav2")]
    partial class decoratorSchemav2
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
                            Id = new Guid("ffb8c2cb-3b24-4bbe-b4bd-35061073ee98"),
                            Description = "The Adapter pattern allows objects with incompatible interfaces to collaborate.",
                            DynamicsCode = "",
                            Name = "Adapter",
                            Schema = "interface ITarget {\r\n    void Request();\r\n}\r\n\r\nclass Adaptee {\r\n    public void SpecificRequest() {\r\n        Console.WriteLine(\"Specific request\");\r\n    }\r\n}\r\n\r\nclass Adapter : ITarget {\r\n    private Adaptee _adaptee;\r\n\r\n    public Adapter(Adaptee adaptee) {\r\n        _adaptee = adaptee;\r\n    }\r\n\r\n    public void Request() {\r\n        _adaptee.SpecificRequest();\r\n    }\r\n}\r\n\r\nclass Client {\r\n    static void Main(string[] args) {\r\n        Adaptee adaptee = new Adaptee();\r\n        ITarget adapter = new Adapter(adaptee);\r\n        adapter.Request();\r\n    }\r\n}",
                            ToInterpret = "",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("d5842261-670b-4896-8697-4e4c263cd86f"),
                            Description = "The Bridge pattern decouples an abstraction from its implementation so that the two can vary independently.",
                            DynamicsCode = "",
                            Name = "Bridge",
                            Schema = "",
                            ToInterpret = "",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("6706a7fc-0d05-4484-a9eb-54d4a47723a1"),
                            Description = "The Composite pattern composes objects into tree structures to represent part-whole hierarchies.",
                            DynamicsCode = "",
                            Name = "Composite",
                            Schema = "",
                            ToInterpret = "",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("bfdf0acd-cb53-4f6d-8502-5369af29c23f"),
                            Description = "The Decorator pattern attaches additional responsibilities to objects dynamically.",
                            DynamicsCode = "\r\n#splitfile#\r\nusing System;\r\npublic class #C# : #AC1#\r\n{{\r\n    public #C#(#I1# component) : base(component)\r\n    {{\r\n    }}\r\n\r\n    public override void Operation()\r\n    {{\r\n        base.Operation();\r\n        AddedBehavior();\r\n    }}\r\n\r\n    private void AddedBehavior()\r\n    {{\r\n        Console.WriteLine(\"Added behavior by ConcreteDecorator\");\r\n    }}\r\n}}\r\n",
                            Name = "Decorator",
                            Schema = "#splitfile#\r\npublic interface #I1#\r\n{\r\n    void Operation();\r\n}\r\n#splitfile#\r\npublic class #C1# : #I1#\r\n{\r\n    public void Operation()\r\n    {\r\n        Console.WriteLine(\"ConcreteComponent operation\");\r\n    }\r\n}\r\n#splitfile#\r\npublic abstract class #AC1# : #I1#\r\n{\r\n    protected #I1# component;\r\n\r\n    public #AC1#(#I1# component)\r\n    {\r\n        this.component = component;\r\n    }\r\n\r\n    public virtual void Operation()\r\n    {\r\n        component.Operation();\r\n    }\r\n}\r\n#splitfile#\r\nusing System;\r\npublic class #C2# : #AC1#\r\n{\r\n    public #C2#(#I1# component) : base(component)\r\n    {\r\n    }\r\n\r\n    public override void Operation()\r\n    {\r\n        base.Operation();\r\n        AddedBehavior();\r\n    }\r\n\r\n    private void AddedBehavior()\r\n    {\r\n        Console.WriteLine(\"Added behavior by ConcreteDecorator\");\r\n    }\r\n}\r\n\r\n#DYNAMICS#\r\n#splitfile#\r\npublic class Program\r\n{\r\n    static void Main(string[] args)\r\n    {\r\n        // Tworzymy konkretne komponenty i dekorujemy je\r\n        #I1# component = new #C1#();\r\n        #I1# decoratedComponent = new #C2#(component);\r\n\r\n        // Wywołujemy operację na dekoratorze, która przejdzie przez wszystkie dekoratory\r\n        decoratedComponent.Operation();\r\n\r\n        /*\r\n            Wynik działania programu:\r\n            ConcreteComponent operation\r\n            Added behavior by ConcreteDecorator\r\n        */\r\n    }\r\n}",
                            ToInterpret = "#I1#FajnyInterfejs# #C1#Klasa# #AC1#AbstrakcyjnaKlasa# #C2#KlasaDekoratora#",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("6c2afb6f-bcc5-4d02-92ef-b7df12fd0fac"),
                            Description = "The Facade pattern provides a unified interface to a set of interfaces in a subsystem.",
                            DynamicsCode = "",
                            Name = "Facade",
                            Schema = "",
                            ToInterpret = "",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("752a9281-8840-4d7b-8fd6-5da1b3eee655"),
                            Description = "The Flyweight pattern minimizes memory usage and improves performance by sharing as much as possible with similar objects.",
                            DynamicsCode = "",
                            Name = "Flyweight",
                            Schema = "",
                            ToInterpret = "",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("493b34a1-12e1-4967-aa6c-a54cd9d147f9"),
                            Description = "The Proxy pattern provides a surrogate or placeholder for another object to control access to it.",
                            DynamicsCode = "",
                            Name = "Proxy",
                            Schema = "",
                            ToInterpret = "",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("249dbdc9-acc3-449d-8968-634c089e7ba1"),
                            Description = "The Factory Method pattern defines an interface for creating objects, but allows subclasses to alter the type of objects that will be created.",
                            DynamicsCode = "",
                            Name = "Factory Method",
                            Schema = "",
                            ToInterpret = "",
                            Type = "Creational"
                        },
                        new
                        {
                            Id = new Guid("21ada38f-cd9b-4231-b564-d6c5f3412260"),
                            Description = "The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.",
                            DynamicsCode = "",
                            Name = "Abstract Factory",
                            Schema = "",
                            ToInterpret = "",
                            Type = "Creational"
                        },
                        new
                        {
                            Id = new Guid("f83fc61f-16b4-4160-9116-12d7c8c0c734"),
                            Description = "The Builder pattern separates the construction of a complex object from its representation, allowing the same construction process to create different representations.",
                            DynamicsCode = "",
                            Name = "Builder",
                            Schema = "",
                            ToInterpret = "",
                            Type = "Creational"
                        },
                        new
                        {
                            Id = new Guid("da697d34-84c0-476a-a083-6e8b00209367"),
                            Description = "The Prototype pattern creates new objects by copying an existing object, known as the prototype.",
                            DynamicsCode = "",
                            Name = "Prototype",
                            Schema = "",
                            ToInterpret = "",
                            Type = "Creational"
                        },
                        new
                        {
                            Id = new Guid("6469a535-507a-44fd-b9d7-dcf831847a21"),
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