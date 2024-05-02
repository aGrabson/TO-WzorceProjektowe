﻿
namespace WzorceProjektowe.API.Entities
{
    public class PatternEntity : BaseDbItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Schema { get; set; }
        public string ToInterpret { get; set; }
        public string DynamicsCode { get; set; }
        public string DynamicMethodI { get; set; }
        public string DynamicMethodC { get; set; }
        public string DynamicMethodAC { get; set; }
    }
}
