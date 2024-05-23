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
                SchemaJava = "",
                DynamicsCodeJava = "",
                ToInterpret = "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
                DynamicMethodIJava = "",
                DynamicMethodCJava = "",
                DynamicMethodACJava = "",
            },
            new PatternEntity
            {
                Id = Guid.Parse("249dbdc9-acc3-449d-8968-634c089e7ba1"),
                Name = "Bridge",
                Description = "The Bridge pattern decouples an abstraction from its implementation so that the two can vary independently.",
                Type = "Structural",
                Schema = "",
                DynamicsCode = "",
                SchemaJava = "",
                DynamicsCodeJava = "",
                ToInterpret = "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
                DynamicMethodIJava = "",
                DynamicMethodCJava = "",
                DynamicMethodACJava = "",
            },
            new PatternEntity
            {
                Id = Guid.Parse("493b34a1-12e1-4967-aa6c-a54cd9d147f9"),
                Name = "Composite",
                Description = "The Composite pattern composes objects into tree structures to represent part-whole hierarchies.",
                Type = "Structural",
                Schema = "",
                DynamicsCode = "",
                SchemaJava = "",
                DynamicsCodeJava = "",
                ToInterpret = "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
                DynamicMethodIJava = "",
                DynamicMethodCJava = "",
                DynamicMethodACJava = "",
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
                DynamicsCode = @"#splitfile#
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
                SchemaJava = @"#splitfile#
public interface #I1# {
    #F;#I1#
	
    #M;#I1#
    void Operation();
}
#splitfile#
public class #CC1# implements #I1# {
    #F;#CC1#
	
    #M;#CC1#
    @Override
    public void Operation() {
        System.out.println(""ConcreteComponent operation"");
    }
}
#splitfile#
public abstract class #AC1# implements #I1# {
    protected #I1# component;
    #F;#AC1#
	
    #M;#AC1#
    public #AC1#(#I1# component) {
        this.component = component;
    }

    @Override
    public void Operation() {
        component.Operation();
    }
}
#DYNAMICS#
#splitfile#
public class Program {
    public static void main(String[] args) {
        #I1# component = new #CC1#();
        #I1# decoratedComponent = new #C2#(component);

        decoratedComponent.Operation();
    }
}",
                DynamicsCodeJava = @"#splitfile#
