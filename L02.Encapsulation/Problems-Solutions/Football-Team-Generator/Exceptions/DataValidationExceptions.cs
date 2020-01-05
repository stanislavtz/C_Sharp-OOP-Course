namespace Football_Team_Generator.Exceptions
{
    public static class DataValidationExceptions
    {
        public static string InvalidNameException() => "A name should not be empty.";

        public static string InvalidStatException() => "{0} should be between {1} and {2}.";

        public static string UnavailablePlayerException() => "Player {0} is not in {1} team.";

        public static string UnavailableTeamException() => "Team {0} does not exist.";
    }
}
