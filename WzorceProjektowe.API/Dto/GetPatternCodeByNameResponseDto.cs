namespace WzorceProjektowe.API.Dto
{
    public class GetPatternCodeByNameResponseDto
    {
        public string PatternName { get; set; }
        public string ToInterpret { get; set; }
        public string DynamicClass { get; set; }
        public List<CodeFile> ListCodes { get; set; } = new List<CodeFile>();
    }
}
