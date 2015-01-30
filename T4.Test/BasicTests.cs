using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System.Xml.Linq;

using GeneratedNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Runtime.Serialization;

namespace GeneratedNamespace {

/// <summary>
/// Automatically generated from
/// C:\path
/// </summary>
[DataContract, Serializable]
public class Foo {

    private string _Identifier;

    [DataMember]
    public string Name { get; private set; }

    [DataMember]
    public string Description { get; private set; }

    [DataMember]
    public DateTime StartDate { get; private set; }

    [DataMember]
    public DateTime EndDate { get; private set; }

    [DataMember]
    public string Identifier 
    { 
        get
        {
            return _Identifier;
        }
        set
        {
            if (_Identifier != value) {
                _Identifier = value;
                SetProperties(this);
            }
        }
    }

    public Foo(string identifier) 
    {
        Identifier = identifier;
    }

    public Foo() { }

    public static implicit operator Foo(string identifier) 
    {
        return new Foo(identifier);
    }

    public static implicit operator string(Foo item) 
    {
        return item != null ? item.Identifier : null;
    }

    public override string ToString()
    {
        return Identifier;
    }

    /// <summary>
    /// 1 - A
    /// </summary>
    [NotMapped]
    public static readonly Foo A_1 = new Foo("1");

    /// <summary>
    /// 2 - B
    /// </summary>
    [NotMapped]
    public static readonly Foo B_2 = new Foo("2");

    /// <summary>
    /// 3 - C
    /// </summary>
    [NotMapped]
    public static readonly Foo C_3 = new Foo("3");


    [NotMapped]
    public static readonly IEnumerable<Foo> AllCodes = new Foo[]
    { 
        A_1,B_2,C_3 
    };

    [NotMapped]
    public static IEnumerable<Foo> AllActiveCodes
    {
        get
        {
            return AllCodes.Where(x => x.StartDate <= DateTime.Today && x.EndDate >= DateTime.Today);
        }
    }

    private static void SetProperties(Foo obj) 
    {
        switch (obj.Identifier) {
                case @"1": 
                    obj.Name = @"A";
                    obj.Description = @"A desc";
                    obj.StartDate = DateTime.ParseExact(@"2010-01-01T00:00:00.000", @"yyyy-MM-ddTHH:mm:ss.fff", CultureInfo.InvariantCulture);
                    obj.EndDate = DateTime.ParseExact(@"2100-01-01T00:00:00.000", @"yyyy-MM-ddTHH:mm:ss.fff", CultureInfo.InvariantCulture);
                    break;
                case @"2": 
                    obj.Name = @"B";
                    obj.Description = @"B desc";
                    obj.StartDate = DateTime.ParseExact(@"2010-01-01T00:00:00.000", @"yyyy-MM-ddTHH:mm:ss.fff", CultureInfo.InvariantCulture);
                    obj.EndDate = DateTime.ParseExact(@"2100-01-01T00:00:00.000", @"yyyy-MM-ddTHH:mm:ss.fff", CultureInfo.InvariantCulture);
                    break;
                case @"3": 
                    obj.Name = @"C";
                    obj.Description = @"C desc";
                    obj.StartDate = DateTime.ParseExact(@"2000-01-01T00:00:00.000", @"yyyy-MM-ddTHH:mm:ss.fff", CultureInfo.InvariantCulture);
                    obj.EndDate = DateTime.ParseExact(@"2001-01-01T00:00:00.000", @"yyyy-MM-ddTHH:mm:ss.fff", CultureInfo.InvariantCulture);
                    break;
                default: 
                    break;
        }
    }


} // class
} // namespace

namespace CodeList.Test
{
    [TestFixture]
    public class BasicTests
    {
        [Test]
        public void Type_Has_Item_Fields()
        {
            Assert.IsNotNull(Foo.A_1);
            Assert.IsNotNull(Foo.B_2);
        }

        [Test]
        public void ToString_Returns_Identifier()
        {
            Assert.IsTrue(Foo.A_1.ToString() == "1");
        }

        [Test]
        public void Can_Parse_DateTime_Strings()
        {
            var mid = new DateTime(2050, 1, 1);
            Assert.IsTrue(DateTime.Compare(Foo.A_1.StartDate, mid) < 0 && DateTime.Compare(mid, Foo.A_1.EndDate) < 0);
        }

        [Test]
        public void Can_New_Known_Instance()
        {
            var x =  new Foo("1");
            Assert.IsTrue(x.Name == "A");
        }

        [Test]
        public void Can_New_Unknown_Instances()
        {
            var x = new Foo("X");
            Assert.IsTrue(x.Identifier == "X");
        }

        [Test]
        public void Can_Initialize_By_Setting_Identifier()
        {
            var x = new Foo();
            x.Identifier = "1";
            Assert.IsTrue(x.Name == "A");
        }

        [Test]
        public void Can_Cast_String_To_Instance() 
        {
            var x =  (Foo) "1";
            Assert.IsTrue(x.Name == "A");
        }

        [Test]
        public void Can_Cast_Instance_To_String()
        {
            var x = (string) Foo.A_1;
            Assert.IsTrue(x == "1");
        }

        [Test]
        public void Can_Cast_Null_Instance_To_String()
        {
            Foo nully = null;
            var x = (string) nully;
            Assert.IsTrue(x == null);
        }

        [Test]
        public void Filters_Codes_By_DateTime() 
        {
            var x = Foo.AllActiveCodes.Count();
            Assert.IsTrue(x == 2);
        }


    }
}
