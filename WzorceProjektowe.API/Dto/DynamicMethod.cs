namespace WzorceProjektowe.API.Dto
{
    public class DynamicMethod
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Destination { get; set; }
        public List<Tuple<string, string>> Params { get; set; }
        public DynamicMethod() { }
        public DynamicMethod(string name, string type, string destination, List<Tuple<string, string>> @params)
        {
            Name = name;
            Type = type;
            Destination = destination;
            Params = @params;
        }
    }
}
