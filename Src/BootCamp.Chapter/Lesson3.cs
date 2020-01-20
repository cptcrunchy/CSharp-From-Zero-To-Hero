using System;

namespace BootCamp.Chapter
{
	public static class Lesson3
	{
        public static void Demo()
        {
            WelcomePrompt();
            do
            {
                PrompUserForStats();
                
            } while (PromptCalculateNewBMI());
        }

        public static bool PromptCalculateNewBMI()
        {
            Console.WriteLine("Do you wish to calculate another person? Y/N ");
            string response = Console.ReadLine();
            return response.ToLower().StartsWith("y");
        }

        public static void PrompUserForStats()
        {

            string name = PromptString("What is your name?");
            int age = PromptInteger("How old are you? If I may ask");
            float weight = PromptFloat("What is your weight? In Kilograms please.");
            float height = PromptFloat("How tall are you? In Meters please.");
            float calculatedBMI = CalculateBmi(weight, height);

            Console.WriteLine($"{name} is {age} years old, weight is {weight} kg with a height of {height} cm.");

            Console.WriteLine($"The calculated BMI  is: {calculatedBMI:F}");
           
        }

        private static void WelcomePrompt()
        {
            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|                              |");
            Console.WriteLine("|    Welcome to C# Bootcamp    |");
            Console.WriteLine("|        BMI Calculator        |");
            Console.WriteLine("|        Version 0.0.1         |");
            Console.WriteLine("|                              |");
            Console.WriteLine("+------------------------------+");
        }

        public static int PromptInteger(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }

        public static float PromptFloat(string message)
        {
            Console.WriteLine(message);
            return float.Parse(Console.ReadLine());
        }
       
        public static string PromptString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static float CalculateBmi(float weight, float height)
        {
            return weight / MathF.Pow(height, 2);
        }
    }
}
