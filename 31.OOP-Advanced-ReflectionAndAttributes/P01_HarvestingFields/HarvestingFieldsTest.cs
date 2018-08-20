 namespace P01_HarvestingFields
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {

            Type type = Type.GetType("P01_HarvestingFields.HarvestingFields");

            FieldInfo[] fieldInfos = type.GetFields(
            BindingFlags.NonPublic| BindingFlags.Public | BindingFlags.Instance);

            IEnumerable<FieldInfo> fields = null;

            string input;
            while ((input = Console.ReadLine()) != "HARVEST")
            {
                switch (input)
                {
                    case "private":
                        fields = fieldInfos.Where(f => f.IsPrivate);
                        break;
                    case "protected":
                        fields = fieldInfos.Where(f => f.IsFamily);
                        break;
                    case "public":
                        fields = fieldInfos.Where(f => f.IsPublic);
                        break;
                    case "all":
                        fields = fieldInfos;
                        break;
                }



                foreach (var field in fields)
                {
                    var fiedAttribute = field.Attributes.ToString().ToLower() == "family" 
                             ? "protected" : field.Attributes.ToString().ToLower();

                    Console.WriteLine($"{fiedAttribute} {field.FieldType.Name} {field.Name}");
                }
            }
        }
    }
}
