using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace T4.Generator.Basic
{
    /// <summary>
    /// Augments the generated CodeList class with fields for the individual templates.
    /// </summary>
    public partial class Generator
    {
        public IEnumerable<Item> Model;
        public string FilePath;
        public string ClassName;

        public string DateTimeFormatString = "yyyy-MM-ddTHH:mm:ss.fff";
        public string Namespace = "GeneratedNamespace";
    }
}