public class #C# extends #AC1# {
    #F;#C#
	
    #M;#C#
    public #C#(#I1# component) {
        super(component);
    }

    @Override
    public void Operation() {
        super.Operation();
        AddedBehavior();
    }

    private void AddedBehavior() {
        System.out.println(""Added behavior by ConcreteDecorator"");
    }
}",
                ToInterpret = "#I1#FajnyInterfejs# #CC1#Klasa# #AC1#AbstrakcyjnaKlasa# #C2#KlasaDekoratora# ",
                DynamicMethodI = $"#TYPE# #NAME# (#PARAMS#);\n    ",
                DynamicMethodAC = @$"
    public virtual #TYPE# #NAME#(#PARAMS#){{
        component.#NAME#(#NOTYPEPARAMS#);
    }}",
                DynamicMethodC = @$"
    public #TYPE# #NAME#(#PARAMS#){{
        throw new NotImplementedException();
    }}",
                DynamicMethodIJava = $"#TYPE# #NAME# (#PARAMS#);\n    ",
                DynamicMethodACJava = @$"
    @Override
    public #TYPE# #NAME#(#PARAMS#){{
        component.#NAME#(#NOTYPEPARAMS#);
    }}",
                DynamicMethodCJava = @$"
    @Override
    public #TYPE# #NAME#(#PARAMS#){{
        throw new UnsupportedOperationException(""Not implemented yet"");
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
                SchemaJava = "",
                DynamicsCodeJava = "",
                ToInterpret = "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
                DynamicMethodIJava = "",
                DynamicMethodCJava = "",
                DynamicMethodACJava = "",
            },
            new PatternEntity
            {
                Id = Guid.Parse("6c2afb6f-bcc5-4d02-92ef-b7df12fd0fac"),
                Name = "Flyweight",
                Description = "The Flyweight pattern minimizes memory usage and improves performance by sharing as much as possible with similar objects.",
                Type = "Structural",
                Schema = @"",
                DynamicsCode = @"",
                SchemaJava = "",
                DynamicsCodeJava = "",
                ToInterpret = "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
                DynamicMethodIJava = "",
                DynamicMethodCJava = "",
                DynamicMethodACJava = "",
            },
            new PatternEntity
            {
                Id = Guid.Parse("752a9281-8840-4d7b-8fd6-5da1b3eee655"),
                Name = "Proxy",
                Description = "The Proxy pattern provides a surrogate or placeholder for another object to control access to it.",
                Type = "Structural",
                Schema = "",
                DynamicsCode = "",
                SchemaJava = "",
                DynamicsCodeJava = "",
                ToInterpret = "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
                DynamicMethodIJava = "",
                DynamicMethodCJava = "",
                DynamicMethodACJava = "",
            },
            new PatternEntity
            {
                Id = Guid.Parse("bfdf0acd-cb53-4f6d-8502-5369af29c23f"),
                Name = "Factory Method",
                Description = "The Factory Method pattern defines an interface for creating objects, but allows subclasses to alter the type of objects that will be created.",
                Type = "Creational",
                Schema = "",
                DynamicsCode = "",
                SchemaJava = "",
                DynamicsCodeJava = "",
                ToInterpret = "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
                DynamicMethodIJava = "",
                DynamicMethodCJava = "",
                DynamicMethodACJava = "",
            },
            new PatternEntity
            {
                Id = Guid.Parse("d5842261-670b-4896-8697-4e4c263cd86f"),
                Name = "Abstract Factory",
                Description = "The Abstract Factory pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes.",
                Type = "Creational",
                Schema = "",
                DynamicsCode = "",
                SchemaJava = "",
                DynamicsCodeJava = "",
                ToInterpret = "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
                DynamicMethodIJava = "",
                DynamicMethodCJava = "",
                DynamicMethodACJava = "",
            },
            new PatternEntity
            {
                Id = Guid.Parse("da697d34-84c0-476a-a083-6e8b00209367"),
                Name = "Builder",
                Description = "The Builder pattern separates the construction of a complex object from its representation, allowing the same construction process to create different representations.",
                Type = "Creational",
                Schema = @"#splitfile#
public interface #I1#
    {
	    #F;#I1#

	    #M;#I1#
        void BuildPartA();
        
        void BuildPartB();
    }
#splitfile#	
public class #CC1# : #I1#
    {
        private #CC2# _product = new #CC2#();
        #F;#CC1#

		#M;#CC1#
        public #CC1#()
        {
            this.Reset();
        }
        
        public void Reset()
        {
            this._product = new #CC2#();
        }
        
        public void BuildPartA()
        {
            this._product.Add(""PartA1"");
        }
        
        public void BuildPartB()
        {
            this._product.Add(""PartB1"");
        }
        
        public #CC2# GetProduct()
        {
            #CC2# result = this._product;

            this.Reset();

            return result;
        }
    }
#splitfile#
public class #CC2#
    {
        private List<string> _parts = new List<string>();
        #F;#CC2#

		#M;#CC2#
        public void Add(string part)
        {
            this._parts.Add(part);
        }
        
        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + "", "";
            }

            str = str.Remove(str.Length - 2);

            return ""Product parts: "" + str + ""\n"";
        }
    }
#DYNAMICS#
#splitfile#
class Program
    {
        static void Main(string[] args)
        {
            var director = new #C#();
            var builder = new #CC1#();
            director.Builder = builder;
            
            Console.WriteLine(""Standard basic product:"");
            director.BuildMinimalViableProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine(""Standard full featured product:"");
            director.BuildFullFeaturedProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine(""Custom product:"");
            builder.BuildPartA();
            Console.Write(builder.GetProduct().ListParts());
        }
    }",
                DynamicsCode = @"#splitfile#
public class #C#
    {
        private #I1# _builder;
        #F;#C#

		#M;#C#
        public #I1# Builder
        {
            set { _builder = value; } 
        }
        
        public void BuildMinimalViableProduct()
        {
            this._builder.BuildPartA();
        }
        
        public void BuildFullFeaturedProduct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
        }
    }",
                SchemaJava = @"#splitfile#
