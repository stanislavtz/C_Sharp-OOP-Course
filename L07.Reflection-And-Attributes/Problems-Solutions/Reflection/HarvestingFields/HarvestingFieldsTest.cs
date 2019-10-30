namespace P01_HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            Type type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == nameof(HarvestingFields));

            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);

            string input = Console.ReadLine();

            while (input != "HARVEST")
            {
                FieldInfo[] fieldInfosToPrint = null;

                switch (input)
                {
                    case "private":
                        fieldInfosToPrint = fieldInfos.Where(x => x.IsPrivate).ToArray();
                        break;
                    case "protected":
                        fieldInfosToPrint = fieldInfos.Where(x => x.IsFamily).ToArray();
                        break;
                    case "public":
                        fieldInfosToPrint = fieldInfos.Where(x => x.IsPublic).ToArray();
                        break;
                    case "all":
                        fieldInfosToPrint = fieldInfos;
                        break;
                }

                foreach (var field in fieldInfosToPrint)
                {
                    string accessModifier = field.Attributes.ToString().ToLower() == "family" ? "protected" : field.Attributes.ToString().ToLower();

                    Console.WriteLine($"{accessModifier} {field.FieldType.Name.ToString()} {field.Name}");
                }

                input = Console.ReadLine();
            }
        }
    }
}
