namespace WzorceProjektowe.API.Dto
{
    public class DynamicFields
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Destination { get; set; }
        public DynamicFields() { }
        public DynamicFields(string name, string type, string destination)
        {
            Name = name;
            Type = type;
            Destination = destination;
        }
    }
}
