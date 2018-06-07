using System;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //TryBlockExample();
            CatchSingleException();
        }
        
        static void TryBlockExample()
        {
            string number = "twenty";
            try
            {
                int twenty = Convert.ToInt32(number);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"{number} is not an integer");
                Console.WriteLine(e.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("This is an exception for Null references");
            }
                
            catch (Exception ex)
            {
                Console.WriteLine("This is an exception");
            }

        }

        static void CatchSingleException()
        {
            int milesDriven, gallonsOfGas, mpg;

            try
            {
                Console.WriteLine("Enter Miles Driven: ");
                milesDriven = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter gallons of gas purchased: ");
                gallonsOfGas = Convert.ToInt32(Console.ReadLine());

                mpg = milesDriven / gallonsOfGas;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //throw;
            }
        }

    }
}
