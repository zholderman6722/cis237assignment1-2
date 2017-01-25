//Zachery Holderman
//CIS237
//Jan 25th, 2017
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        private int length;
        private WineItem[] wineItems = new WineItem[10000];

        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = Length;
            }
        }
        //public void addNewItem(int counter, wineItem)
        //{
        //    string id = "";
        //    string pack ="";
        //    string description ="";
        //    Console.WriteLine("what is the id number of the wine that you would like to add?");
        //    id = Console.ReadLine();
        //    Console.WriteLine("How many are in a pack of the wine that you would like to add?");
        //    pack = Console.ReadLine();
        //    Console.WriteLine("What is the description of this wine that you would like to add?");
        //    description = Console.ReadLine();
        //    //Need to figure out a way to use index effectively to find end and keep adding new items.
        //    //wineItems[counter++] = new WineItem(id, description, pack);
        //}
    }
}
