using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace T4.Generator.Basic
{
    /// <summary>
    /// Codelist record
    /// </summary>
    public class Item
    {
        public string Identifier;
        public string Name;
        public string Description;
        public string Startdate;
        public string Enddate;
        public string FieldName;

        public static IEnumerable<Item> Map(XDocument doc)
        {
            var items = doc.Descendants("Item").Select(x => new Item { 
                Identifier = x.Element("Identifier").Value,
                Name = x.Element("Name").Value,
                Description = x.Element("Description").Value,
                Startdate = x.Element("Startdate").Value,
                Enddate = x.Element("Enddate").Value,

                FieldName = Helpers.SanitizeName(x.Element("Name").Value, x.Element("Identifier").Value)
            });

            return items;
        }
    }
}
