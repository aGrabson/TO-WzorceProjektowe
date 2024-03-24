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
    [Migration("20240320131218_morepatterns")]
    partial class morepatterns
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Schema")
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
                            Id = new Guid("3428fedf-1f30-45e9-84cc-a01189458cd6"),
                            Description = "The Adapter pattern allows objects with incompatible interfaces to collaborate.",
                            Name = "Adapter",
                            Schema = "interface ITarget {\r\n    void Request();\r\n}\r\n\r\nclass Adaptee {\r\n    public void SpecificRequest() {\r\n        Console.WriteLine(\"Specific request\");\r\n    }\r\n}\r\n\r\nclass Adapter : ITarget {\r\n    private Adaptee _adaptee;\r\n\r\n    public Adapter(Adaptee adaptee) {\r\n        _adaptee = adaptee;\r\n    }\r\n\r\n    public void Request() {\r\n        _adaptee.SpecificRequest();\r\n    }\r\n}\r\n\r\nclass Client {\r\n    static void Main(string[] args) {\r\n        Adaptee adaptee = new Adaptee();\r\n        ITarget adapter = new Adapter(adaptee);\r\n        adapter.Request();\r\n    }\r\n}",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("fa244eee-1914-4fc0-8e47-da2f1e8c1480"),
                            Description = "The Bridge pattern decouples an abstraction from its implementation so that the two can vary independently.",
                            Name = "Bridge",
                            Schema = "",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("dcc630e7-38a6-4b83-b144-67e39492df11"),
                            Description = "The Composite pattern composes objects into tree structures to represent part-whole hierarchies.",
                            Name = "Composite",
                            Schema = "",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("16f77f8f-9ea9-448b-97bf-ddbd02265865"),
                            Description = "The Decorator pattern attaches additional responsibilities to objects dynamically.",
                            Name = "Decorator",
                            Schema = "",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("08e95da4-f458-4fad-9830-d01431b74894"),
                            Description = "The Facade pattern provides a unified interface to a set of interfaces in a subsystem.",
                            Name = "Facade",
                            Schema = "",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("e8c5fa15-b711-430e-b67a-4f2729e428f7"),
                            Description = "The Flyweight pattern minimizes memory usage and improves performance by sharing as much as possible with similar objects.",
                            Name = "Flyweight",
                            Schema = "",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("0385abc4-0d54-4730-918e-260b440aad87"),
                            Description = "The Proxy pattern provides a surrogate or placeholder for another object to control access to it.",
                            Name = "Proxy",
                            Schema = "",
                            Type = "Structural"
                        },
                        new
                        {
                            Id = new Guid("fdcba9dd-3066-46c5-92d6-6c38e5efcdac"),
                            Description = "The Factory Method pattern defines an interface for creating objects, but allows subclasses to alter the type of objects that will be created.",
                            Name = "Factory Method",
                            Schema = "",
                            Type = "Creational"
                        },
                        new
                        {
                            Id = new Guid("23ae3388-9888-4548-a772-b75645e15f3a"),
                            Description = "The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.",
                            Name = "Abstract Factory",
                            Schema = "",
                            Type = "Creational"
                        },
                        new
                        {
                            Id = new Guid("23ad76bb-4e00-4a68-bbe4-ef9ba21c7daf"),
                            Description = "The Builder pattern separates the construction of a complex object from its representation, allowing the same construction process to create different representations.",
                            Name = "Builder",
                            Schema = "",
                            Type = "Creational"
                        },
                        new
                        {
                            Id = new Guid("5316eabb-fc2a-428d-9469-d8eeff9eb72a"),
                            Description = "The Prototype pattern creates new objects by copying an existing object, known as the prototype.",
                            Name = "Prototype",
                            Schema = "",
                            Type = "Creational"
                        },
                        new
                        {
                            Id = new Guid("4e1ebb2d-b20c-4791-998a-4f9f1b26496d"),
                            Description = "The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance.",
                            Name = "Singleton",
                            Schema = "",
                            Type = "Creational"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
