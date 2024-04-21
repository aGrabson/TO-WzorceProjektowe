using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using WzorceProjektowe.API.Data;
using WzorceProjektowe.API.Dto;
using WzorceProjektowe.API.Interfaces;

namespace WzorceProjektowe.API.Services
{
    public class PatternService : IPatternService
    {
        private readonly DataContext _context;
        private const string separator = "#";
        private string templateCoreCode = @"#splitfile#
public interface #I1#
{
            void Operation();
        }
#splitfile#
        public class #C1# : #I1#
{
            public void Operation()
            {
                Console.WriteLine(""ConcreteComponent operation"");
            }
        }
#splitfile#
        public abstract class #AC1# : #I1#
{
            protected #I1# component;

    public #AC1#(#I1# component)
    {
        this.component = component;
    }

        public virtual void Operation()
        {
            component.Operation();
        }
    }
#splitfile#
using System;
public class #C2# : #AC1#
{
        public #C2#(#I1# component) : base(component)
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

#DYNAMICS#
#splitfile#
public class Program
{
    static void Main(string[] args)
    {
        // Tworzymy konkretne komponenty i dekorujemy je
#I1# component = new #C1#();
#I1# decoratedComponent = new #C2#(component);

        // Wywołujemy operację na dekoratorze, która przejdzie przez wszystkie dekoratory
        decoratedComponent.Operation();

        /*
            Wynik działania programu:
            ConcreteComponent operation
            Added behavior by ConcreteDecorator
        */
    }
}
";
        private string templateDynamicCode = @"
#splitfile#
using System;
public class #C# : #AC1#
{
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
";

        public PatternService(DataContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> GetPatternById(Guid guid)
        {
            var pattern = await _context.Patterns.FirstOrDefaultAsync(x => x.Id == guid);
            if (pattern == null)
            {
                return new NotFoundResult();
            }
            return new OkObjectResult(pattern);
        }
        public async Task<IActionResult> GetPatternsByType(string type)
        {
            var patterns = await _context.Patterns.Where(x => x.Type == type).ToListAsync();
            if (patterns == null)
            {
                return new NotFoundResult();
            }
            return new OkObjectResult(patterns);
        }
        static string GenerateDynamics(string template, List<Tuple<string, string>> classNames)
        {
            string result = "";

            foreach (var tuple in classNames)
            {
                result += template;
                result = result.Replace(separator + "C" + separator, separator + tuple.Item1 + separator);
            }

            return result;
        }
        static string FillTemplate(string template,string dynamicTemplate, string[] replacements)
        {
            string[] tmpReplacements = replacements;
            List<Tuple<string,string>> dynamicClasses = new();
            List<Tuple<string, Tuple<string,string>>> dynamicFields = new();
            int counter = 0;

            for (int i = 0; i <= tmpReplacements.Length - 1; i++)
            {
                string replace = replacements[i];
                string trimmedLine = replace.Trim();
                if (Regex.IsMatch(trimmedLine, separator + "C.*" + separator) && trimmedLine.EndsWith(separator))
                {
                    if(Regex.IsMatch(trimmedLine, separator + "CC.*" + separator))
                    {
                        continue;
                    }
                    string[] parts = trimmedLine.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 2)
                    {
                        counter += 1;
                        string key = parts[0].Trim();
                        string name = parts[1].Trim();
                        dynamicClasses.Add(Tuple.Create(key, name));
                    }
                }
                else if (trimmedLine.StartsWith(separator + "F") && trimmedLine.EndsWith(separator))
                {
                    //#P;I1;int#nazwa#
                    string[] parts = trimmedLine.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 2)
                    {
                        string[] parts2 = parts[0].Split(";", StringSplitOptions.RemoveEmptyEntries);
                        if (parts2.Length == 3)
                        {
                            string dest = parts2[1].Trim();
                            string type = parts2[2].Trim();
                            string name = parts[1].Trim();
                            dynamicFields.Add(new Tuple<string, Tuple<string, string>>(dest, Tuple.Create(type, name)));
                            tmpReplacements[i] = null;
                        }
                    }
                }
            }

            tmpReplacements = tmpReplacements.Where(r => r != null).ToArray();

            string decorators = GenerateDynamics(dynamicTemplate,dynamicClasses);

