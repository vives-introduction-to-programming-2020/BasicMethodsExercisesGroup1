using System;

namespace BasicMethodsExercisesGroup1
{
    class Program
    {
        public static string GenerateStudentId(string prefix) // prefix = "s" or "r"
        {
            Random generator = new Random();
            int studentNumber = generator.Next(100000000);

            string result = "" + studentNumber;

            result = result.PadLeft(8, '0');

            return prefix + result;
        }

        public static string GenerateStudentEmail(string firstname,
            string lastname)
        {
            // 2 problems:
            // - upper cased letters => method .ToLower()
            // - white space => .Replace() method

            firstname = firstname.Replace(" ", "");
            lastname = lastname.Replace(" ", "");

            return firstname.ToLower()
                + "." + lastname.ToLower() + "@student.vives.be";
        }

        static void Main(string[] args)
        {
            // 1) Genereer een s/r-nummer voor studenten
            // s12341234 of r01234567
            string studentId = GenerateStudentId("s");
            Console.WriteLine(studentId);

            // 2) Genereer een email adres voor de student
            // op basis van zijn/haar voornaam en achternaam
            Console.WriteLine("Please enter firstname: ");
            string firstname = Console.ReadLine();

            Console.WriteLine("Please enter lastname: ");
            string lastname = Console.ReadLine();

            string studentEmail = GenerateStudentEmail(firstname, lastname);
            Console.WriteLine("Your email: " + studentEmail);

        }
    }
}
