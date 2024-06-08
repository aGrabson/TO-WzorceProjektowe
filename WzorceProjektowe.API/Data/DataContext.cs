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
                Schema = @"#splitfile#
public class #CC1#
{
    private #CC2# flightBooking;
    private #CC3# hotelBooking;
    private #CC4# carRental;
	#F;#CC1#

	#M;#CC1#
    public #CC1#()
    {
        flightBooking = new #CC2#();
        hotelBooking = new #CC3#();
        carRental = new #CC4#();
    }

    public void BookCompleteTrip(string departure, string destination, string hotelName, string carType)
    {
        Console.WriteLine(""Booking complete trip..."");
        flightBooking.BookFlight(departure, destination);
        hotelBooking.BookHotel(hotelName);
        carRental.RentCar(carType);
        Console.WriteLine(""Trip booking completed."");
    }
	
	public void BookInCompleteTrip(string departure, string destination, string hotelName)
    {
        Console.WriteLine(""Booking complete trip..."");
        flightBooking.BookFlight(departure, destination);
        hotelBooking.BookHotel(hotelName);
        Console.WriteLine(""Trip booking without car rental completed."");
    }
}
#splitfile#
public class #CC2#
{
	#F;#CC2#

	#M;#CC2#
    public void BookFlight(string departure, string destination)
    {
        Console.WriteLine($""Flight booked from {departure} to {destination}"");
    }
}
#splitfile#
public class #CC3#
{
	#F;#CC3#

	#M;#CC3#
    public void BookHotel(string hotelName)
    {
        Console.WriteLine($""Hotel booked: {hotelName}"");
    }
}
#splitfile#
public class #CC4#
{
	#F;#CC4#

	#M;#CC4#
    public void RentCar(string carType)
    {
        Console.WriteLine($""Car rented: {carType}"");
    }
}
#DYNAMICS#
#splitfile#
class Program
{
    static void Main(string[] args)
    {
        #CC1# travelFacade = new #CC1#();
        
        travelFacade.BookCompleteTrip(""New York"", ""Los Angeles"", ""The Ritz-Carlton"", ""SUV"");
        travelFacade.BookInCompleteTrip(""New York"", ""Los Angeles"", ""The Ritz-Carlton"");
        
    }
}",
                DynamicsCode = @"#splitfile#
public class #C#
{
    #F;#C#

	#M;#C#
}",
                SchemaJava = @"#splitfile#
public class #CC1# {
    private #CC2# flightBooking;
    private #CC3# hotelBooking;
    private #CC4# carRental;
    #F;#CC1#

    #M;#CC1#
    public #CC1#() {
        flightBooking = new #CC2#();
        hotelBooking = new #CC3#();
        carRental = new #CC4#();
    }

    public void BookCompleteTrip(String departure, String destination, String hotelName, String carType) {
        System.out.println(""Booking complete trip..."");
        flightBooking.BookFlight(departure, destination);
        hotelBooking.BookHotel(hotelName);
        carRental.RentCar(carType);
        System.out.println(""Trip booking completed."");
    }

    public void BookInCompleteTrip(String departure, String destination, String hotelName) {
        System.out.println(""Booking complete trip..."");
        flightBooking.BookFlight(departure, destination);
        hotelBooking.BookHotel(hotelName);
        System.out.println(""Trip booking without car rental completed."");
    }
}
#splitfile#
public class #CC2# {
    #F;#CC2#

    #M;#CC2#
    public void BookFlight(String departure, String destination) {
        System.out.println(""Flight booked from "" + departure + "" to "" + destination);
    }
}
#splitfile#
public class #CC3# {
    #F;#CC3#

    #M;#CC3#
    public void BookHotel(String hotelName) {
        System.out.println(""Hotel booked: "" + hotelName);
    }
}
#splitfile#
public class #CC4# {
    #F;#CC4#

    #M;#CC4#
    public void RentCar(String carType) {
        System.out.println(""Car rented: "" + carType);
    }
}
#DYNAMICS#
#splitfile#
public class Program {
    public static void main(String[] args) {
        #CC1# travelFacade = new #CC1#();
        
        travelFacade.BookCompleteTrip(""New York"", ""Los Angeles"", ""The Ritz-Carlton"", ""SUV"");
        travelFacade.BookInCompleteTrip(""New York"", ""Los Angeles"", ""The Ritz-Carlton"");
    }
}",
                DynamicsCodeJava = @"#splitfile#
public class #C# {
    #F;#C#

    #M;#C#
}",
                ToInterpret = "#CC1#TravelFacade# #CC2#FlightBooking# #CC3#HotelBooking# #CC4#CarRental# ",
                DynamicMethodI = @"",
                DynamicMethodC = @$"
    public #TYPE# #NAME#(#PARAMS#){{
        throw new NotImplementedException();
    }}",
                DynamicMethodAC = @"",
                DynamicMethodIJava = @"",
                DynamicMethodCJava = @$"
    public #TYPE# #NAME#(#PARAMS#){{
        throw new UnsupportedOperationException(""Not implemented yet"");
    }}",
                DynamicMethodACJava = @"",
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
                Schema = @"#splitfile#