            template = template.Replace(separator + "DYNAMICS" + separator, decorators);

            var test = dynamicFields.GroupBy(x => x.Item1);

            foreach (var tmp in test)
            {
                string fieldReplacement = string.Empty;
                string key = tmp.Key;
                foreach (var x in tmp)
                {
                    fieldReplacement += $"public {x.Item2.Item1} {x.Item2.Item2};\n    ";
                }
                template = template.Replace(separator + "F;" + separator + key + separator, fieldReplacement);
            }

            foreach (string replace in tmpReplacements)
            {
                string trimmedLine = replace.Trim();
                if (trimmedLine.StartsWith(separator) && trimmedLine.EndsWith(separator))
                {
                    string[] parts = trimmedLine.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 2)
                    {
                        string tag = parts[0].ToUpper();
                        string name = parts[1].Trim();

                        template = template.Replace(separator + tag + separator, name);
                    }
                }
            }

            

            string[] lines = template.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            lines = lines.Where(line => !line.Contains("#F") && !line.Contains("#M")).ToArray();

            string updatedContent = string.Join(Environment.NewLine, lines);

            return updatedContent;
        }
        public async Task<IActionResult> GetPatternCodeByType(GetPatternCodeByTypeRequestDto request)
        {
            //pobranie patternu dla dodatkowych klas oraz podstawowego szablonu
            var patternEntity = await _context.Patterns.FirstOrDefaultAsync(x => x.Name == "Decorator");

            string[] replacements = request.ToInterpret.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //string[] replacements = { "#I1#FajnyInterfejs#", "#C1#Klasa#", "#AC1#AbstrakcyjnaKlasa#", "#C2#KlasaDekoratora#", "#C#NowyDekorator1#", "#C#NowyDekorator2#" };
            string filledCode = FillTemplate(patternEntity.Schema, patternEntity.DynamicsCode, replacements);
            //Wywolanie w swagger
            //            {
            //                "patternID": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
            //  "toInterpret": "#I1#FajnyInterfejs# #CC1#Klasa# #AC1#AbstrakcyjnaKlasa# #C2#KlasaDekoratora# #C5#NowyDekorator1# #C7#NowyDekorator2#  #F;C1;int#nazwa9#  #F;C2;int#nazwa3# #C3#Klasaasdas#"
            //}
            return new OkObjectResult(filledCode);
        }
        public async Task<IActionResult> GetPatternCodeByName(GetPatternCodeByNameRequestDto request)
        {
            //pobranie patternu dla dodatkowych klas oraz podstawowego szablonu
            var patternEntity = await _context.Patterns.FirstOrDefaultAsync(x => x.Name == request.PatternName);
            if (patternEntity == null)
            {
                return new NotFoundResult();
            }

            string[] replacements = patternEntity.ToInterpret.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //string[] replacements = { "#I1#FajnyInterfejs#", "#C1#Klasa#", "#AC1#AbstrakcyjnaKlasa#", "#C2#KlasaDekoratora#", "#C#NowyDekorator1#", "#C#NowyDekorator2#" };
            //string filledCode = FillTemplate(patternEntity.Schema, patternEntity.DynamicsCode, replacements);
            string filledCode = patternEntity.Schema.Replace(separator + "DYNAMICS" + separator, " ");
            string[] splitCodes = filledCode.Split("#splitfile#", StringSplitOptions.RemoveEmptyEntries);
            if(splitCodes.Length != replacements.Length+1) 
            {
                return new NotFoundResult();
            }
            GetPatternCodeByNameResponseDto response = new GetPatternCodeByNameResponseDto();
            response.PatternName = patternEntity.Name;
            response.ToInterpret = patternEntity.ToInterpret;
            response.DynamicClass = patternEntity.DynamicsCode;
            int i = 0;
            for(; i<replacements.Length; i++ )
            {
                response.ListCodes.Add(new CodeFile { Content = splitCodes[i], FileName = "#" + replacements[i].Split(separator, StringSplitOptions.RemoveEmptyEntries).ElementAt(0) + "#" });
            }
            response.ListCodes.Add(new CodeFile { Content = splitCodes[i], FileName = "Program" });
            return new OkObjectResult(response);
        }

    }
}
