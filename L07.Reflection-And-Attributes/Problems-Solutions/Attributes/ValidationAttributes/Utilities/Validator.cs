using System.Linq;
using System.Reflection;

namespace ValidationAttributes.Utilities
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] propInfos = obj
                .GetType()
                .GetProperties();

            foreach (var property in propInfos)
            {
                var attributes = property
                    .GetCustomAttributes()
                    .Where(x => x is MyValidationAttribute)
                    .Cast<MyValidationAttribute>()
                    .ToArray();

                foreach (var attr in attributes)
                {
                    if (!attr.IsValid(property.GetValue(obj)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
