using System;
using static System.Console;
using System.Collections.Generic;

namespace RosterList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * This program searches to see if a name already exists using BinarySearch
             * and if it doesn't enters the name into the List, otherwise it promps the
             * user for a new name
             */

            List<string> rosterListy = new List<string>() { "Alice", "Alex", "Ben", "Alisha", "Harry", "Chris", "Luke" };
          

            rosterListy.Sort();//Sorts the array

            WriteLine("Enter an Name:");
            string name = ReadLine();


            while (name != "EXIT") //if user enters EXIT it stops the loop
            {
                int post = rosterListy.BinarySearch(name); //searches for the name

                if (post >= 0)
                {
                    WriteLine("{0} is already in use, choose another", name);
                }
                else
                {
                    rosterListy.Add(name);
                    rosterListy.Sort();
                }

                WriteLine("Enter an Name:");
                name = ReadLine();

            }

            WriteLine("");//makes an empty new line

            //prints out the roster

            for(int x = 0; x < rosterListy.Count; ++x)
            {
                WriteLine(rosterListy[x]);
            }
        }
    }
}
