using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WzorceProjektowe.API.Migrations
{
    public partial class morepatterns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("3a2e0c1b-cea9-403b-9b2e-1ca234b566bc"));

            migrationBuilder.InsertData(
                table: "Patterns",
                columns: new[] { "Id", "Description", "Name", "Schema", "Type" },
                values: new object[,]
                {
                    { new Guid("0385abc4-0d54-4730-918e-260b440aad87"), "The Proxy pattern provides a surrogate or placeholder for another object to control access to it.", "Proxy", "", "Structural" },
                    { new Guid("08e95da4-f458-4fad-9830-d01431b74894"), "The Facade pattern provides a unified interface to a set of interfaces in a subsystem.", "Facade", "", "Structural" },
                    { new Guid("16f77f8f-9ea9-448b-97bf-ddbd02265865"), "The Decorator pattern attaches additional responsibilities to objects dynamically.", "Decorator", "", "Structural" },
                    { new Guid("23ad76bb-4e00-4a68-bbe4-ef9ba21c7daf"), "The Builder pattern separates the construction of a complex object from its representation, allowing the same construction process to create different representations.", "Builder", "", "Creational" },
                    { new Guid("23ae3388-9888-4548-a772-b75645e15f3a"), "The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.", "Abstract Factory", "", "Creational" },
                    { new Guid("3428fedf-1f30-45e9-84cc-a01189458cd6"), "The Adapter pattern allows objects with incompatible interfaces to collaborate.", "Adapter", "interface ITarget {\r\n    void Request();\r\n}\r\n\r\nclass Adaptee {\r\n    public void SpecificRequest() {\r\n        Console.WriteLine(\"Specific request\");\r\n    }\r\n}\r\n\r\nclass Adapter : ITarget {\r\n    private Adaptee _adaptee;\r\n\r\n    public Adapter(Adaptee adaptee) {\r\n        _adaptee = adaptee;\r\n    }\r\n\r\n    public void Request() {\r\n        _adaptee.SpecificRequest();\r\n    }\r\n}\r\n\r\nclass Client {\r\n    static void Main(string[] args) {\r\n        Adaptee adaptee = new Adaptee();\r\n        ITarget adapter = new Adapter(adaptee);\r\n        adapter.Request();\r\n    }\r\n}", "Structural" },
                    { new Guid("4e1ebb2d-b20c-4791-998a-4f9f1b26496d"), "The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance.", "Singleton", "", "Creational" },
                    { new Guid("5316eabb-fc2a-428d-9469-d8eeff9eb72a"), "The Prototype pattern creates new objects by copying an existing object, known as the prototype.", "Prototype", "", "Creational" },
                    { new Guid("dcc630e7-38a6-4b83-b144-67e39492df11"), "The Composite pattern composes objects into tree structures to represent part-whole hierarchies.", "Composite", "", "Structural" },
                    { new Guid("e8c5fa15-b711-430e-b67a-4f2729e428f7"), "The Flyweight pattern minimizes memory usage and improves performance by sharing as much as possible with similar objects.", "Flyweight", "", "Structural" },
                    { new Guid("fa244eee-1914-4fc0-8e47-da2f1e8c1480"), "The Bridge pattern decouples an abstraction from its implementation so that the two can vary independently.", "Bridge", "", "Structural" },
                    { new Guid("fdcba9dd-3066-46c5-92d6-6c38e5efcdac"), "The Factory Method pattern defines an interface for creating objects, but allows subclasses to alter the type of objects that will be created.", "Factory Method", "", "Creational" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("0385abc4-0d54-4730-918e-260b440aad87"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("08e95da4-f458-4fad-9830-d01431b74894"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("16f77f8f-9ea9-448b-97bf-ddbd02265865"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("23ad76bb-4e00-4a68-bbe4-ef9ba21c7daf"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("23ae3388-9888-4548-a772-b75645e15f3a"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("3428fedf-1f30-45e9-84cc-a01189458cd6"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("4e1ebb2d-b20c-4791-998a-4f9f1b26496d"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("5316eabb-fc2a-428d-9469-d8eeff9eb72a"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("dcc630e7-38a6-4b83-b144-67e39492df11"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("e8c5fa15-b711-430e-b67a-4f2729e428f7"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("fa244eee-1914-4fc0-8e47-da2f1e8c1480"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("fdcba9dd-3066-46c5-92d6-6c38e5efcdac"));

            migrationBuilder.InsertData(
                table: "Patterns",
                columns: new[] { "Id", "Description", "Name", "Schema", "Type" },
                values: new object[] { new Guid("3a2e0c1b-cea9-403b-9b2e-1ca234b566bc"), "Adapter pozwala na współdziałanie ze sobą obiektów o niekompatybilnych interfejsach.", "Adapter", "interface ITarget {\r\n    void Request();\r\n}\r\n\r\nclass Adaptee {\r\n    public void SpecificRequest() {\r\n        Console.WriteLine(\"Specific request\");\r\n    }\r\n}\r\n\r\nclass Adapter : ITarget {\r\n    private Adaptee _adaptee;\r\n\r\n    public Adapter(Adaptee adaptee) {\r\n        _adaptee = adaptee;\r\n    }\r\n\r\n    public void Request() {\r\n        _adaptee.SpecificRequest();\r\n    }\r\n}\r\n\r\nclass Client {\r\n    static void Main(string[] args) {\r\n        Adaptee adaptee = new Adaptee();\r\n        ITarget adapter = new Adapter(adaptee);\r\n        adapter.Request();\r\n    }\r\n}", "Strukturalny" });
        }
    }
}
