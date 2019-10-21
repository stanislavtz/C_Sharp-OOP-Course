namespace P02_BlackBoxInteger
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type type = typeof(BlackBoxInteger);

            var instance = Activator.CreateInstance(type, true);

            var methods = type.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            string input = Console.ReadLine();

            while (input != "END")
            {
                var inputArgs = input.Split("_");

                var methodName = inputArgs[0];
                var inputValue = int.Parse(inputArgs[1]);

                var currentMethod = methods.FirstOrDefault(x => x.Name == methodName);

                currentMethod.Invoke(instance, new object[] { inputValue });

                var field = type.GetField("innerValue", BindingFlags.NonPublic | BindingFlags.Instance);

                Console.WriteLine(field.GetValue(instance));

                input = Console.ReadLine();
            }
        }
    }
}
