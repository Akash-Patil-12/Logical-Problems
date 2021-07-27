using System;

namespace Logical_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            int choice;
            //constant
            const int FIBONACCI_SERIES = 1, PERFECT_NUMBER = 2, PRIME_NUMBER = 3, REVERSE_NUMBER = 4, CUPON_NO=5,DAY_OF_WEEK=8,TEMPERATURE = 9,PAYMENT=10,DECIMAL_BINARY=12,SQRT=11, VENDING_MACHING = 7;
            Console.WriteLine("Press 1 : Fibonacci Series");
            Console.WriteLine("Press 2 : Perfect Number");
            Console.WriteLine("Press 3 : Prime Number");
            Console.WriteLine("Press 4 : Reverse Number");
            Console.WriteLine("Press 5 : Cupon Number");
            Console.WriteLine("press 7 : Fewest notes to be returned for vending machine");
            Console.WriteLine("Press 8 : Day Of Week");
            Console.WriteLine("Press 9 : Temperature Conversion");
            Console.WriteLine("Press 10 : Monthly Payment");
            Console.WriteLine("Press 11 : Square Root");
            Console.WriteLine("Press 12 : Decimal to Binary Conversion");
            while (true)
            {
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case FIBONACCI_SERIES:
                        FibonacciSeries fibonacciSeries = new FibonacciSeries();
                        fibonacciSeries.Series();
                        break;
                    case PERFECT_NUMBER:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.CheckPerfectNumber();
                        break;
                    case PRIME_NUMBER:
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.CheckPrimeNumber();
                        break;
                    case REVERSE_NUMBER:
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.Reverse();
                        break;
                    case CUPON_NO:
                        CuponNo cuponNo = new CuponNo();
                        cuponNo.CheckNumber();
                        break;
                    case TEMPERATURE:
                        Temperature temperature = new Temperature();
                        temperature.Celsuis();
                        temperature.Fahrenheit();
                        break;
                    case VENDING_MACHING:
                        VendingMachine vendingMachine = new VendingMachine();
                        vendingMachine.Change(1050);
                        break;
                    case DAY_OF_WEEK:
                        Day day = new Day();
                        day.DayOfWeek();
                        break;
                    case PAYMENT:
                        Payment payment = new Payment();
                        payment.InputData();
                        break;
                    case DECIMAL_BINARY:
                        DecimalToBinary decimalToBinary = new DecimalToBinary();
                        decimalToBinary.Conversion();
                        break;
                    case SQRT:
                        SquareRoot squareRoot = new SquareRoot();
                        squareRoot.FindSquareRoot();
                        break;
                    default:
                        Console.WriteLine("Enter right option");
                        break;
                }
                Console.WriteLine("Press y to continue or press any other key to exit");
                Char operation =Char.ToLower(Convert.ToChar(Console.ReadLine()));
                if (operation != 'y')
                    break;
            }
            
        }
    }
}
