using System;
using System.Text;

namespace Wild_Farm.Exceptions
{
    public class InvalidNameLengthException : Exception
    {
        private readonly StringBuilder sb = new StringBuilder();

        public override string Message =>
            sb.AppendLine("The name should be minimum 2 simblos long!")
            .AppendLine("The name should contains only letters or diggits!")
            .ToString()
            .TrimEnd();
    }
}
