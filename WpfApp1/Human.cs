using System.ComponentModel;
using System.Globalization;

namespace WpfApp1
{
    [TypeConverterAttribute(typeof(NameToHumanTypeConverter))]
    public class Human
    {
        public string Name { set; get; }
        public Human Child { set; get; }
    }

    public class NameToHumanTypeConverter : TypeConverter
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            var name = value.ToString();
            var child = new Human {Name = name};
            return child;
        }
    }
}