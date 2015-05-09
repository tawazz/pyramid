using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            Console.Write("**********************************************************\nWelcome to the pyramid creation Program\n**********************************************************");
            try
            {
                do
                {
                    dispMenu();
                    option = Convert.ToInt32(Console.ReadLine());
                    doOption(option);
                } while (option != -99);
            }catch (FormatException) { 
                Console.WriteLine("GOOD BYE :)");
            }

        }

        // displays the menus onscreen
        static void dispMenu()
        {
            Console.Write("\nPress 1 To enter the Height of the program\nPress any Character or -99 to quit\n**********************************************************\n");
        }

        //exucutes the user options

        static void doOption(int option)
        {
            switch (option)
            { 
                    
                case 1 :
                    pyramid();
                    break;
                case -99 :
                    break;
                default :
                    Console.WriteLine("Enter valid option");
                    break;
            }
        }

        //creates the pyramid
        static void pyramid()
        {
            int userInput, i;
            int row = -1;

            Console.WriteLine("Enter the height of the pyramid");
            try
            {
                userInput = Convert.ToInt32(Console.ReadLine());

                while (userInput < 1)
                {
                    Console.WriteLine("Enter the height of the pyramid, NOTE HEIGHT HAS TO BE GREATER THAN 0");
                    userInput = Convert.ToInt32(Console.ReadLine());
                }

                for (i = 1; i <= userInput; i++)
                {
                    int rowCounter = 1;
                    int space = userInput - i;
                    int stars = row;
                    row = stars + 2;

                    for (rowCounter = 1; rowCounter <= row; rowCounter++)
                    {
                        while (space > 0)
                        {
                            Console.Write(" ");
                            //cout<<space;
                            space--;
                        }
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
                Console.Write("\n**********************************************************\n");


            }
            catch (FormatException) { Console.WriteLine("AN ERROR OCCURED : USER NUMBERS ONLY"); }
        }

    }
}
