namespace WzorceProjektowe.API.Dto
{
    public class GetPatternCodeByNameResponseDto
    {
        public string PatternName { get; set; }
        public string ToInterpret { get; set; }
        public string DynamicClass { get; set; }
        public string DynamicMethodI { get; set; }
        public string DynamicMethodC { get; set; }
        public string DynamicMethodAC { get; set; }
        public List<CodeFile> ListCodes { get; set; } = new List<CodeFile>();
        public GetPatternCodeByNameResponseDto() { }
        public GetPatternCodeByNameResponseDto(string patternName, string toInterpret, string dynamicClass, string dynamicMethodI, string dynamicMethodC, string dynamicMethodAC)
        {
            PatternName = patternName;
            ToInterpret = toInterpret;
            DynamicClass = dynamicClass;
            DynamicMethodI = dynamicMethodI;
            DynamicMethodC = dynamicMethodC;
            DynamicMethodAC = dynamicMethodAC;
        }
    }
}
