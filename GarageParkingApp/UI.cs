using System;
using System.Collections.Generic;
using System.Text;

namespace GarageParkingApp
{
    public class UI
    {
        public static void InitializeUI()
        {
            // Fråga användaren hur stort Garaget ska vara och sätt sedan storleken på arraryen.

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                                    + "\n1. Examine a List"
                                    + "\n2. Examine a Queue"
                                    + "\n3. Examine a Stack"
                                    + "\n4. CheckParanthesis"
                                    + "\n0. Exit the application");
                char input = ' '; // Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; // Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) // If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        //ExamineList();
                        break;
                    case '2':
                        //ExamineQueue();
                        break;
                    case '3':
                        //ExamineStack();
                        break;
                    case '4':
                        //CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }

        }
    }
}
