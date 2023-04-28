using System;

namespace cdevMod3
{
    class Program
    {
        enum DaysOfWeek : byte
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        enum Month : byte
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
        static void Main(string[] args)
        {
            Console.Write("Hello, World!\n\t\u0023 Your name is: ");
            string myName = Console.ReadLine();
            Console.Write("\t\u0023 Your age is: ");
            bool isAgeCorrect = byte.TryParse(Console.ReadLine(), out var age);
            //byte age = Convert.ToByte(Console.ReadLine());
            Console.Write("\t\u0023 Do you have pet? (y/n): ");
            bool pet = (Console.ReadLine() == "y") ? true : false;
            if (pet)
            {
                Console.Write("\t\tCute! Tell me It's name: ");
            }
            string petName = (pet) ? Console.ReadLine() : null;
            Console.Write("\t\u0023 Enter your favourite day of week (1-7): ");
            var favDayOfWeek = (DaysOfWeek)int.Parse(Console.ReadLine());
            Console.Write("\t\u0023 Enter your birth date:\n\t\t Day (1-31): ");
            var dayOfBirth = checked((byte)Convert.ToInt32(Console.ReadLine()));
            Console.Write("\t\t Month (1-12): ");
            var monthOfBirth = (Month)int.Parse(Console.ReadLine());
            Console.Write("\t\t Year: ");
            var yearOfBirth = checked(int.Parse(Console.ReadLine()));
            Console.Write($"\n\n Ok! Nice to meet you, {myName}!" + 
                          $"\n Now i know, that you're {age} and you ");
            if (pet)
            {
                Console.WriteLine($"have a pet (It's name - {petName}).");
            }
            else 
            {
                Console.WriteLine("dont' have any pet.");
            }
            Console.WriteLine($" I also know, that you're favourite day of week is {favDayOfWeek} " +
                $"and you were born on {dayOfBirth} {monthOfBirth}, {yearOfBirth}.");




        }
    }
} 
