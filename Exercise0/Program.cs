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
            Console.WriteLine("replace this with exercises");
        }

    } //class
}//namespace