public sealed class #CC1#
{ 
	private static #CC1# _instance;
	#F;#CC1#

	#M;#CC1#
    private #CC1#() { }
	
    public static #CC1# GetInstance()
    {
        if (_instance == null)
        {
            _instance = new #CC1#();
        }
        return _instance;
    }
}
#DYNAMICS#
#splitfile#
class Program
{
    static void Main(string[] args)
    {
        #CC1# s1 = #CC1#.GetInstance();
        #CC1# s2 = #CC1#.GetInstance();
    }
}",
                DynamicsCode = @"#splitfile#
public sealed class #C#
{ 
	private static #C# _instance;
	#F;#C#

	#M;#C#
    private #C#() { }
	
    public static #C# GetInstance()
    {
        if (_instance == null)
        {
            _instance = new #C#();
        }
        return _instance;
    }
}",
                SchemaJava = @"#splitfile#
public final class #CC1# {
    private static #CC1# _instance;
    #F;#CC1#

    #M;#CC1#
    private #CC1#() { }
    
    public static synchronized #CC1# GetInstance() {
        if (_instance == null) {
            _instance = new #CC1#();
        }
        return _instance;
    }
}
#DYNAMICS#
#splitfile#
public class Program {
    public static void main(String[] args) {
        #CC1# s1 = #CC1#.GetInstance();
        #CC1# s2 = #CC1#.GetInstance();
    }
}",
                DynamicsCodeJava = @"#splitfile#
