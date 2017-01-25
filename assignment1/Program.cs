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
    class Program
    {
        static void Main(string[] args)
        {
            //Make a new instance of the User Interface Class
            UserInterface ui = new UserInterface();

            //Make an array large enough to hold all the WineItems
            WineItem[] wineItems = new WineItem[10000];

            Console.WriteLine("Loading Csv File...");
            //Make the string for the path to the csv file while allowing the user to choose
            string pathToCsv = "../../../datafiles/WineList.csv";
            
            
            //Instanciate the csvProcessor
            CSVProcessor csvProcessor = new CSVProcessor();

            //Call the ImportCSV method sending over the path and
            //the array to store the read in records to.
            csvProcessor.ImportCSV(pathToCsv, wineItems);

            //Get some input from the User
            int choice = ui.GetUserInput();
            //While choice != 5 keep looping
            while (choice != 5)
            {
                
                if (choice == 1)
                {

                    //Create a string to concat the output
                    string allOutput = "";

                    //Loop through all the wine Items to concat them together.
                    foreach (WineItem wine in wineItems)
                    {
                        if (wine != null)
                        {
                            allOutput += wine.ToString() +
                                        Environment.NewLine;
                        }
                    }
                    //Once the concat is done, have the UI class print out the result
                    ui.Output(allOutput);
                }

                //If the choice they made is 2, search for item id provided by user and if found print it out
                if (choice == 2)
                {
                    string foundIt = "";
                    foundIt = ui.LinearSearch(wineItems, foundIt);
                    Console.WriteLine(foundIt);
                }
                //If the choice they made is 3, allow user to add a new wine item to the list
                if (choice == 3)
                {
                    //WineItemCollection;
                    
                }
                if(choice == 4)
                {
                    Environment.Exit(0);
                }
                
                //Get the next choice from the user.
                choice = ui.GetUserInput();
            } 
        }
    }
}
