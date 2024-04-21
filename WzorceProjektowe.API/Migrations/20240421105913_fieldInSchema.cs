using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WzorceProjektowe.API.Migrations
{
    public partial class fieldInSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("21ada38f-cd9b-4231-b564-d6c5f3412260"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("249dbdc9-acc3-449d-8968-634c089e7ba1"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("493b34a1-12e1-4967-aa6c-a54cd9d147f9"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("6469a535-507a-44fd-b9d7-dcf831847a21"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("6706a7fc-0d05-4484-a9eb-54d4a47723a1"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("6c2afb6f-bcc5-4d02-92ef-b7df12fd0fac"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("752a9281-8840-4d7b-8fd6-5da1b3eee655"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("bfdf0acd-cb53-4f6d-8502-5369af29c23f"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("d5842261-670b-4896-8697-4e4c263cd86f"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("da697d34-84c0-476a-a083-6e8b00209367"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("f83fc61f-16b4-4160-9116-12d7c8c0c734"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("ffb8c2cb-3b24-4bbe-b4bd-35061073ee98"));

            migrationBuilder.InsertData(
                table: "Patterns",
                columns: new[] { "Id", "Description", "DynamicsCode", "Name", "Schema", "ToInterpret", "Type" },
                values: new object[,]
                {
                    { new Guid("039cf74b-3ed6-470b-97a4-c5d0b5ff51f9"), "The Flyweight pattern minimizes memory usage and improves performance by sharing as much as possible with similar objects.", "", "Flyweight", "", "", "Structural" },
                    { new Guid("0c583dc0-a077-465b-a728-dcb395306340"), "The Proxy pattern provides a surrogate or placeholder for another object to control access to it.", "", "Proxy", "", "", "Structural" },
                    { new Guid("27eb0b5b-ed8e-4756-878d-630ba53ec970"), "The Adapter pattern allows objects with incompatible interfaces to collaborate.", "", "Adapter", "interface ITarget {\r\n    void Request();\r\n}\r\n\r\nclass Adaptee {\r\n    public void SpecificRequest() {\r\n        Console.WriteLine(\"Specific request\");\r\n    }\r\n}\r\n\r\nclass Adapter : ITarget {\r\n    private Adaptee _adaptee;\r\n\r\n    public Adapter(Adaptee adaptee) {\r\n        _adaptee = adaptee;\r\n    }\r\n\r\n    public void Request() {\r\n        _adaptee.SpecificRequest();\r\n    }\r\n}\r\n\r\nclass Client {\r\n    static void Main(string[] args) {\r\n        Adaptee adaptee = new Adaptee();\r\n        ITarget adapter = new Adapter(adaptee);\r\n        adapter.Request();\r\n    }\r\n}", "", "Structural" },
                    { new Guid("2cb4e620-aabc-4675-bd36-56c9e2f32b46"), "The Bridge pattern decouples an abstraction from its implementation so that the two can vary independently.", "", "Bridge", "", "", "Structural" },
                    { new Guid("5808f582-29ec-49a3-b87c-461323f8cef5"), "The Prototype pattern creates new objects by copying an existing object, known as the prototype.", "", "Prototype", "", "", "Creational" },
                    { new Guid("622b0bc2-1bb7-466e-9eee-a2931bc4ebda"), "The Facade pattern provides a unified interface to a set of interfaces in a subsystem.", "", "Facade", "", "", "Structural" },
                    { new Guid("73fbda00-c67e-4660-8641-eabd35ba44db"), "The Composite pattern composes objects into tree structures to represent part-whole hierarchies.", "", "Composite", "", "", "Structural" },
                    { new Guid("78a6d753-bb49-4769-8fce-448de83578cc"), "The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance.", "", "Singleton", "", "", "Creational" },
                    { new Guid("a8605a70-b59f-4658-ab70-d275a39c5c79"), "The Builder pattern separates the construction of a complex object from its representation, allowing the same construction process to create different representations.", "", "Builder", "", "", "Creational" },
                    { new Guid("cfefc139-0065-4d98-b73d-9e4cd5d3c2d4"), "The Decorator pattern attaches additional responsibilities to objects dynamically.", "\r\n#splitfile#\r\nusing System;\r\npublic class #C# : #AC1#\r\n{\r\n    #F;#C#\r\n    #M;#C#\r\n    public #C#(#I1# component) : base(component)\r\n    {\r\n    }\r\n\r\n    public override void Operation()\r\n    {\r\n        base.Operation();\r\n        AddedBehavior();\r\n    }\r\n\r\n    private void AddedBehavior()\r\n    {\r\n        Console.WriteLine(\"Added behavior by ConcreteDecorator\");\r\n    }\r\n}\r\n", "Decorator", "#splitfile#\r\npublic interface #I1#\r\n{\r\n    #F;#I1#\r\n    #M;#I1#\r\n    void Operation();\r\n}\r\n#splitfile#\r\npublic class #CC1# : #I1#\r\n{\r\n    #F;#CC1#\r\n    #M;#CC1#\r\n    public void Operation()\r\n    {\r\n        Console.WriteLine(\"ConcreteComponent operation\");\r\n    }\r\n}\r\n#splitfile#\r\npublic abstract class #AC1# : #I1#\r\n{\r\n    protected #I1# component;\r\n    \r\n    #F;#AC1#\r\n    #M;#AC1#\r\n\r\n    public #AC1#(#I1# component)\r\n    {\r\n        this.component = component;\r\n    }\r\n\r\n    public virtual void Operation()\r\n    {\r\n        component.Operation();\r\n    }\r\n}\r\n\r\n#DYNAMICS#\r\n#splitfile#\r\npublic class Program\r\n{\r\n    static void Main(string[] args)\r\n    {\r\n        // Tworzymy konkretne komponenty i dekorujemy je\r\n        #I1# component = new #CC1#();\r\n        #I1# decoratedComponent = new #C2#(component);\r\n\r\n        // Wywołujemy operację na dekoratorze, która przejdzie przez wszystkie dekoratory\r\n        decoratedComponent.Operation();\r\n\r\n        /*\r\n            Wynik działania programu:\r\n            ConcreteComponent operation\r\n            Added behavior by ConcreteDecorator\r\n        */\r\n    }\r\n}", "#I1#FajnyInterfejs# #CC1#Klasa# #AC1#AbstrakcyjnaKlasa# #C2#KlasaDekoratora#", "Structural" },
                    { new Guid("d707e54c-de56-4ad6-a453-ec34a63da594"), "The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.", "", "Abstract Factory", "", "", "Creational" },
                    { new Guid("e2d0fdb9-110f-46b7-a623-c91b81c28a56"), "The Factory Method pattern defines an interface for creating objects, but allows subclasses to alter the type of objects that will be created.", "", "Factory Method", "", "", "Creational" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("039cf74b-3ed6-470b-97a4-c5d0b5ff51f9"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("0c583dc0-a077-465b-a728-dcb395306340"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("27eb0b5b-ed8e-4756-878d-630ba53ec970"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("2cb4e620-aabc-4675-bd36-56c9e2f32b46"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("5808f582-29ec-49a3-b87c-461323f8cef5"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("622b0bc2-1bb7-466e-9eee-a2931bc4ebda"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("73fbda00-c67e-4660-8641-eabd35ba44db"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("78a6d753-bb49-4769-8fce-448de83578cc"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("a8605a70-b59f-4658-ab70-d275a39c5c79"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("cfefc139-0065-4d98-b73d-9e4cd5d3c2d4"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("d707e54c-de56-4ad6-a453-ec34a63da594"));

            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("e2d0fdb9-110f-46b7-a623-c91b81c28a56"));

            migrationBuilder.InsertData(
                table: "Patterns",
                columns: new[] { "Id", "Description", "DynamicsCode", "Name", "Schema", "ToInterpret", "Type" },
                values: new object[,]
                {
                    { new Guid("21ada38f-cd9b-4231-b564-d6c5f3412260"), "The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.", "", "Abstract Factory", "", "", "Creational" },
                    { new Guid("249dbdc9-acc3-449d-8968-634c089e7ba1"), "The Factory Method pattern defines an interface for creating objects, but allows subclasses to alter the type of objects that will be created.", "", "Factory Method", "", "", "Creational" },
                    { new Guid("493b34a1-12e1-4967-aa6c-a54cd9d147f9"), "The Proxy pattern provides a surrogate or placeholder for another object to control access to it.", "", "Proxy", "", "", "Structural" },
                    { new Guid("6469a535-507a-44fd-b9d7-dcf831847a21"), "The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance.", "", "Singleton", "", "", "Creational" },
                    { new Guid("6706a7fc-0d05-4484-a9eb-54d4a47723a1"), "The Composite pattern composes objects into tree structures to represent part-whole hierarchies.", "", "Composite", "", "", "Structural" },
                    { new Guid("6c2afb6f-bcc5-4d02-92ef-b7df12fd0fac"), "The Facade pattern provides a unified interface to a set of interfaces in a subsystem.", "", "Facade", "", "", "Structural" },
                    { new Guid("752a9281-8840-4d7b-8fd6-5da1b3eee655"), "The Flyweight pattern minimizes memory usage and improves performance by sharing as much as possible with similar objects.", "", "Flyweight", "", "", "Structural" },
                    { new Guid("bfdf0acd-cb53-4f6d-8502-5369af29c23f"), "The Decorator pattern attaches additional responsibilities to objects dynamically.", "\r\n#splitfile#\r\nusing System;\r\npublic class #C# : #AC1#\r\n{{\r\n    public #C#(#I1# component) : base(component)\r\n    {{\r\n    }}\r\n\r\n    public override void Operation()\r\n    {{\r\n        base.Operation();\r\n        AddedBehavior();\r\n    }}\r\n\r\n    private void AddedBehavior()\r\n    {{\r\n        Console.WriteLine(\"Added behavior by ConcreteDecorator\");\r\n    }}\r\n}}\r\n", "Decorator", "#splitfile#\r\npublic interface #I1#\r\n{\r\n    void Operation();\r\n}\r\n#splitfile#\r\npublic class #C1# : #I1#\r\n{\r\n    public void Operation()\r\n    {\r\n        Console.WriteLine(\"ConcreteComponent operation\");\r\n    }\r\n}\r\n#splitfile#\r\npublic abstract class #AC1# : #I1#\r\n{\r\n    protected #I1# component;\r\n\r\n    public #AC1#(#I1# component)\r\n    {\r\n        this.component = component;\r\n    }\r\n\r\n    public virtual void Operation()\r\n    {\r\n        component.Operation();\r\n    }\r\n}\r\n#splitfile#\r\nusing System;\r\npublic class #C2# : #AC1#\r\n{\r\n    public #C2#(#I1# component) : base(component)\r\n    {\r\n    }\r\n\r\n    public override void Operation()\r\n    {\r\n        base.Operation();\r\n        AddedBehavior();\r\n    }\r\n\r\n    private void AddedBehavior()\r\n    {\r\n        Console.WriteLine(\"Added behavior by ConcreteDecorator\");\r\n    }\r\n}\r\n\r\n#DYNAMICS#\r\n#splitfile#\r\npublic class Program\r\n{\r\n    static void Main(string[] args)\r\n    {\r\n        // Tworzymy konkretne komponenty i dekorujemy je\r\n        #I1# component = new #C1#();\r\n        #I1# decoratedComponent = new #C2#(component);\r\n\r\n        // Wywołujemy operację na dekoratorze, która przejdzie przez wszystkie dekoratory\r\n        decoratedComponent.Operation();\r\n\r\n        /*\r\n            Wynik działania programu:\r\n            ConcreteComponent operation\r\n            Added behavior by ConcreteDecorator\r\n        */\r\n    }\r\n}", "#I1#FajnyInterfejs# #C1#Klasa# #AC1#AbstrakcyjnaKlasa# #C2#KlasaDekoratora#", "Structural" },
                    { new Guid("d5842261-670b-4896-8697-4e4c263cd86f"), "The Bridge pattern decouples an abstraction from its implementation so that the two can vary independently.", "", "Bridge", "", "", "Structural" },
                    { new Guid("da697d34-84c0-476a-a083-6e8b00209367"), "The Prototype pattern creates new objects by copying an existing object, known as the prototype.", "", "Prototype", "", "", "Creational" },
                    { new Guid("f83fc61f-16b4-4160-9116-12d7c8c0c734"), "The Builder pattern separates the construction of a complex object from its representation, allowing the same construction process to create different representations.", "", "Builder", "", "", "Creational" },
                    { new Guid("ffb8c2cb-3b24-4bbe-b4bd-35061073ee98"), "The Adapter pattern allows objects with incompatible interfaces to collaborate.", "", "Adapter", "interface ITarget {\r\n    void Request();\r\n}\r\n\r\nclass Adaptee {\r\n    public void SpecificRequest() {\r\n        Console.WriteLine(\"Specific request\");\r\n    }\r\n}\r\n\r\nclass Adapter : ITarget {\r\n    private Adaptee _adaptee;\r\n\r\n    public Adapter(Adaptee adaptee) {\r\n        _adaptee = adaptee;\r\n    }\r\n\r\n    public void Request() {\r\n        _adaptee.SpecificRequest();\r\n    }\r\n}\r\n\r\nclass Client {\r\n    static void Main(string[] args) {\r\n        Adaptee adaptee = new Adaptee();\r\n        ITarget adapter = new Adapter(adaptee);\r\n        adapter.Request();\r\n    }\r\n}", "", "Structural" }
                });
        }
    }
}
