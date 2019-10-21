namespace P02_BlackBoxInteger
{
    using System;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type type = typeof(BlackBoxInteger);

            object instance = Activator.CreateInstance(type, true);

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] inputArgs = input.Split("_");

                string methodName = inputArgs[0];
                int inputValue = int.Parse(inputArgs[1]);

                MethodInfo currentMethod = type.GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Instance);

                currentMethod.Invoke(instance, new object[] { inputValue });

                FieldInfo field = type.GetField("innerValue", BindingFlags.NonPublic | BindingFlags.Instance);

                Console.WriteLine(field.GetValue(instance));

                input = Console.ReadLine();
            }
        }
    }
}
