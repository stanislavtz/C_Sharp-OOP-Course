namespace Football_Team_Generator.Exceptions
{
    public class DataValidationExceptions
    {
        public static string InvalidNameException() => "A name should not be empty.";

        public static string InvalidStatException() => "{0} should be between 0 and 100.";

        public static string UnavailablePlayerException() => "Player {0} is not in {1} team.";
    }
}
