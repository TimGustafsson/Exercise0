using System;

namespace Exercise0
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepAlive = true;

            do
            {
                try
                {
                    Console.WriteLine("Run exercise by entering the number or -1 to exit.");

                    int selection = int.Parse(Console.ReadLine() ?? "0");

                    switch(selection)
                    {
                        case 1:
                            Exercise1();
                            break;
                        case 2:
                            Exercise2();
                            break;
                        case 3:
                            Exercise3();
                            break;
                        //more cases as you make progress doing the exercises

                        case -1:
                            keepAlive = false;
                            Console.WriteLine("Thank you for using the program.");
                            break;
                        default:
                            Console.WriteLine("Was not a valid selection)");
                            break;
                    }

                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                catch
                {
                    Console.WriteLine("Exception has occured.");
                }



            } while (keepAlive);
        }//main method

        static void Exercise1()
        {   
            Console.WriteLine("What is your name?");

            string userName = Console.ReadLine();

            Console.WriteLine("Hello " + userName + "! I'm glad to inform you that you are the test subject of my very first assignment!");

        }//Exercise1
            
        static void Exercise2()
        {
            DateTime dateTimeNow = DateTime.Now;

            Console.WriteLine("Todays date is " + dateTimeNow.ToShortDateString());

            DateTime dateTimeTomorrow = DateTime.Now.AddDays(1);

            Console.WriteLine("Tomorrows date is " + dateTimeTomorrow.ToShortDateString());

            DateTime dateTimeYesterday = DateTime.Now.AddDays(-1);

            Console.WriteLine("Yesterdays date was " + dateTimeYesterday.ToShortDateString());

        }//Exercise2

        static void Exercise3()
        {
            Console.Write("Enter your first name:");

            string userName = Console.ReadLine();

            Console.Write("Enter your last name:");

            string userLastname = Console.ReadLine();

        }//Exercise3

    } //class
}//namespace