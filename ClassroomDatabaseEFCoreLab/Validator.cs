namespace ClassroomDatabaseEFCoreLab
{
    public static class Validator
    {
        public static bool Continue()
        {
            Console.Write("Would you like to see another student? (y/n): ");
            string input = Console.ReadLine();
            if ("yes".Contains(input.ToLower()))
            {
                Console.Clear();
                return true;
            }
            return false;
        }
    }
}