public interface #I1# {
    #F;#I1#
	
    #M;#I1#
    void BuildPartA();
    void BuildPartB();
}
#splitfile#
public class #CC1# implements #I1# {
    private #CC2# product = new #CC2#();
    #F;#CC1#
	
    #M;#CC1#
    public #CC1#() {
        this.Reset();
    }

    public void Reset() {
        this.product = new #CC2#();
    }

    @Override
    public void BuildPartA() {
        this.product.Add(""PartA1"");
    }

    @Override
    public void BuildPartB() {
        this.product.Add(""PartB1"");
    }

    public #CC2# GetProduct() {
        #CC2# result = this.product;
        this.Reset();
        return result;
    }
}
#splitfile#
public class #CC2# {
    private List<String> parts = new ArrayList<>();
	#F;#CC2#
	
    #M;#CC2#
    public void Add(String part) {
        this.parts.add(part);
    }

    public String ListParts() {
        StringBuilder str = new StringBuilder();

        for (int i = 0; i < this.parts.size(); i++) {
            str.append(this.parts.get(i)).append("", "");
        }

        if (str.length() > 0) {
            str.setLength(str.length() - 2);
        }

        return ""Product parts: "" + str + ""\n"";
    }
}
#DYNAMICS#
#splitfile#
public class Program {
    public static void main(String[] args) {
        #C# director = new #C#();
        #CC1# builder = new #CC1#();
        director.setBuilder(builder);

        System.out.println(""Standard basic product:"");
        director.BuildMinimalViableProduct();
        System.out.println(builder.GetProduct().ListParts());

        System.out.println(""Standard full featured product:"");
        director.BuildFullFeaturedProduct();
        System.out.println(builder.GetProduct().ListParts());

        System.out.println(""Custom product:"");
        builder.BuildPartA();
        System.out.print(builder.GetProduct().ListParts());
    }
}",
                DynamicsCodeJava = @"#splitfile#
