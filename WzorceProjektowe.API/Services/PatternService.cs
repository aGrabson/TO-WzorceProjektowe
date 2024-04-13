using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System;
using WzorceProjektowe.API.Data;
using WzorceProjektowe.API.Dto;
using WzorceProjektowe.API.Interfaces;

namespace WzorceProjektowe.API.Services
{
    public class PatternService : IPatternService
    {
        private readonly DataContext _context;
        private const string seperator = "#";
        private string templateCoreCode = @"
using System;

public interface #I1#
{
    void Operation();
}

public class #C1# : #I1#
{
    public void Operation()
    {
        Console.WriteLine(""ConcreteComponent operation"");
    }
}

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
}";
        private string templateDynamicCode = $@"
public class #C# : #AC1#
{{
    public #C#(#I1# component) : base(component)
    {{
    }}

    public override void Operation()
    {{
        base.Operation();
        AddedBehavior();
    }}

    private void AddedBehavior()
    {{
        Console.WriteLine(""Added behavior by ConcreteDecorator"");
    }}
}}
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
        static string GenerateDynamics(string template, List<string> classNames)
        {
            string result = "";

            foreach (string className in classNames)
            {
                result += template;
                result = result.Replace(seperator + "C" + seperator, className);
            }

            return result;
        }
        static string FillTemplate(string template,string dynamicTemplate, string[] replacements)
        {
            string[] tmpReplacements = replacements;
            List<string> dynamicClasses = new();

            for (int i = 0; i <= tmpReplacements.Length - 1; i++)
            {
                string replace = replacements[i];
                string trimmedLine = replace.Trim();
                if (trimmedLine.StartsWith(seperator + "C" + seperator) && trimmedLine.EndsWith(seperator))
                {
                    string[] parts = trimmedLine.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 2)
                    {
                        string name = parts[1].Trim();
                        dynamicClasses.Add(name);
                        tmpReplacements[i] = null;
                    }
                }
            }

            tmpReplacements = tmpReplacements.Where(r => r != null).ToArray();

            string decorators = GenerateDynamics(dynamicTemplate,dynamicClasses);

            template = template.Replace(seperator + "DYNAMICS" + seperator, decorators);

            foreach (string replace in tmpReplacements)
            {
                string trimmedLine = replace.Trim();
                if (trimmedLine.StartsWith(seperator) && trimmedLine.EndsWith(seperator))
                {
                    string[] parts = trimmedLine.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length >= 2)
                    {
                        string tag = parts[0].ToUpper();
                        string name = parts[1].Trim();

                        template = template.Replace(seperator + tag + seperator, name);
                    }
                }
            }

            return template;
        }
        public async Task<IActionResult> GetPatternCodeByType(GetPatternCodeByTypeRequestDto request)
        {
            //pobranie patternu dla dodatkowych klas oraz podstawowego szablonu
            
            string[] replacements = request.ToInterpret.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //string[] replacements = { "#I1#FajnyInterfejs#", "#C1#Klasa#", "#AC1#AbstrakcyjnaKlasa#", "#C2#KlasaDekoratora#", "#C#NowyDekorator1#", "#C#NowyDekorator2#" };
            string filledCode = FillTemplate(templateCoreCode, templateDynamicCode, replacements);
//Wywolanie w swagger
//            {
//                "patternID": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
//  "toInterpret": "#I1#FajnyInterfejs# #C1#Klasa# #AC1#AbstrakcyjnaKlasa# #C2#KlasaDekoratora# #C#NowyDekorator1# #C#NowyDekorator2#"
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
            string filledCode = patternEntity.Schema.Replace(seperator + "DYNAMICS" + seperator, " ");
            string[] splitCodes = filledCode.Split("#splitfile#", StringSplitOptions.RemoveEmptyEntries);
            if(splitCodes.Length != replacements.Length+1) 
            {
                return new NotFoundResult();
            }
            GetPatternCodeByNameResponseDto response = new GetPatternCodeByNameResponseDto();
            response.PatternName = patternEntity.Name;
            response.ToInterpret = patternEntity.ToInterpret;
            int i = 0;
            for(; i<replacements.Length; i++ )
            {
                response.ListCodes.Add(new CodeFile { Content = splitCodes[i], FileName = "#" + replacements[i].Split(seperator, StringSplitOptions.RemoveEmptyEntries).ElementAt(0) + "#" });
            }
            response.ListCodes.Add(new CodeFile { Content = splitCodes[i], FileName = "Program" });
//Wywolanie w swagger
//            {
//                "patternID": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
//  "toInterpret": "#I1#FajnyInterfejs# #C1#Klasa# #AC1#AbstrakcyjnaKlasa# #C2#KlasaDekoratora# #C#NowyDekorator1# #C#NowyDekorator2#"
//}
            return new OkObjectResult(response);
        }

    }
}