public final class #C# {
    private static #C# _instance;
    #F;#C#

    #M;#C#
    private #C#() { }
    
    public static synchronized #C# GetInstance() {
        if (_instance == null) {
            _instance = new #C#();
        }
        return _instance;
    }
}",
                ToInterpret = "#CC1#Singleton# ",
                DynamicMethodI = "",
                DynamicMethodC = @$"
    public #TYPE# #NAME#(#PARAMS#){{
        throw new NotImplementedException();
    }}",
                DynamicMethodAC = "",
                DynamicMethodIJava = "",
                DynamicMethodCJava = @$"
    public #TYPE# #NAME#(#PARAMS#){{
        throw new UnsupportedOperationException(""Not implemented yet"");
    }}",
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
            },
            new PatternEntity
            {
                Id = Guid.Parse("ffb8c2cb-3b34-4bbe-b4bd-35061073ee98"),
                Name = "Chain of Responsibility",
                Description = "Chain of Responsibility is a behavioral design pattern that lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.",
                Type = "Behavioral",
                Schema = @"#splitfile#
public interface #I1#
{
	#F;#I1#

	#M;#I1#
    #I1# SetNext(#I1# handler);
    
    object Handle(object request);
}
#splitfile#
abstract class #AC1# : #I1#
{
    private #I1# _nextHandler;
	#F;#AC1#

	#M;#AC1#
    public #I1# SetNext(#I1# handler)
    {
        this._nextHandler = handler;
        
        return handler;
    }
    
    public virtual object Handle(object request)
    {
        if (this._nextHandler != null)
        {
            return this._nextHandler.Handle(request);
        }
        else
        {
            return null;
        }
    }
}
#splitfile#
class #CC1# : #AC1#
{
	#F;#CC1#

	#M;#CC1#
    public override object Handle(object request)
    {
        if ((request as string) == ""Pizza"")
        {
			Console.Write($""Johny: I'll eat the {request.ToString()}.\n"");
            return """";
        }
        else
        {
			Console.Write($""Johny: I'm hungry!\n"");
            return base.Handle(request);
        }
    }
}
#splitfile#
class #CC2# : #AC1#
{
	#F;#CC2#

	#M;#CC2#
    public override object Handle(object request)
    {
        if (request.ToString() == ""Donut"")
        {
			Console.Write($""Arthur: I'll eat the {request.ToString()}.\n"");
            return """";
        }
        else
        {
			Console.Write($""Arthur: I'm hungry!\n"");
            return base.Handle(request);
        }
    }
}
#splitfile#
class #CC3# : #AC1#
{
	#F;#CC3#

	#M;#CC3#
    public override object Handle(object request)
    {
        if (request.ToString() == ""Kebab"")
        {
			Console.Write($""Tadeusz: I'll eat the {request.ToString()}.\n"");
            return """";
        }
        else
        {
			Console.Write($""Tadeusz: I'm hungry!\n"");
            return base.Handle(request);
        }
    }
}
#DYNAMICS#
#splitfile#
class Program
{
    static void Main(string[] args)
    {
        var handler1 = new #CC1#();
        var handler2 = new #CC2#();
        var handler3 = new #CC3#();

        handler1.SetNext(handler2).SetNext(handler3);

        foreach (var food in new List<string> { ""Pizza"", ""Kebab"", ""Cup of coffee"", ""Donut"" })
        {
            Console.WriteLine($""Chef: Who wants a {food}?"");

            var result = handler1.Handle(food);

            if (result == null)
            {
                Console.WriteLine($""   {food} was left untouched."");
            }
        }
    }
}",
                DynamicsCode = @"#splitfile#
class #C# : #AC1#
{
	#F;#C#

	#M;#C#
    public override object Handle(object request)
    {
        if (request.ToString() == ""Cup of coffee"") //change in your code
        {
			Console.Write($""NewHandler: I'll eat the {request.ToString()}.\n"");
            return """";
        }
        else
        {
			Console.Write($""NewHandler: I'm hungry!\n"");
            return base.Handle(request);
        }
    }
}",
                SchemaJava = @"#splitfile#
public interface #I1# {
    #F;#I1#

    #M;#I1#
    #I1# SetNext(#I1# handler);
    
    Object Handle(Object request);
}
#splitfile#
abstract class #AC1# implements #I1# {
    private #I1# _nextHandler;
    #F;#AC1#

    #M;#AC1#
    public #I1# SetNext(#I1# handler) {
        this._nextHandler = handler;
        
        return handler;
    }
    
    public Object Handle(Object request) {
        if (this._nextHandler != null) {
            return this._nextHandler.Handle(request);
        } else {
            return null;
        }
    }
}
#splitfile#
class #CC1# extends #AC1# {
    #F;#CC1#

    #M;#CC1#
    @Override
    public Object Handle(Object request) {
        if (request.toString().equals(""Pizza"")) {
            System.out.print(""Johny: I'll eat the "" + request.toString() + "".\n"");
            return """";
        } else {
            System.out.print(""Johny: I'm hungry!\n"");
            return super.Handle(request);
        }
    }
}
#splitfile#
class #CC2# extends #AC1# {
    #F;#CC2#

    #M;#CC2#
    @Override
    public Object Handle(Object request) {
        if (request.toString().equals(""Donut"")) {
            System.out.print(""Arthur: I'll eat the "" + request.toString() + "".\n"");
            return """";
        } else {
            System.out.print(""Arthur: I'm hungry!\n"");
            return super.Handle(request);
        }
    }
}
#splitfile#
class #CC3# extends #AC1# {
    #F;#CC3#

    #M;#CC3#
    @Override
    public Object Handle(Object request) {
        if (request.toString().equals(""Kebab"")) {
            System.out.print(""Tadeusz: I'll eat the "" + request.toString() + "".\n"");
            return """";
        } else {
            System.out.print(""Tadeusz: I'm hungry!\n"");
            return super.Handle(request);
        }
    }
}
#DYNAMICS#
#splitfile#
public class Program {
    public static void main(String[] args) {
        #CC1# handler1 = new #CC1#();
        #CC2# handler2 = new #CC2#();
        #CC3# handler3 = new #CC3#();

        handler1.SetNext(handler2).SetNext(handler3);

        List<String> foods = Arrays.asList(""Pizza"", ""Kebab"", ""Cup of coffee"", ""Donut"");
        for (String food : foods) {
            System.out.println(""Chef: Who wants a "" + food + ""?"");

            Object result = handler1.Handle(food);

            if (result == null) {
                System.out.println(""   "" + food + "" was left untouched."");
            }
        }
    }
}",
                DynamicsCodeJava = @"#splitfile#
class #C# extends #AC1# {
    #F;#C#

    #M;#C#
    @Override
    public Object Handle(Object request) {
        if (request.toString().equals(""Cup of coffee"")) {
            System.out.print(""NewHandler: I'll drink the "" + request.toString() + "".\n"");
            return """";
        } else {
            System.out.print(""NewHandler: I'm thirsty!\n"");
            return super.Handle(request);
        }
    }
}",
                ToInterpret = "#I1#IHandler# #AC1#AbstractHandler# #CC1#JohnyHandler# #CC2#ArthurHandler# #CC3#TadeuszHandler# ",
                DynamicMethodI = $"#TYPE# #NAME# (#PARAMS#);\n    ",
                DynamicMethodC = @$"
    public #TYPE# #NAME#(#PARAMS#){{
        throw new NotImplementedException();
    }}",
                DynamicMethodAC = @$"
    public #TYPE# #NAME#(#PARAMS#){{
        throw new NotImplementedException();
    }}",
                DynamicMethodIJava = $"#TYPE# #NAME# (#PARAMS#);\n    ",
                DynamicMethodCJava = @$"
    @Override
    public #TYPE# #NAME#(#PARAMS#){{
        throw new UnsupportedOperationException(""Not implemented yet"");
    }}",
                DynamicMethodACJava = @$"
    public #TYPE# #NAME#(#PARAMS#){{
        throw new UnsupportedOperationException(""Not implemented yet"");
    }}",
            }
            );
        }
    }
}
