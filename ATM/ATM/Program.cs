using System;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace ATM
{
    class Program
    {

        
        static void Main(string[] args)
        {

            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }
            
        }
      
        public static bool MainMenu()
        {
          
            Console.Clear();
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) View Balance");
            Console.WriteLine("2) Withdraw Funds");
            Console.WriteLine("3) Deposit Funds");
            Console.WriteLine("4) Exit");
                string result = Console.ReadLine();
            if (result == "1")
            {
                Balance();
                return true;

            }
            else if (result == "2")
            {
                Withdraw();
                return true;
            }
            else if (result == "3")
            {
                Deposit();
                return true;
            }
            else if (result == "4")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
     
        public static void Balance()
        {
            double amt = 1200.25;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(amt.ToString("C"));
            Console.WriteLine("press any key to go to the menu");
            Console.ReadKey();
        }
        public static void Withdraw()
        {

        }
        public static void Deposit()
        {

        }
    }
}
