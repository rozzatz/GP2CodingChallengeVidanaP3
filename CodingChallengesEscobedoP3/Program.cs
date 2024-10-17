using System;
using System.Security.Cryptography.X509Certificates;

class Challenges
{
    public static void Main(string[] args)
    {
        Console.WriteLine("The Screams of the Broken are growing Louder YOU WILL NOT LEAVE YOU WILL NOT LEAVE YOU WILL NOT LEAVE  also you can pick one of the functions now");

       Console.WriteLine("we are gonna use a number adder its called SUM or something input 2 numbers fo me to add or dont its whatever.");

        var number1 = Console.ReadLine();
        int number1int = int.Parse(number1);

        Console.WriteLine("oh you actaully picked a number well you might as well pick anotherone");

        var number2 = Console.ReadLine();
        int number2int = int.Parse(number2);

        Console.WriteLine("so if you didn't know " + number1 + " and " +number2 + " is actaully " + Sum(number1int, number2int));

        Console.WriteLine("oh hey you're back um i learned a new trick for you if you just typed a number and press eneter i could turn that quote unquote minute into seconds yayy so go ahead and do that for me real quick");

        var number3 = Console.ReadLine();
        int number3int = int.Parse(number3);

        Console.WriteLine("ok so " + number3 + " minutes is " + Multiply(number3int) + " seconds yayyy");

        Console.WriteLine("we are undergoing some um things right now and we will fix this proscess so but for now type a number hit enter and i will add 1");

        var number4 = Console.ReadLine();
        int number4int = int.Parse(number4);

        Console.WriteLine(" ok so  " + number4 + " + 1 is " + Add(number4int) + " so yeah ");

        Console.WriteLine("ok so we still havent steamlined this so erm we are going to calculate circut power given a volatge and a current so type in a value for voltage hit enter then do the same for current");

        var voltage = Console.ReadLine();
        int voltageint = int.Parse(voltage);

        Console.WriteLine(" OK WE HAVE THE V-V-VOLTAGE now type a number for the current");

        var current = Console.ReadLine();
        int currentint = int.Parse(current);

        Console.WriteLine(" ok ok so given the VOLTAGE of " +voltageint+ " and the current of  " +currentint+ " we can calculate the circut power which is  " +Circut(voltageint,currentint));


        Console.WriteLine("so umm about that menu the guys hasnt ermm you know done it but if you tell me how old you are in years i can tell you how old ytou are in days not accounting for leap years.");

       var ageYrs = Console.ReadLine();
        int ageint = int.Parse(ageYrs);

        Console.WriteLine(" so if you are " +  ageYrs + " you would be not accounting for months that have passed aafter your birthdday " + Aged(ageint) + " days old");

        Console.WriteLine("you like geometry right? right? give me athe base and the height of a triangle and i will calculate the area, lets start with the base  ");

        var Base = Console.ReadLine();
        float basefloat = float.Parse(Base);

        Console.WriteLine("ok so now give the height of the triangle");

        var height = Console.ReadLine();
        float heightfloat = float.Parse(height);

        Console.WriteLine("ok so a triangle with a base of " + basefloat + "and a height of " +  heightfloat + "the area of this triangle will be "+ areat(basefloat, heightfloat));

        Console.WriteLine("ok so i will tell you if a number you typed is positive or negative");

        var Nummmba3 = Console.ReadLine();
        int Nummba3int = int.Parse(Nummmba3);

       Console.WriteLine(" now now now the fact that your number is negative is " + neg(Nummba3int) + " yayy");
    }

    public static int Sum(int number1, int number2)
   {
       return number1 + number2;
    }


    private static int Multiply(int number1)
    {
        return number1 * 60;
    }

    private static int Add(int number1)
    {
        return number1 +1;
    }

    private static int Circut(int number1, int number2)
    {
        return (number1 * number2);
    }

    private static int Aged(int number1)
    {
        return number1 * 365;
    }

    private static float areat(float number1, float number2)
    {
        return (number1 * number2)/2;

    }

   private static bool neg(int number1)
    {
        return number1 <= 0;
    }




}
