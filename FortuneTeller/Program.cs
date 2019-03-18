using System;

namespace NextBirthday
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your birthdate: ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            string birthDayOfWeek = NextBirthdayDay(birthDate);
            Console.WriteLine(birthDayOfWeek);
            Console.ReadLine();
        }

        // TODO: Create a method that takes the date someone was born and returns the name of the day on their next birthday.
        public static string NextBirthdayDay(DateTime birthDate)
        {
            int birthMonth = birthDate.Month;
            int birthDay = birthDate.Day;
            DateTime birthdayThisYear = DateTime.Parse(birthMonth + "/" + birthDay + "/2019");

            DateTime nextBirthday;
            //If next birthdate will be this year
            if (birthdayThisYear.CompareTo(DateTime.Today) > 0)
            {
                nextBirthday = DateTime.Parse(birthMonth + "/" + birthDay + "/2019");
            }
            else
            {
                //If next birthdate will be next year
                nextBirthday = DateTime.Parse(birthMonth + "/" + birthDay + "/2020");
            }
            return nextBirthday.DayOfWeek.ToString();
        }
    }
}