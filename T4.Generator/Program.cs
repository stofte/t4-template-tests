using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace T4.Generator
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gen = new Basic.Generator();
            gen.FilePath = @"codelist.xml";
            gen.ClassName = @"MyGeneratedCodeList";
            var dir = Environment.CurrentDirectory;
            gen.Model = Basic.Item.Map(XDocument.Load(gen.FilePath));
            var output = gen.TransformText();

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
