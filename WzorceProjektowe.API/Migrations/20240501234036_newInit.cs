using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WzorceProjektowe.API.Migrations
{
    public partial class newInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patterns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Schema = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToInterpret = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DynamicsCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DynamicMethodI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DynamicMethodC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DynamicMethodAC = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patterns", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Patterns",
                columns: new[] { "Id", "Description", "DynamicMethodAC", "DynamicMethodC", "DynamicMethodI", "DynamicsCode", "Name", "Schema", "ToInterpret", "Type" },
                values: new object[,]
                {
                    { new Guid("21ada38f-cd9b-4231-b564-d6c5f3412260"), "The Adapter pattern allows objects with incompatible interfaces to collaborate.", "", "", "", "", "Adapter", "interface ITarget {\r\n    void Request();\r\n}\r\n\r\nclass Adaptee {\r\n    public void SpecificRequest() {\r\n        Console.WriteLine(\"Specific request\");\r\n    }\r\n}\r\n\r\nclass Adapter : ITarget {\r\n    private Adaptee _adaptee;\r\n\r\n    public Adapter(Adaptee adaptee) {\r\n        _adaptee = adaptee;\r\n    }\r\n\r\n    public void Request() {\r\n        _adaptee.SpecificRequest();\r\n    }\r\n}\r\n\r\nclass Client {\r\n    static void Main(string[] args) {\r\n        Adaptee adaptee = new Adaptee();\r\n        ITarget adapter = new Adapter(adaptee);\r\n        adapter.Request();\r\n    }\r\n}", "", "Structural" },
                    { new Guid("249dbdc9-acc3-449d-8968-634c089e7ba1"), "The Bridge pattern decouples an abstraction from its implementation so that the two can vary independently.", "", "", "", "", "Bridge", "", "", "Structural" },
                    { new Guid("493b34a1-12e1-4967-aa6c-a54cd9d147f9"), "The Composite pattern composes objects into tree structures to represent part-whole hierarchies.", "", "", "", "", "Composite", "", "", "Structural" },
                    { new Guid("6469a535-507a-44fd-b9d7-dcf831847a21"), "The Decorator pattern attaches additional responsibilities to objects dynamically.", "\r\n    public #TYPE# #NAME#(#PARAMS#){\r\n        throw new NotImplementedException();\r\n    }", "\r\n    public virtual #TYPE# #NAME#(#PARAMS#){\r\n        component.#NAME#(#NOTYPEPARAMS#);\r\n    }", "#TYPE# #NAME# (#PARAMS#);\n    ", "\r\n#splitfile#\r\nusing System;\r\npublic class #C# : #AC1#\r\n{\r\n    #F;#C#\r\n    #M;#C#\r\n    public #C#(#I1# component) : base(component)\r\n    {\r\n    }\r\n\r\n    public override void Operation()\r\n    {\r\n        base.Operation();\r\n        AddedBehavior();\r\n    }\r\n\r\n    private void AddedBehavior()\r\n    {\r\n        Console.WriteLine(\"Added behavior by ConcreteDecorator\");\r\n    }\r\n}\r\n", "Decorator", "#splitfile#\r\npublic interface #I1#\r\n{\r\n    #F;#I1#\r\n    #M;#I1#\r\n    void Operation();\r\n}\r\n#splitfile#\r\npublic class #CC1# : #I1#\r\n{\r\n    #F;#CC1#\r\n    #M;#CC1#\r\n    public void Operation()\r\n    {\r\n        Console.WriteLine(\"ConcreteComponent operation\");\r\n    }\r\n}\r\n#splitfile#\r\npublic abstract class #AC1# : #I1#\r\n{\r\n    protected #I1# component;\r\n    \r\n    #F;#AC1#\r\n    #M;#AC1#\r\n\r\n    public #AC1#(#I1# component)\r\n    {\r\n        this.component = component;\r\n    }\r\n\r\n    public virtual void Operation()\r\n    {\r\n        component.Operation();\r\n    }\r\n}\r\n\r\n#DYNAMICS#\r\n#splitfile#\r\npublic class Program\r\n{\r\n    static void Main(string[] args)\r\n    {\r\n        #I1# component = new #CC1#();\r\n        #I1# decoratedComponent = new #C2#(component);\r\n\r\n        decoratedComponent.Operation();\r\n    }\r\n}", "#I1#FajnyInterfejs# #CC1#Klasa# #AC1#AbstrakcyjnaKlasa# #C2#KlasaDekoratora# ", "Structural" },
                    { new Guid("6706a7fc-0d05-4484-a9eb-54d4a47723a1"), "The Facade pattern provides a unified interface to a set of interfaces in a subsystem.", "", "", "", "", "Facade", "", "", "Structural" },
                    { new Guid("6c2afb6f-bcc5-4d02-92ef-b7df12fd0fac"), "The Flyweight pattern minimizes memory usage and improves performance by sharing as much as possible with similar objects.", "", "", "", "", "Flyweight", "", "", "Structural" },
                    { new Guid("752a9281-8840-4d7b-8fd6-5da1b3eee655"), "The Proxy pattern provides a surrogate or placeholder for another object to control access to it.", "", "", "", "", "Proxy", "", "", "Structural" },
                    { new Guid("bfdf0acd-cb53-4f6d-8502-5369af29c23f"), "The Factory Method pattern defines an interface for creating objects, but allows subclasses to alter the type of objects that will be created.", "", "", "", "", "Factory Method", "", "", "Creational" },
                    { new Guid("d5842261-670b-4896-8697-4e4c263cd86f"), "The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.", "", "", "", "", "Abstract Factory", "", "", "Creational" },
                    { new Guid("da697d34-84c0-476a-a083-6e8b00209367"), "The Builder pattern separates the construction of a complex object from its representation, allowing the same construction process to create different representations.", "", "", "", "", "Builder", "", "", "Creational" },
                    { new Guid("f83fc61f-16b4-4160-9116-12d7c8c0c734"), "The Prototype pattern creates new objects by copying an existing object, known as the prototype.", "", "", "", "", "Prototype", "", "", "Creational" },
                    { new Guid("ffb8c2cb-3b24-4bbe-b4bd-35061073ee98"), "The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance.", "", "", "", "", "Singleton", "", "", "Creational" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patterns");
        }
    }
}
