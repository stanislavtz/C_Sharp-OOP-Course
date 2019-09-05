namespace Football_Team_Generator.Exceptions
{
    public class DataValidationExceptions
    {
        public static string InvalidNameException() => "A name should not be empty.";

        internal static string InvalidStatException() => "{0} should be between 0 and 100.";
    }
}
