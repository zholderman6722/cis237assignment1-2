//Zachery Holderman
//CIS 237
//Jan 25th, 2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        //No Variables
        //No Properties
        //No Constructors (but we could if we needed to)

        //******************************
        //Methods
        //******************************
        public int GetUserInput()
        {
            //Print out a menu
            this.PrintMenu();

            //Get the input from the user
            String input = Console.ReadLine();

            //While the input is not valid re-get the input
            while (input != "1" && input != "2" && input != "3" && input != "4")
            {
                //Print Error message
                this.PrintErrorMessage();

                //Re-print the menu
                this.PrintMenu();

                //Get the input from the console again.
                input = Console.ReadLine();
            }

            //At this point, I know the input is a valid number of either
            //a 1, 2 , 3 or 4.

            return Int32.Parse(input);
        }

        public void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }

        private void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Find a wine item by its ID.");
            Console.WriteLine("3. Add a new wine item to the list.");
            Console.WriteLine("Any other button to exit.");
        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("That is not a valid entry");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();
        }
        //method to search for an existing ID and if found print it out.
        public string LinearSearch(WineItem[] wineItem, string idSearch)
        {
            String foundIt = "";
            Console.WriteLine("What is the id number of the WineItem that you are looking for?");

            //Get input from user on ID they are searching for...
            idSearch = Console.ReadLine();
            Console.WriteLine("Attempting Search...");
            for (int i = 0; i < wineItem.Length; i++)
            {
                if (wineItem[i] != null)
                {
                    if (wineItem[i].id == idSearch)
                    {
                        foundIt = wineItem[i].ToString();
                    }
                    else
                    {
                        foundIt = "Could not find that item.";
                    }

                }
                else
                {
                    foundIt = "could not find that item";
                }
                
            }
            return foundIt;
        }
       
    }
}