public class #C# {
    private #I1# builder;
    #F;#C#
	
    #M;#C#
    public void setBuilder(#I1# builder) {
        this.builder = builder;
    }

    public void BuildMinimalViableProduct() {
        this.builder.BuildPartA();
    }

    public void BuildFullFeaturedProduct() {
        this.builder.BuildPartA();
        this.builder.BuildPartB();
    }
}",
                ToInterpret = "#I1#Interfejs# #CC1#FajnaKlasa# #CC2#Produkt# #C1#KonkretnyBuilder# ",
                DynamicMethodI = $"#TYPE# #NAME# (#PARAMS#);\n    ",
                DynamicMethodAC = @$"
    public virtual #TYPE# #NAME#(#PARAMS#){{
        component.#NAME#(#NOTYPEPARAMS#);
    }}",
                DynamicMethodC = @$"
    public #TYPE# #NAME#(#PARAMS#){{
        throw new NotImplementedException();
    }}",
                DynamicMethodIJava = $"#TYPE# #NAME# (#PARAMS#);\n    ",
                DynamicMethodACJava = @$"
    @Override
    public #TYPE# #NAME#(#PARAMS#){{
        component.#NAME#(#NOTYPEPARAMS#);
    }}",
                DynamicMethodCJava = @$"
    @Override
    public #TYPE# #NAME#(#PARAMS#){{
        throw new UnsupportedOperationException(""Not implemented yet"");
    }}",
            },
            new PatternEntity
            {
                Id = Guid.Parse("f83fc61f-16b4-4160-9116-12d7c8c0c734"),
                Name = "Prototype",
                Description = "The Prototype pattern creates new objects by copying an existing object, known as the prototype.",
                Type = "Creational",
                Schema = "",
                DynamicsCode = "",
                SchemaJava = "",
                DynamicsCodeJava = "",
                ToInterpret = "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
                DynamicMethodIJava = "",
                DynamicMethodCJava = "",
                DynamicMethodACJava = "",
            },
            new PatternEntity
            {
                Id = Guid.Parse("ffb8c2cb-3b24-4bbe-b4bd-35061073ee98"),
                Name = "Singleton",
                Description = "The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance.",
                Type = "Creational",
                Schema = "",
                DynamicsCode = "",
                SchemaJava = "",
                DynamicsCodeJava = "",
                ToInterpret = "",
                DynamicMethodI = "",
                DynamicMethodC = "",
                DynamicMethodAC = "",
                DynamicMethodIJava = "",
                DynamicMethodCJava = "",
                DynamicMethodACJava = "",
            },
            new PatternEntity
            {
                Id = Guid.Parse("ffb8c2cb-3b24-4bbe-b4bd-34061073ee98"),
                Name = "Observer",
                Description = "Observer is a behavioral design pattern that lets you define a subscription mechanism to notify multiple objects about any events that happen to the object they’re observing.",
                Type = "Behavioral",
                Schema = @"#splitfile#
public interface #I1#
{
	#F;#I1#

	#M;#I1#
    void Update();
}
#splitfile#
public class #CC1# : #I1#
{
    private #CC2# _observable;
    private int _state;
    #F;#CC1#

	#M;#CC1#
    public #CC1#(#CC2# observable)
    {
        _observable = observable;
    }

    public void Update()
    {
        _state = _observable.GetState();
        Console.WriteLine(""new state = "" + _state);
    }
}
#splitfile#
public abstract class #AC1#
{
	
    private List<#I1#> _observers = new List<#I1#>();
    #F;#AC1#

	#M;#AC1#
    public void AddObserver(#I1# observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(#I1# observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers(object obj)
    {
        foreach (#I1# observer in _observers)
        {
            observer.Update();
        }
    }
}
#splitfile#
public class #CC2# : #I1#
{
    private int _state;
    #F;#CC2#

	#M;#CC2#
    public void UpdateState()
    {
        _state++;
        NotifyObservers();
    }

    public int GetState()
    {
        return _state;
    }
}
#DYNAMICS#
#splitfile#
public class Program
{
    static void Main(string[] args)
    {
        #CC2# observable = new #CC2#();
        #I1# observer = new ObserverImpl(observable);
        observable.AddObserver(observer);

        observable.UpdateState();
        observable.UpdateState();
    }
}",
                DynamicsCode = @"#splitfile#
class #C# : #I1#
{
    private int _state;
    #F;#C#

	#M;#C#
    public void UpdateState()
    {
        _state++;
        NotifyObservers();
    }

    public int GetState()
    {
        return _state;
    }
}",
                SchemaJava = @"#splitfile#
public interface #I1# {
	#F;#I1#
	
	#M;#I1#
    void Update();
}
#splitfile#
public class #CC1# implements #I1# {
    private #CC2# observable;
    private int state;
	#F;#CC1#

	#M;#CC1#
    public #CC1#(#CC2# observable) {
        this.observable = observable;
    }

    @Override
    public void Update() {
        state = observable.getState();
        System.out.println(""new state = "" + state);
    }
}
#splitfile#
public abstract class #AC1# {
    private List<#I1#> observers = new ArrayList<>();
	#F;#AC1#

	#M;#AC1#
    public void addObserver(#I1# observer) {
        observers.add(observer);
    }

    public void removeObserver(#I1# observer) {
        observers.remove(observer);
    }

    public void notifyObservers() {
        for (#I1# observer : observers) {
            observer.Update();
        }
    }
}
#splitfile#
public class #CC2# extends #AC1# {
    private int state;
	#F;#CC2#
	
	#M;#CC2#
    public void updateState() {
        state++;
        notifyObservers();
    }

    public int getState() {
        return state;
    }
}
#DYNAMICS#
#splitfile#
public class Program {
    public static void main(String[] args) {
        #CC2# observable = new #CC2#();
        #I1# observer = new #CC1#(observable);
        observable.addObserver(observer);

        observable.updateState();
        observable.updateState();
    }
}",
                DynamicsCodeJava = @"#splitfile#
public class #C# extends #AC1# {
    private int state;
	#F;#C#

	#M;#C#
    public void updateState() {
        state++;
        notifyObservers();
    }

    public int getState() {
        return state;
    }
}",
                ToInterpret = "#I1#Interfejs# #CC1#Obserwator# #AC1#Abstrakcyjnaklasa# #CC2#ObserwatorImpl# ",
                DynamicMethodI = $"#TYPE# #NAME# (#PARAMS#);\n    ",
                DynamicMethodAC = @$"
    public virtual #TYPE# #NAME#(#PARAMS#){{
        component.#NAME#(#NOTYPEPARAMS#);
    }}",
                DynamicMethodC = @$"
    public #TYPE# #NAME#(#PARAMS#){{
        throw new NotImplementedException();
    }}",
                DynamicMethodIJava = $"#TYPE# #NAME# (#PARAMS#);\n    ",
                DynamicMethodACJava = @$"
    public #TYPE# #NAME#(#PARAMS#){{
        throw new UnsupportedOperationException(""Not implemented yet"");
    }}",
                DynamicMethodCJava = @$"
    @Override
    public #TYPE# #NAME#(#PARAMS#){{
        throw new UnsupportedOperationException(""Not implemented yet"");
    }}",
            }
            );
        }
    }
}
