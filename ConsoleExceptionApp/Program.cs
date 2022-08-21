using System;

//secondary class
    public class Program
    {
    //created fields
        int num1;
        int num2;

    //constructor for initialization of fields
        public Program(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

    //method for division
        public static void Division(int num1, int num2)
        {
        //try statement to catch errors
            try
            {
                int result = num1 / num2;
                Console.WriteLine($"{num1}/{num2} = {result}");

            }catch(DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by zero");
            }
        }
    }
    //main class
    public static class main
    {
    //main method
        public static void Main(String[] args)
        {
        Console.WriteLine("Enter first number:");
        int num1 =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number");
        int num2 =Convert.ToInt32(Console.ReadLine());
        //calling method

        Program.Division(num1, num2);
        }
    }

