using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleTextGame.Rooms;
using SimpleTextGame.Character;

namespace SimpleTextGame
{
    class GameCode // This class will store all of the game mechanics.
    {
        //Initialize Classes and Globals.
        public Player player = new Player();
        public string userInput = null;
        public string choice = null;
        
        public void play() // this function should store the main flow of the game.
        {
            player.level = 1;
            Room1 startingArea = new Room1();
        }
        
        
        public string chooseGender(string input) // This function takes user input and returns either male, female, or null.
        {
            if (input == "(M)")
            {
                return "(M)ale";
            }
            else if (input == "(F)")
            {
                return "(F)emale";
            }
            else if (input == "(T)")
            {
                return "(T)ransgender";
            }
            else if (input == "(H)") // helpFile
            {
                helpFile();
                return "chosehelp";
            }
            else
            {
                return null; // All other strings return null.
            }
        }

        public void helpFile() // This function calls the HelpFile class.
        {
            HelpFile help = new HelpFile();
            
        }

        public string testInput(string input) // This function acts as a general test of user input, in order to minimize if statements.
        {
            if (input == "H" || input == "h" || input == "Help" || input == "help") // helpFile
            {
                return "(H)";
            }
            else if (input == "I" || input == "i" || input == "Inspect" || input == "inspect")
            {
                return "(I)";
            }
            else if (input == "Y" || input == "y" || input == "Yes" || input == "yes")
            {
                return "(Y)";
            }
            else if (input == "N" || input == "n" || input == "No" || input == "no")
            {
                return "(N)";
            }
            else if (input == "M" || input == "m" || input == "Male" || input == "male")
            {
                return "(M)";
            }
            else if (input == "F" || input == "f" || input == "Female" || input == "female")
            {
                return "(F)";
            }
            else if (input == "T" || input == "t" || input == "Transgender" || input == "transgender")
            {
                return "(T)";
            }
            else if (input == "Table" || input == "table")
            {
                return "(T)";
            }
            else if (input == "D" || input == "d" || input == "Door" || input == "door")
            {
                return "(D)";
            }
            else if (input == "L" || input == "l" || input == "Left" || input == "left" || input == "Light" || input == "light")
            {
                return "(L)";
            }
            else
            {
                return null;
            }
        }

        public void resetUserInput() // This function resets both userInput and choice variables to null
        {
            userInput = null;
            choice = null;
        }

        public void invalidSelection()
        {
            Console.Clear();
            Console.WriteLine("You didn't make a valid selection.  Press enter to try again.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
