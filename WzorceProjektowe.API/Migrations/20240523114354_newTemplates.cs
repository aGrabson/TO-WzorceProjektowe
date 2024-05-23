using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WzorceProjektowe.API.Migrations
{
    public partial class newTemplates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("6469a535-507a-44fd-b9d7-dcf831847a21"),
                column: "DynamicsCode",
                value: "\r\n#splitfile#\r\npublic class #C# : #AC1#\r\n{\r\n    #F;#C#\r\n    #M;#C#\r\n    public #C#(#I1# component) : base(component)\r\n    {\r\n    }\r\n\r\n    public override void Operation()\r\n    {\r\n        base.Operation();\r\n        AddedBehavior();\r\n    }\r\n\r\n    private void AddedBehavior()\r\n    {\r\n        Console.WriteLine(\"Added behavior by ConcreteDecorator\");\r\n    }\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("da697d34-84c0-476a-a083-6e8b00209367"),
                columns: new[] { "DynamicsCode", "Schema", "ToInterpret" },
                values: new object[] { "#splitfile#\r\npublic class #C#\r\n    {\r\n        private #I1# _builder;\r\n		\r\n        #F;#C#\r\n		#M;#C#\r\n		\r\n        public #I1# Builder\r\n        {\r\n            set { _builder = value; } \r\n        }\r\n        \r\n        public void BuildMinimalViableProduct()\r\n        {\r\n            this._builder.BuildPartA();\r\n        }\r\n        \r\n        public void BuildFullFeaturedProduct()\r\n        {\r\n            this._builder.BuildPartA();\r\n            this._builder.BuildPartB();\r\n        }\r\n    }", "#splitfile#public interface #I1#\r\n    {\r\n	#F;#I1#\r\n	#M;#I1#\r\n        void BuildPartA();\r\n        \r\n        void BuildPartB();\r\n    }\r\n#splitfile#	\r\npublic class #CC1# : #I1#\r\n    {\r\n        private #CC2# _product = new #CC2#();\r\n		\r\n        #F;#CC1#\r\n		#M;#CC1#\r\n		\r\n        public #CC1#()\r\n        {\r\n            this.Reset();\r\n        }\r\n        \r\n        public void Reset()\r\n        {\r\n            this._product = new #CC2#();\r\n        }\r\n        \r\n        public void BuildPartA()\r\n        {\r\n            this._product.Add(\"PartA1\");\r\n        }\r\n        \r\n        public void BuildPartB()\r\n        {\r\n            this._product.Add(\"PartB1\");\r\n        }\r\n        \r\n        public #CC2# GetProduct()\r\n        {\r\n            #CC2# result = this._product;\r\n\r\n            this.Reset();\r\n\r\n            return result;\r\n        }\r\n    }\r\n#splitfile#\r\npublic class #CC2#\r\n    {\r\n		#F;#CC2#\r\n		#M;#CC2#\r\n        private List<string> _parts = new List<string>();\r\n        \r\n        public void Add(string part)\r\n        {\r\n            this._parts.Add(part);\r\n        }\r\n        \r\n        public string ListParts()\r\n        {\r\n            string str = string.Empty;\r\n\r\n            for (int i = 0; i < this._parts.Count; i++)\r\n            {\r\n                str += this._parts[i] + \", \";\r\n            }\r\n\r\n            str = str.Remove(str.Length - 2);\r\n\r\n            return \"Product parts: \" + str + \"\\n\";\r\n        }\r\n    }\r\n#DYNAMICS#\r\n#splitfile#\r\nclass Program\r\n    {\r\n        static void Main(string[] args)\r\n        {\r\n            var director = new #C#();\r\n            var builder = new #CC1#();\r\n            director.Builder = builder;\r\n            \r\n            Console.WriteLine(\"Standard basic product:\");\r\n            director.BuildMinimalViableProduct();\r\n            Console.WriteLine(builder.GetProduct().ListParts());\r\n\r\n            Console.WriteLine(\"Standard full featured product:\");\r\n            director.BuildFullFeaturedProduct();\r\n            Console.WriteLine(builder.GetProduct().ListParts());\r\n\r\n            Console.WriteLine(\"Custom product:\");\r\n            builder.BuildPartA();\r\n            Console.Write(builder.GetProduct().ListParts());\r\n        }\r\n    }", "#I1#Interfejs# #CC1#FajnaKlasa# #CC2#Produkt# #C1#KonkretnyBuilder#" });

            migrationBuilder.InsertData(
                table: "Patterns",
                columns: new[] { "Id", "Description", "DynamicMethodAC", "DynamicMethodC", "DynamicMethodI", "DynamicsCode", "Name", "Schema", "ToInterpret", "Type" },
                values: new object[] { new Guid("ffb8c2cb-3b24-4bbe-b4bd-34061073ee98"), "Observer is a behavioral design pattern that lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing.", "", "", "", "#splitfile#\r\nclass #C# : #I1#\r\n{\r\n	#F;#C#\r\n	#M;#C#\r\n    private int _state;\r\n\r\n    public void UpdateState()\r\n    {\r\n        _state++;\r\n        NotifyObservers();\r\n    }\r\n\r\n    public int GetState()\r\n    {\r\n        return _state;\r\n    }\r\n}", "Observer", "#splitfile#\r\npublic interface #I1#\r\n{\r\n	#F;#I1#\r\n	#M;#I1#\r\n    void Update();\r\n}\r\n#splitfile#\r\npublic class #CC1# : #I1#\r\n{\r\n	#F;#CC1#\r\n	#M;#CC1#\r\n    private #CC2# _observable;\r\n    private int _state;\r\n\r\n    public #CC1#(#CC2# observable)\r\n    {\r\n        _observable = observable;\r\n    }\r\n\r\n    public void Update()\r\n    {\r\n        _state = _observable.GetState();\r\n        Console.WriteLine(\"new state = \" + _state);\r\n    }\r\n}\r\n#splitfile#\r\npublic abstract class #AC1#\r\n{\r\n	#F;#AC1#\r\n	#M;#AC1#\r\n    private List<#I1#> _observers = new List<#I1#>();\r\n\r\n    public void AddObserver(#I1# observer)\r\n    {\r\n        _observers.Add(observer);\r\n    }\r\n\r\n    public void RemoveObserver(#I1# observer)\r\n    {\r\n        _observers.Remove(observer);\r\n    }\r\n\r\n    public void NotifyObservers(object obj)\r\n    {\r\n        foreach (#I1# observer in _observers)\r\n        {\r\n            observer.Update();\r\n        }\r\n    }\r\n}\r\n#splitfile#\r\npublic class #CC2# : #I1#\r\n{\r\n	#F;#CC2#\r\n	#M;#CC2#\r\n    private int _state;\r\n\r\n    public void UpdateState()\r\n    {\r\n        _state++;\r\n        NotifyObservers();\r\n    }\r\n\r\n    public int GetState()\r\n    {\r\n        return _state;\r\n    }\r\n}\r\n#DYNAMICS#\r\n#splitfile#\r\npublic class Program\r\n{\r\n    static void Main(string[] args)\r\n    {\r\n        #CC2# observable = new #CC2#();\r\n        #I1# observer = new ObserverImpl(observable);\r\n        observable.AddObserver(observer);\r\n\r\n        // Symulacja aktualizacji stanu\r\n        observable.UpdateState();\r\n        observable.UpdateState();\r\n    }\r\n}", "#I1#Interfejs# #CC1#Obserwator# #AC1#Abstrakcyjnaklasa# #CC2#ObserwatorImpl#", "Behavioral" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("ffb8c2cb-3b24-4bbe-b4bd-34061073ee98"));

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("6469a535-507a-44fd-b9d7-dcf831847a21"),
                column: "DynamicsCode",
                value: "\r\n#splitfile#\r\nusing System;\r\npublic class #C# : #AC1#\r\n{\r\n    #F;#C#\r\n    #M;#C#\r\n    public #C#(#I1# component) : base(component)\r\n    {\r\n    }\r\n\r\n    public override void Operation()\r\n    {\r\n        base.Operation();\r\n        AddedBehavior();\r\n    }\r\n\r\n    private void AddedBehavior()\r\n    {\r\n        Console.WriteLine(\"Added behavior by ConcreteDecorator\");\r\n    }\r\n}\r\n");

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("da697d34-84c0-476a-a083-6e8b00209367"),
                columns: new[] { "DynamicsCode", "Schema", "ToInterpret" },
                values: new object[] { "", "", "" });
        }
    }
}
