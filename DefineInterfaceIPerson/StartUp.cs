namespace PersonInfo
//Multiple Implementation and Define interface IPerson solutions
{
    public static class StartUp
    {
        private static string ReadRequiredLine(string errorMessage)
        {
            string? line = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(line))
            {
                throw new ArgumentException(errorMessage);
            }

            return line;
        }

        static void Main(string[] args)
        {
            try
            {
                var name = ReadRequiredLine("Invalid name");
                if (!int.TryParse(ReadRequiredLine("Invalid age"), out var age))
                {
                    throw new ArgumentException("Invalid age");
                }
                var birthdate = ReadRequiredLine("Invalid birthdate format");
                var id = ReadRequiredLine("Invalid id");


                IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
                IBirthable birthable = new Citizen(name, age, id, birthdate);
                Console.WriteLine(identifiable.Id);
                Console.WriteLine(birthable.Birthdate);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}