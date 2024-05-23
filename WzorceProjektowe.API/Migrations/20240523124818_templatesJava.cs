using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WzorceProjektowe.API.Migrations
{
    public partial class templatesJava : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DynamicMethodACJava",
                table: "Patterns",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DynamicMethodCJava",
                table: "Patterns",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DynamicMethodIJava",
                table: "Patterns",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DynamicsCodeJava",
                table: "Patterns",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SchemaJava",
                table: "Patterns",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("21ada38f-cd9b-4231-b564-d6c5f3412260"),
                columns: new[] { "DynamicMethodACJava", "DynamicMethodCJava", "DynamicMethodIJava", "DynamicsCodeJava", "SchemaJava" },
                values: new object[] { "", "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("249dbdc9-acc3-449d-8968-634c089e7ba1"),
                columns: new[] { "DynamicMethodACJava", "DynamicMethodCJava", "DynamicMethodIJava", "DynamicsCodeJava", "SchemaJava" },
                values: new object[] { "", "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("493b34a1-12e1-4967-aa6c-a54cd9d147f9"),
                columns: new[] { "DynamicMethodACJava", "DynamicMethodCJava", "DynamicMethodIJava", "DynamicsCodeJava", "SchemaJava" },
                values: new object[] { "", "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("6469a535-507a-44fd-b9d7-dcf831847a21"),
                columns: new[] { "DynamicMethodAC", "DynamicMethodACJava", "DynamicMethodC", "DynamicMethodCJava", "DynamicMethodIJava", "DynamicsCode", "DynamicsCodeJava", "Schema", "SchemaJava" },
                values: new object[] { "\r\n    public virtual #TYPE# #NAME#(#PARAMS#){\r\n        component.#NAME#(#NOTYPEPARAMS#);\r\n    }", "\r\n    @Override\r\n    public #TYPE# #NAME#(#PARAMS#){\r\n        component.#NAME#(#NOTYPEPARAMS#);\r\n    }", "\r\n    public #TYPE# #NAME#(#PARAMS#){\r\n        throw new NotImplementedException();\r\n    }", "\r\n    @Override\r\n    public #TYPE# #NAME#(#PARAMS#){\r\n        throw new UnsupportedOperationException(\"Not implemented yet\");\r\n    }", "#TYPE# #NAME# (#PARAMS#);\n    ", "#splitfile#\r\npublic class #C# : #AC1#\r\n{\r\n    #F;#C#\r\n\r\n    #M;#C#\r\n    public #C#(#I1# component) : base(component)\r\n    {\r\n    }\r\n\r\n    public override void Operation()\r\n    {\r\n        base.Operation();\r\n        AddedBehavior();\r\n    }\r\n\r\n    private void AddedBehavior()\r\n    {\r\n        Console.WriteLine(\"Added behavior by ConcreteDecorator\");\r\n    }\r\n}\r\n", "#splitfile#\r\npublic class #C# extends #AC1# {\r\n    #F;#C#\r\n	\r\n    #M;#C#\r\n    public #C#(#I1# component) {\r\n        super(component);\r\n    }\r\n\r\n    @Override\r\n    public void Operation() {\r\n        super.Operation();\r\n        AddedBehavior();\r\n    }\r\n\r\n    private void AddedBehavior() {\r\n        System.out.println(\"Added behavior by ConcreteDecorator\");\r\n    }\r\n}", "#splitfile#\r\npublic interface #I1#\r\n{\r\n    #F;#I1#\r\n\r\n    #M;#I1#\r\n    void Operation();\r\n}\r\n#splitfile#\r\npublic class #CC1# : #I1#\r\n{\r\n    #F;#CC1#\r\n\r\n    #M;#CC1#\r\n    public void Operation()\r\n    {\r\n        Console.WriteLine(\"ConcreteComponent operation\");\r\n    }\r\n}\r\n#splitfile#\r\npublic abstract class #AC1# : #I1#\r\n{\r\n    protected #I1# component;\r\n    #F;#AC1#\r\n\r\n    #M;#AC1#\r\n    public #AC1#(#I1# component)\r\n    {\r\n        this.component = component;\r\n    }\r\n\r\n    public virtual void Operation()\r\n    {\r\n        component.Operation();\r\n    }\r\n}\r\n#DYNAMICS#\r\n#splitfile#\r\npublic class Program\r\n{\r\n    static void Main(string[] args)\r\n    {\r\n        #I1# component = new #CC1#();\r\n        #I1# decoratedComponent = new #C2#(component);\r\n\r\n        decoratedComponent.Operation();\r\n    }\r\n}", "#splitfile#\r\npublic interface #I1# {\r\n    #F;#I1#\r\n	\r\n    #M;#I1#\r\n    void Operation();\r\n}\r\n#splitfile#\r\npublic class #CC1# implements #I1# {\r\n    #F;#CC1#\r\n	\r\n    #M;#CC1#\r\n    @Override\r\n    public void Operation() {\r\n        System.out.println(\"ConcreteComponent operation\");\r\n    }\r\n}\r\n#splitfile#\r\npublic abstract class #AC1# implements #I1# {\r\n    protected #I1# component;\r\n    #F;#AC1#\r\n	\r\n    #M;#AC1#\r\n    public #AC1#(#I1# component) {\r\n        this.component = component;\r\n    }\r\n\r\n    @Override\r\n    public void Operation() {\r\n        component.Operation();\r\n    }\r\n}\r\n#DYNAMICS#\r\n#splitfile#\r\npublic class Program {\r\n    public static void main(String[] args) {\r\n        #I1# component = new #CC1#();\r\n        #I1# decoratedComponent = new #C2#(component);\r\n\r\n        decoratedComponent.Operation();\r\n    }\r\n}" });

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("6706a7fc-0d05-4484-a9eb-54d4a47723a1"),
                columns: new[] { "DynamicMethodACJava", "DynamicMethodCJava", "DynamicMethodIJava", "DynamicsCodeJava", "SchemaJava" },
                values: new object[] { "", "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("6c2afb6f-bcc5-4d02-92ef-b7df12fd0fac"),
                columns: new[] { "DynamicMethodACJava", "DynamicMethodCJava", "DynamicMethodIJava", "DynamicsCodeJava", "SchemaJava" },
                values: new object[] { "", "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("752a9281-8840-4d7b-8fd6-5da1b3eee655"),
                columns: new[] { "DynamicMethodACJava", "DynamicMethodCJava", "DynamicMethodIJava", "DynamicsCodeJava", "SchemaJava" },
                values: new object[] { "", "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("bfdf0acd-cb53-4f6d-8502-5369af29c23f"),
                columns: new[] { "DynamicMethodACJava", "DynamicMethodCJava", "DynamicMethodIJava", "DynamicsCodeJava", "SchemaJava" },
                values: new object[] { "", "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("d5842261-670b-4896-8697-4e4c263cd86f"),
                columns: new[] { "DynamicMethodACJava", "DynamicMethodCJava", "DynamicMethodIJava", "DynamicsCodeJava", "SchemaJava" },
                values: new object[] { "", "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("da697d34-84c0-476a-a083-6e8b00209367"),
                columns: new[] { "DynamicMethodAC", "DynamicMethodACJava", "DynamicMethodC", "DynamicMethodCJava", "DynamicMethodI", "DynamicMethodIJava", "DynamicsCode", "DynamicsCodeJava", "Schema", "SchemaJava", "ToInterpret" },
                values: new object[] { "\r\n    public virtual #TYPE# #NAME#(#PARAMS#){\r\n        component.#NAME#(#NOTYPEPARAMS#);\r\n    }", "\r\n    @Override\r\n    public #TYPE# #NAME#(#PARAMS#){\r\n        component.#NAME#(#NOTYPEPARAMS#);\r\n    }", "\r\n    public #TYPE# #NAME#(#PARAMS#){\r\n        throw new NotImplementedException();\r\n    }", "\r\n    @Override\r\n    public #TYPE# #NAME#(#PARAMS#){\r\n        throw new UnsupportedOperationException(\"Not implemented yet\");\r\n    }", "#TYPE# #NAME# (#PARAMS#);\n    ", "#TYPE# #NAME# (#PARAMS#);\n    ", "#splitfile#\r\npublic class #C#\r\n    {\r\n        private #I1# _builder;\r\n        #F;#C#\r\n\r\n		#M;#C#\r\n        public #I1# Builder\r\n        {\r\n            set { _builder = value; } \r\n        }\r\n        \r\n        public void BuildMinimalViableProduct()\r\n        {\r\n            this._builder.BuildPartA();\r\n        }\r\n        \r\n        public void BuildFullFeaturedProduct()\r\n        {\r\n            this._builder.BuildPartA();\r\n            this._builder.BuildPartB();\r\n        }\r\n    }", "#splitfile#\r\npublic class #C# {\r\n    private #I1# builder;\r\n    #F;#C#\r\n	\r\n    #M;#C#\r\n    public void setBuilder(#I1# builder) {\r\n        this.builder = builder;\r\n    }\r\n\r\n    public void BuildMinimalViableProduct() {\r\n        this.builder.BuildPartA();\r\n    }\r\n\r\n    public void BuildFullFeaturedProduct() {\r\n        this.builder.BuildPartA();\r\n        this.builder.BuildPartB();\r\n    }\r\n}", "#splitfile#\r\npublic interface #I1#\r\n    {\r\n	    #F;#I1#\r\n\r\n	    #M;#I1#\r\n        void BuildPartA();\r\n        \r\n        void BuildPartB();\r\n    }\r\n#splitfile#	\r\npublic class #CC1# : #I1#\r\n    {\r\n        private #CC2# _product = new #CC2#();\r\n        #F;#CC1#\r\n\r\n		#M;#CC1#\r\n        public #CC1#()\r\n        {\r\n            this.Reset();\r\n        }\r\n        \r\n        public void Reset()\r\n        {\r\n            this._product = new #CC2#();\r\n        }\r\n        \r\n        public void BuildPartA()\r\n        {\r\n            this._product.Add(\"PartA1\");\r\n        }\r\n        \r\n        public void BuildPartB()\r\n        {\r\n            this._product.Add(\"PartB1\");\r\n        }\r\n        \r\n        public #CC2# GetProduct()\r\n        {\r\n            #CC2# result = this._product;\r\n\r\n            this.Reset();\r\n\r\n            return result;\r\n        }\r\n    }\r\n#splitfile#\r\npublic class #CC2#\r\n    {\r\n        private List<string> _parts = new List<string>();\r\n        #F;#CC2#\r\n\r\n		#M;#CC2#\r\n        public void Add(string part)\r\n        {\r\n            this._parts.Add(part);\r\n        }\r\n        \r\n        public string ListParts()\r\n        {\r\n            string str = string.Empty;\r\n\r\n            for (int i = 0; i < this._parts.Count; i++)\r\n            {\r\n                str += this._parts[i] + \", \";\r\n            }\r\n\r\n            str = str.Remove(str.Length - 2);\r\n\r\n            return \"Product parts: \" + str + \"\\n\";\r\n        }\r\n    }\r\n#DYNAMICS#\r\n#splitfile#\r\nclass Program\r\n    {\r\n        static void Main(string[] args)\r\n        {\r\n            var director = new #C#();\r\n            var builder = new #CC1#();\r\n            director.Builder = builder;\r\n            \r\n            Console.WriteLine(\"Standard basic product:\");\r\n            director.BuildMinimalViableProduct();\r\n            Console.WriteLine(builder.GetProduct().ListParts());\r\n\r\n            Console.WriteLine(\"Standard full featured product:\");\r\n            director.BuildFullFeaturedProduct();\r\n            Console.WriteLine(builder.GetProduct().ListParts());\r\n\r\n            Console.WriteLine(\"Custom product:\");\r\n            builder.BuildPartA();\r\n            Console.Write(builder.GetProduct().ListParts());\r\n        }\r\n    }", "#splitfile#\r\npublic interface #I1# {\r\n    #F;#I1#\r\n	\r\n    #M;#I1#\r\n    void BuildPartA();\r\n    void BuildPartB();\r\n}\r\n#splitfile#\r\npublic class #CC1# implements #I1# {\r\n    private #CC2# product = new #CC2#();\r\n    #F;#CC1#\r\n	\r\n    #M;#CC1#\r\n    public #CC1#() {\r\n        this.Reset();\r\n    }\r\n\r\n    public void Reset() {\r\n        this.product = new #CC2#();\r\n    }\r\n\r\n    @Override\r\n    public void BuildPartA() {\r\n        this.product.Add(\"PartA1\");\r\n    }\r\n\r\n    @Override\r\n    public void BuildPartB() {\r\n        this.product.Add(\"PartB1\");\r\n    }\r\n\r\n    public #CC2# GetProduct() {\r\n        #CC2# result = this.product;\r\n        this.Reset();\r\n        return result;\r\n    }\r\n}\r\n#splitfile#\r\npublic class #CC2# {\r\n    private List<String> parts = new ArrayList<>();\r\n	#F;#CC2#\r\n	\r\n    #M;#CC2#\r\n    public void Add(String part) {\r\n        this.parts.add(part);\r\n    }\r\n\r\n    public String ListParts() {\r\n        StringBuilder str = new StringBuilder();\r\n\r\n        for (int i = 0; i < this.parts.size(); i++) {\r\n            str.append(this.parts.get(i)).append(\", \");\r\n        }\r\n\r\n        if (str.length() > 0) {\r\n            str.setLength(str.length() - 2);\r\n        }\r\n\r\n        return \"Product parts: \" + str + \"\\n\";\r\n    }\r\n}\r\n#DYNAMICS#\r\n#splitfile#\r\npublic class Program {\r\n    public static void main(String[] args) {\r\n        #C# director = new #C#();\r\n        #CC1# builder = new #CC1#();\r\n        director.setBuilder(builder);\r\n\r\n        System.out.println(\"Standard basic product:\");\r\n        director.BuildMinimalViableProduct();\r\n        System.out.println(builder.GetProduct().ListParts());\r\n\r\n        System.out.println(\"Standard full featured product:\");\r\n        director.BuildFullFeaturedProduct();\r\n        System.out.println(builder.GetProduct().ListParts());\r\n\r\n        System.out.println(\"Custom product:\");\r\n        builder.BuildPartA();\r\n        System.out.print(builder.GetProduct().ListParts());\r\n    }\r\n}", "#I1#Interfejs# #CC1#FajnaKlasa# #CC2#Produkt# #C1#KonkretnyBuilder# " });

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("f83fc61f-16b4-4160-9116-12d7c8c0c734"),
                columns: new[] { "DynamicMethodACJava", "DynamicMethodCJava", "DynamicMethodIJava", "DynamicsCodeJava", "SchemaJava" },
                values: new object[] { "", "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("ffb8c2cb-3b24-4bbe-b4bd-34061073ee98"),
                columns: new[] { "DynamicMethodAC", "DynamicMethodACJava", "DynamicMethodC", "DynamicMethodCJava", "DynamicMethodI", "DynamicMethodIJava", "DynamicsCode", "DynamicsCodeJava", "Schema", "SchemaJava", "ToInterpret" },
                values: new object[] { "\r\n    public virtual #TYPE# #NAME#(#PARAMS#){\r\n        component.#NAME#(#NOTYPEPARAMS#);\r\n    }", "\r\n    public #TYPE# #NAME#(#PARAMS#){\r\n        throw new UnsupportedOperationException(\"Not implemented yet\");\r\n    }", "\r\n    public #TYPE# #NAME#(#PARAMS#){\r\n        throw new NotImplementedException();\r\n    }", "\r\n    @Override\r\n    public #TYPE# #NAME#(#PARAMS#){\r\n        throw new UnsupportedOperationException(\"Not implemented yet\");\r\n    }", "#TYPE# #NAME# (#PARAMS#);\n    ", "#TYPE# #NAME# (#PARAMS#);\n    ", "#splitfile#\r\nclass #C# : #I1#\r\n{\r\n    private int _state;\r\n    #F;#C#\r\n\r\n	#M;#C#\r\n    public void UpdateState()\r\n    {\r\n        _state++;\r\n        NotifyObservers();\r\n    }\r\n\r\n    public int GetState()\r\n    {\r\n        return _state;\r\n    }\r\n}", "#splitfile#\r\npublic class #C# extends #AC1# {\r\n    private int state;\r\n	#F;#C#\r\n\r\n	#M;#C#\r\n    public void updateState() {\r\n        state++;\r\n        notifyObservers();\r\n    }\r\n\r\n    public int getState() {\r\n        return state;\r\n    }\r\n}", "#splitfile#\r\npublic interface #I1#\r\n{\r\n	#F;#I1#\r\n\r\n	#M;#I1#\r\n    void Update();\r\n}\r\n#splitfile#\r\npublic class #CC1# : #I1#\r\n{\r\n    private #CC2# _observable;\r\n    private int _state;\r\n    #F;#CC1#\r\n\r\n	#M;#CC1#\r\n    public #CC1#(#CC2# observable)\r\n    {\r\n        _observable = observable;\r\n    }\r\n\r\n    public void Update()\r\n    {\r\n        _state = _observable.GetState();\r\n        Console.WriteLine(\"new state = \" + _state);\r\n    }\r\n}\r\n#splitfile#\r\npublic abstract class #AC1#\r\n{\r\n	\r\n    private List<#I1#> _observers = new List<#I1#>();\r\n    #F;#AC1#\r\n\r\n	#M;#AC1#\r\n    public void AddObserver(#I1# observer)\r\n    {\r\n        _observers.Add(observer);\r\n    }\r\n\r\n    public void RemoveObserver(#I1# observer)\r\n    {\r\n        _observers.Remove(observer);\r\n    }\r\n\r\n    public void NotifyObservers(object obj)\r\n    {\r\n        foreach (#I1# observer in _observers)\r\n        {\r\n            observer.Update();\r\n        }\r\n    }\r\n}\r\n#splitfile#\r\npublic class #CC2# : #I1#\r\n{\r\n    private int _state;\r\n    #F;#CC2#\r\n\r\n	#M;#CC2#\r\n    public void UpdateState()\r\n    {\r\n        _state++;\r\n        NotifyObservers();\r\n    }\r\n\r\n    public int GetState()\r\n    {\r\n        return _state;\r\n    }\r\n}\r\n#DYNAMICS#\r\n#splitfile#\r\npublic class Program\r\n{\r\n    static void Main(string[] args)\r\n    {\r\n        #CC2# observable = new #CC2#();\r\n        #I1# observer = new ObserverImpl(observable);\r\n        observable.AddObserver(observer);\r\n\r\n        observable.UpdateState();\r\n        observable.UpdateState();\r\n    }\r\n}", "#splitfile#\r\npublic interface #I1# {\r\n	#F;#I1#\r\n	\r\n	#M;#I1#\r\n    void Update();\r\n}\r\n#splitfile#\r\npublic class #CC1# implements #I1# {\r\n    private #CC2# observable;\r\n    private int state;\r\n	#F;#CC1#\r\n\r\n	#M;#CC1#\r\n    public #CC1#(#CC2# observable) {\r\n        this.observable = observable;\r\n    }\r\n\r\n    @Override\r\n    public void Update() {\r\n        state = observable.getState();\r\n        System.out.println(\"new state = \" + state);\r\n    }\r\n}\r\n#splitfile#\r\npublic abstract class #AC1# {\r\n    private List<#I1#> observers = new ArrayList<>();\r\n	#F;#AC1#\r\n\r\n	#M;#AC1#\r\n    public void addObserver(#I1# observer) {\r\n        observers.add(observer);\r\n    }\r\n\r\n    public void removeObserver(#I1# observer) {\r\n        observers.remove(observer);\r\n    }\r\n\r\n    public void notifyObservers() {\r\n        for (#I1# observer : observers) {\r\n            observer.Update();\r\n        }\r\n    }\r\n}\r\n#splitfile#\r\npublic class #CC2# extends #AC1# {\r\n    private int state;\r\n	#F;#CC2#\r\n	\r\n	#M;#CC2#\r\n    public void updateState() {\r\n        state++;\r\n        notifyObservers();\r\n    }\r\n\r\n    public int getState() {\r\n        return state;\r\n    }\r\n}\r\n#DYNAMICS#\r\n#splitfile#\r\npublic class Program {\r\n    public static void main(String[] args) {\r\n        #CC2# observable = new #CC2#();\r\n        #I1# observer = new #CC1#(observable);\r\n        observable.addObserver(observer);\r\n\r\n        observable.updateState();\r\n        observable.updateState();\r\n    }\r\n}", "#I1#Interfejs# #CC1#Obserwator# #AC1#Abstrakcyjnaklasa# #CC2#ObserwatorImpl# " });

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("ffb8c2cb-3b24-4bbe-b4bd-35061073ee98"),
                columns: new[] { "DynamicMethodACJava", "DynamicMethodCJava", "DynamicMethodIJava", "DynamicsCodeJava", "SchemaJava" },
                values: new object[] { "", "", "", "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DynamicMethodACJava",
                table: "Patterns");

            migrationBuilder.DropColumn(
                name: "DynamicMethodCJava",
                table: "Patterns");

            migrationBuilder.DropColumn(
                name: "DynamicMethodIJava",
                table: "Patterns");

            migrationBuilder.DropColumn(
                name: "DynamicsCodeJava",
                table: "Patterns");

            migrationBuilder.DropColumn(
                name: "SchemaJava",
                table: "Patterns");

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("6469a535-507a-44fd-b9d7-dcf831847a21"),
                columns: new[] { "DynamicMethodAC", "DynamicMethodC", "DynamicsCode", "Schema" },
                values: new object[] { "\r\n    public #TYPE# #NAME#(#PARAMS#){\r\n        throw new NotImplementedException();\r\n    }", "\r\n    public virtual #TYPE# #NAME#(#PARAMS#){\r\n        component.#NAME#(#NOTYPEPARAMS#);\r\n    }", "\r\n#splitfile#\r\npublic class #C# : #AC1#\r\n{\r\n    #F;#C#\r\n    #M;#C#\r\n    public #C#(#I1# component) : base(component)\r\n    {\r\n    }\r\n\r\n    public override void Operation()\r\n    {\r\n        base.Operation();\r\n        AddedBehavior();\r\n    }\r\n\r\n    private void AddedBehavior()\r\n    {\r\n        Console.WriteLine(\"Added behavior by ConcreteDecorator\");\r\n    }\r\n}\r\n", "#splitfile#\r\npublic interface #I1#\r\n{\r\n    #F;#I1#\r\n    #M;#I1#\r\n    void Operation();\r\n}\r\n#splitfile#\r\npublic class #CC1# : #I1#\r\n{\r\n    #F;#CC1#\r\n    #M;#CC1#\r\n    public void Operation()\r\n    {\r\n        Console.WriteLine(\"ConcreteComponent operation\");\r\n    }\r\n}\r\n#splitfile#\r\npublic abstract class #AC1# : #I1#\r\n{\r\n    protected #I1# component;\r\n    \r\n    #F;#AC1#\r\n    #M;#AC1#\r\n\r\n    public #AC1#(#I1# component)\r\n    {\r\n        this.component = component;\r\n    }\r\n\r\n    public virtual void Operation()\r\n    {\r\n        component.Operation();\r\n    }\r\n}\r\n\r\n#DYNAMICS#\r\n#splitfile#\r\npublic class Program\r\n{\r\n    static void Main(string[] args)\r\n    {\r\n        #I1# component = new #CC1#();\r\n        #I1# decoratedComponent = new #C2#(component);\r\n\r\n        decoratedComponent.Operation();\r\n    }\r\n}" });

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("da697d34-84c0-476a-a083-6e8b00209367"),
                columns: new[] { "DynamicMethodAC", "DynamicMethodC", "DynamicMethodI", "DynamicsCode", "Schema", "ToInterpret" },
                values: new object[] { "", "", "", "#splitfile#\r\npublic class #C#\r\n    {\r\n        private #I1# _builder;\r\n		\r\n        #F;#C#\r\n		#M;#C#\r\n		\r\n        public #I1# Builder\r\n        {\r\n            set { _builder = value; } \r\n        }\r\n        \r\n        public void BuildMinimalViableProduct()\r\n        {\r\n            this._builder.BuildPartA();\r\n        }\r\n        \r\n        public void BuildFullFeaturedProduct()\r\n        {\r\n            this._builder.BuildPartA();\r\n            this._builder.BuildPartB();\r\n        }\r\n    }", "#splitfile#public interface #I1#\r\n    {\r\n	#F;#I1#\r\n	#M;#I1#\r\n        void BuildPartA();\r\n        \r\n        void BuildPartB();\r\n    }\r\n#splitfile#	\r\npublic class #CC1# : #I1#\r\n    {\r\n        private #CC2# _product = new #CC2#();\r\n		\r\n        #F;#CC1#\r\n		#M;#CC1#\r\n		\r\n        public #CC1#()\r\n        {\r\n            this.Reset();\r\n        }\r\n        \r\n        public void Reset()\r\n        {\r\n            this._product = new #CC2#();\r\n        }\r\n        \r\n        public void BuildPartA()\r\n        {\r\n            this._product.Add(\"PartA1\");\r\n        }\r\n        \r\n        public void BuildPartB()\r\n        {\r\n            this._product.Add(\"PartB1\");\r\n        }\r\n        \r\n        public #CC2# GetProduct()\r\n        {\r\n            #CC2# result = this._product;\r\n\r\n            this.Reset();\r\n\r\n            return result;\r\n        }\r\n    }\r\n#splitfile#\r\npublic class #CC2#\r\n    {\r\n		#F;#CC2#\r\n		#M;#CC2#\r\n        private List<string> _parts = new List<string>();\r\n        \r\n        public void Add(string part)\r\n        {\r\n            this._parts.Add(part);\r\n        }\r\n        \r\n        public string ListParts()\r\n        {\r\n            string str = string.Empty;\r\n\r\n            for (int i = 0; i < this._parts.Count; i++)\r\n            {\r\n                str += this._parts[i] + \", \";\r\n            }\r\n\r\n            str = str.Remove(str.Length - 2);\r\n\r\n            return \"Product parts: \" + str + \"\\n\";\r\n        }\r\n    }\r\n#DYNAMICS#\r\n#splitfile#\r\nclass Program\r\n    {\r\n        static void Main(string[] args)\r\n        {\r\n            var director = new #C#();\r\n            var builder = new #CC1#();\r\n            director.Builder = builder;\r\n            \r\n            Console.WriteLine(\"Standard basic product:\");\r\n            director.BuildMinimalViableProduct();\r\n            Console.WriteLine(builder.GetProduct().ListParts());\r\n\r\n            Console.WriteLine(\"Standard full featured product:\");\r\n            director.BuildFullFeaturedProduct();\r\n            Console.WriteLine(builder.GetProduct().ListParts());\r\n\r\n            Console.WriteLine(\"Custom product:\");\r\n            builder.BuildPartA();\r\n            Console.Write(builder.GetProduct().ListParts());\r\n        }\r\n    }", "#I1#Interfejs# #CC1#FajnaKlasa# #CC2#Produkt# #C1#KonkretnyBuilder#" });

            migrationBuilder.UpdateData(
                table: "Patterns",
                keyColumn: "Id",
                keyValue: new Guid("ffb8c2cb-3b24-4bbe-b4bd-34061073ee98"),
                columns: new[] { "DynamicMethodAC", "DynamicMethodC", "DynamicMethodI", "DynamicsCode", "Schema", "ToInterpret" },
                values: new object[] { "", "", "", "#splitfile#\r\nclass #C# : #I1#\r\n{\r\n	#F;#C#\r\n	#M;#C#\r\n    private int _state;\r\n\r\n    public void UpdateState()\r\n    {\r\n        _state++;\r\n        NotifyObservers();\r\n    }\r\n\r\n    public int GetState()\r\n    {\r\n        return _state;\r\n    }\r\n}", "#splitfile#\r\npublic interface #I1#\r\n{\r\n	#F;#I1#\r\n	#M;#I1#\r\n    void Update();\r\n}\r\n#splitfile#\r\npublic class #CC1# : #I1#\r\n{\r\n	#F;#CC1#\r\n	#M;#CC1#\r\n    private #CC2# _observable;\r\n    private int _state;\r\n\r\n    public #CC1#(#CC2# observable)\r\n    {\r\n        _observable = observable;\r\n    }\r\n\r\n    public void Update()\r\n    {\r\n        _state = _observable.GetState();\r\n        Console.WriteLine(\"new state = \" + _state);\r\n    }\r\n}\r\n#splitfile#\r\npublic abstract class #AC1#\r\n{\r\n	#F;#AC1#\r\n	#M;#AC1#\r\n    private List<#I1#> _observers = new List<#I1#>();\r\n\r\n    public void AddObserver(#I1# observer)\r\n    {\r\n        _observers.Add(observer);\r\n    }\r\n\r\n    public void RemoveObserver(#I1# observer)\r\n    {\r\n        _observers.Remove(observer);\r\n    }\r\n\r\n    public void NotifyObservers(object obj)\r\n    {\r\n        foreach (#I1# observer in _observers)\r\n        {\r\n            observer.Update();\r\n        }\r\n    }\r\n}\r\n#splitfile#\r\npublic class #CC2# : #I1#\r\n{\r\n	#F;#CC2#\r\n	#M;#CC2#\r\n    private int _state;\r\n\r\n    public void UpdateState()\r\n    {\r\n        _state++;\r\n        NotifyObservers();\r\n    }\r\n\r\n    public int GetState()\r\n    {\r\n        return _state;\r\n    }\r\n}\r\n#DYNAMICS#\r\n#splitfile#\r\npublic class Program\r\n{\r\n    static void Main(string[] args)\r\n    {\r\n        #CC2# observable = new #CC2#();\r\n        #I1# observer = new ObserverImpl(observable);\r\n        observable.AddObserver(observer);\r\n\r\n        // Symulacja aktualizacji stanu\r\n        observable.UpdateState();\r\n        observable.UpdateState();\r\n    }\r\n}", "#I1#Interfejs# #CC1#Obserwator# #AC1#Abstrakcyjnaklasa# #CC2#ObserwatorImpl#" });
        }
    }
}
