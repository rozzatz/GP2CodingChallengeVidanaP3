using System;
using System.Security.Cryptography.X509Certificates;

class Challenges
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Whats up bitch maintinence is complete");
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nplease choose a function to perform:");
            Console.WriteLine("1. this one adds two numbers");
            Console.WriteLine("2. this one converts minutes to seconds");
            Console.WriteLine("3. This one adds 1 to a number of your choosing");
            Console.WriteLine("4. this one will calculate circuit power");
            Console.WriteLine("5. this one turns your age in years into your age in days");
            Console.WriteLine("6. this one will calculate the area of a triangle");
            Console.WriteLine("7. and this one will check if a number you type is positive or negative");
            Console.WriteLine("8. this one will check if two numbers added together is less than or greater than 100");
            Console.WriteLine("9. this a one will check if two integers are the same");
            Console.WriteLine("10. type in a prompt and the word something will be added before your prompt");
            Console.WriteLine("12. conert hours to seconds");
            Console.WriteLine("14. add edabit to the end of your prompt");
            Console.WriteLine("15. something or another");
            Console.WriteLine("16.basketball scores");
            Console.WriteLine("17. rectangle area finder");
            Console.WriteLine("18.introduce yourself");
            Console.WriteLine("19. farming simulator");
            Console.WriteLine("20. calender");
            Console.WriteLine("0. and press 0 to quit");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PerformSum();
                    break;
                case "2":
                    ConvertMinutesToSeconds();
                    break;
                case "3":
                    AddOneToNumber();
                    break;
                case "4":
                    CalculateCircuitPower();
                    break;
                case "5":
                    CalculateAgeInDays();
                    break;
                case "6":
                    CalculateTriangleArea();
                    break;
                case "7":
                    CheckIfNumberIsPositiveOrNegative();
                    break;
                case "8":
                    SumTotal100();
                    break;
                case "9":
                    CheckIf();
                    break;
                case "10":
                    StringChee();
                    break;
                case "12":
                    hours2secs();
                    break;
                case "14":
                    CheeString();
                    break;
                case "15":
                    doubleAmpersand();
                    break;
                case "16":
                    basketball();
                    break;
                case "17":
                    areafinder();
                    break;
                case "18":
                    StringChees();
                    break;
                case "19":
                    farmy();
                    break;
                case "20":
                    month();
                    break;
                case "0":
                    running = false;
                    Console.WriteLine("alright pal goodbye for now next time we will have another function");
                    break;
                default:
                    Console.WriteLine("yikes! the character you inputed is invalid");
                    break;
            }
        }
    }

    private static void PerformSum()
    {

        int number1 = GetIntegerInput("Please enter the first number:");
        int number2 = GetIntegerInput("Please enter the second number:");
        Console.WriteLine($"The sum of {number1} and {number2} is {Sum(number1, number2)}.");
    }

    private static void ConvertMinutesToSeconds()
    {
        int minutes = GetIntegerInput("Please enter the number of minutes to convert to seconds:");
        Console.WriteLine($"{minutes} minutes is {Multiply(minutes)} seconds.");
    }

    private static void AddOneToNumber()
    {
        int number = GetIntegerInput("Please enter a number to which I will add 1:");
        Console.WriteLine($"{number} + 1 is {Add(number)}.");
    }

    private static void CalculateCircuitPower()
    {
        int voltage = GetIntegerInput("Please enter the voltage:");
        int current = GetIntegerInput("Please enter the current:");
        Console.WriteLine($"The circuit power is {Circuit(voltage, current)} watts.");
    }

    private static void CalculateAgeInDays()
    {
        int ageInYears = GetIntegerInput("Please enter your age in years:");
        Console.WriteLine($"You are approximately {Aged(ageInYears)} days old.");
    }

    private static void CalculateTriangleArea()
    {
        float baseLength = GetFloatInput("Please enter the base of the triangle:");
        float height = GetFloatInput("Please enter the height of the triangle:");
        Console.WriteLine($"The area of the triangle is {CalculateArea(baseLength, height)}.");
    }

    private static void CheckIfNumberIsPositiveOrNegative()
    {
        int number = GetIntegerInput("Please enter a number to check if it's positive or negative:");
        Console.WriteLine($"The number is {(IsNegative(number) ? "negative" : "positive")}.");
    }

    private static void SumTotal100()
    {
        Console.WriteLine($"ok so youre gonna give me two numbers and i will check if the sum total is less than 100");
        int number1 = GetIntegerInput("Please enter the first number:");
        int number2 = GetIntegerInput("Please enter the second number:");
        Console.WriteLine($"The number is {(AddnCheck(number1, number2) ? "less than or equal to 100" : "greater than or equal to 100")}.");
    }
    private static void CheckIf()
    {
        Console.WriteLine($"im gonna check if two numbers you type are equal to eacxhother");
        int number1 = GetIntegerInput("Please enter the first number:");
        int number2 = GetIntegerInput("Please enter the second number:");
        Console.WriteLine($"These numbers are {(Checker(number1, number2) ? "equal;" : "not equal")}");

    }

    private static void StringChee()
    {
        Console.WriteLine("Please enter something: ");
        string userInput = Console.ReadLine();
        string result = JoinSomething(userInput);
        Console.WriteLine(result);

    }

    private static void hours2secs()
    {
        Console.WriteLine($"you will input the hours and i will return the seconds");
        int number1 = GetIntegerInput("Please enter the first number:");
        Console.WriteLine($"{number1} hours is {Hours2Secs(number1)} seconds.");
    }

    private static void CheeString()
    {
        Console.WriteLine("Please enter something: ");
        string userInput = Console.ReadLine();
        string result = JoinEdabit(userInput);
        Console.WriteLine(result);

    }

    private static void doubleAmpersand()
    {
        // Prompt the user to input a string
        Console.WriteLine("Enter a boolean value (true or false):");

        // Read user input as a string
        string userInput = Console.ReadLine();

        // Try to convert the user input to a boolean
        bool result;
        bool success = bool.TryParse(userInput, out result);

        // Check if conversion was successful
        if (success)
        {
            Console.WriteLine("You entered a valid boolean value: " + result);

            // Prompt the user to input a string
            Console.WriteLine("Enter a boolean value (true or false):");

            // Read user input as a string
            string userInput2 = Console.ReadLine();

            // Try to convert the user input to a boolean
            bool result2;
            bool success2 = bool.TryParse(userInput2, out result2);

            if (success2)
            {
                Console.WriteLine("You entered a valid boolean value: " + result2);
                Console.WriteLine("after calculating i have come to the decision that  " + result + result2 + " is " + checkered(result, result2));

            }
            else
            {
                Console.WriteLine("Invalid input! Please enter 'true' or 'false'.");
                doubleAmpersand();
            }

        }
        else
        {
            Console.WriteLine("Invalid input! Please enter 'true' or 'false'.");
            doubleAmpersand();

        }
    }

    private static void basketball()

        {
        Console.WriteLine($"youre gonna enter the numbers of 2 pointers and the number of 3 pointers");
        int number1 = GetIntegerInput("Please enter the amount of 2 pointers:");
        int number2 = GetIntegerInput("Please enter the amount of 3 pointers:");
        Console.WriteLine($"points("+number1 + "," + number2 + ") ➞ " + smasket(number1,number2));
    }

    private static void areafinder()

    {
        Console.WriteLine($"youre gonna enter the width and length of a rectangle and i will calculate the area");
        int voltage = GetIntegerInput("Please enter the width of the rectangle");
        int current = GetIntegerInput("Please enter the length ofd the rectangle");
        Console.WriteLine($"a rectangle with a width of " + voltage + " and a length of " + current +  "will have an area of " + Circuit(voltage, current));
    }

    private static void StringChees()
    {
        Console.WriteLine("Please enter your name: ");
        string userInput = Console.ReadLine();
        string result = JoinHello(userInput);
        Console.WriteLine(result);
    }

    private static void farmy()

    {
        Console.WriteLine($"youre gonna tell me how many animals of each kind and i will count up their legs");
        int number1 = GetIntegerInput("Please enter the amount of chickens:");
        int number2 = GetIntegerInput("Please enter the amount of cows:");
        int number3 = GetIntegerInput("Please enter the amount of pigs:");
        Console.WriteLine($"" + number1 + "chicken(s) + " + number2 + "cow(s) " + number3 + "pig(s) total up to " + sammy(number1, number2, number3) + " LEGS ");
    }

    private static void month()

    {
        int number1 = GetIntegerInput("enter a number 1-12");

        if (number1 == 1)
        {
             Console.WriteLine("january");
        }
        else if (number1 == 2)
        {
             Console.WriteLine("febuary");
        }
        else if (number1 == 3)
        {
             Console.WriteLine("march");
        }
        else if (number1 == 4)
        {
             Console.WriteLine("april");
        }
        else if (number1 == 5)
        {
            ;
             Console.WriteLine("may");
        }
        else if (number1 == 6)
        {
             Console.WriteLine("june");
        }
        else if (number1 == 7)
        {
             Console.WriteLine("july");
        }
        else if (number1 == 8)
        {
             Console.WriteLine("august");
        }
        else if (number1 == 9)
        {
             Console.WriteLine("september");
        }
        else if (number1 == 10)
        {
             Console.WriteLine("october");
        }
        else if (number1 == 11)
        {
             Console.WriteLine("november");
        }
        else if (number1 == 12)
        {
             Console.WriteLine("december");
        }
        else
        {
            month();

        }
    }




        private static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }
     

    private static int Multiply(int minutes)
    {
        return minutes * 60;
    }

    private static int Add(int number)
    {
        return number + 1;
    }

    private static int Circuit(int voltage, int current)
    {
        return voltage * current;
    }

    private static int Aged(int years)
    {
        return years * 365;
    }

    private static float CalculateArea(float baseLength, float height)
    {
        return (baseLength * height) / 2;
    }

    private static bool IsNegative(int number)
    {
        return number < 0;
    }

    private static bool AddnCheck(int number1, int number2)
    {
        return number1 + number2 < 100;
    }

    private static bool Checker(int number1, int number2)
    {
        return number1 == number2;
    }
    private static int GetIntegerInput(string prompt)
    {
        Console.WriteLine(prompt);
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int result))
                return result;
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }

    static string JoinSomething(string a)
    {
        return "something " + a;
    }

static string JoinHello(string a)
{
    return "Hello " + a;
}

private static float GetFloatInput(string prompt)
    {
        Console.WriteLine(prompt);
        while (true)
        {
            if (float.TryParse(Console.ReadLine(), out float result))
                return result;
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    private static int Hours2Secs(int number1)
    {
        return number1 * 60 * 60;
    }


    static string JoinEdabit(string a)
    {
        return a + "edabit " ;
    }

    private static bool checkered(bool result, bool result2)
    {
        return result;

    }

    private static int smasket(int number1, int number2)
    {
        return number1 * 2 + number2 *3;
    }

    private static int sammy(int number1, int number2, int number3)
    {
        return number1 * 2 + number2 * 4 + number3 * 4;
    }


}
