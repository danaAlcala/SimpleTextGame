using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTextGame.Rooms
{
    class Room1 : Room
    {
        
        public Room1() // Room1 will be 12x12
        {
            GameCode game = new GameCode();
            length = 12;
            width = 12;
            map = new int[length, width];
            size = map.Length;

            Console.WriteLine(@"You awake with a raging headache.
The room is dark, and for some reason you can't remember anything.
You look down and see...
");
            while (game.player.gender == null) // initially, gender is null. If the choice is invalid, it should remain null.
            {
                Console.WriteLine(@"(Choose your gender)
* I am a (M)ale
* I am a (F)emale
* I am a (T)ransgender

((H)elp is available.)");
                game.userInput = Console.ReadLine(); // Take input from the user and store it.
                game.player.gender = game.chooseGender(game.testInput(game.userInput)); /*
                   testInput converts the userInput into something usable by the chooseGender
                   function.  chooseGender then narrows down the available choices and returns
                   null if the input isn't a valid choice.*/

                if (game.player.gender == null) // This resets the chooseGender function and reverts to asking for input again if the choice is invalid.
                {
                    game.invalidSelection();
                }
                else if (game.player.gender == "chosehelp") // This is here so the player isn't told that choosing help was an invalid selection.
                {
                    game.player.gender = null;
                }
            }

            game.resetUserInput(); // resets both userInput and choice variables

            Console.Clear();
            Console.WriteLine("It seems as though you are a " + game.player.gender + ".");
            Console.Write("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(@"You're clothed in tattered rags, and you're ravenous.
Your body aches, as you realize you were unconscious on the cold, stone floor.");

            while (game.choice == null) // This makes sure that the loop only runs before the user makes a choice.
            {
                Console.Write("\n\nWould you like to (I)nspect your surroundings?");
                game.userInput = Console.ReadLine();
                game.choice = game.testInput(game.userInput);
                if (game.choice == "(H)")
                {
                    Console.Clear();
                    game.helpFile();
                    game.choice = null;
                }
                else if (game.choice == "(I)" || game.choice == "(Y)")
                {
                    Console.Clear();
                    Console.WriteLine(@"

It's still dark, but you can make out a door on the far end. A
dim light escapes the room on the other side through the seams
of the door, slightly illuminating a table to your right.  On
the table, you see a lantern amongst other like-sized items
that are impossible to identify in this light.

It's rather difficult to see what resides to your left, but you
can kind of make out a couple large items that might be
furniture of some sort.");
                }
                else if (game.choice == "(N)")
                {
                    Console.Clear();
                    Console.WriteLine(@"

You really should (I)nspect your surroundings.

Press enter to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    game.resetUserInput();
                }
                else
                {
                    game.invalidSelection();
                    game.resetUserInput();
                }
            }

            game.resetUserInput();
            while (game.choice == null)
            {
                Console.WriteLine(@"
(What would you like to do?)

* Approach the (D)oor and try to open it.
* Take a closer look at the (T)able.
* See if you can feel-around and find out what is to your
  (L)eft.
                        
((H)elp is available.)");
                game.userInput = Console.ReadLine();
                game.choice = game.testInput(game.userInput);
                if (game.choice == "(H)")
                {
                    HelpFile help = new HelpFile();
                    game.choice = null;
                }
                else if (game.choice == "(T)")
                {
                    Console.Clear();
                    Console.WriteLine(@"You found a match and a bottle of phosphorus sitting right
next to the lantern.  If you dip a match into the bottle of phosphorus,
you might be able to light the lantern.

Would you like to (L)ight the lantern?

((H)elp is available.)");
                    game.userInput = Console.ReadLine();
                    game.choice = game.testInput(game.userInput);
                    if (game.choice == "(H)")
                    {
                        HelpFile help = new HelpFile();
                        game.choice = null;
                    }
                    else if (game.choice == "(L)" || game.choice == "(Y)")
                    {
                        Console.Clear();
                        Console.WriteLine(@"You grab a match out of the box and dip it into the
bottle of phosphorus.  You quickly remove it from the bottle as a
blinding flash illuminates the room, and then becomes a calm flame
originating from the match.  Using the match, you light the lantern
and adjust it to full-brightness.

You can now see the room in its entirety.

On the table holding the lantern, you see a thick tome.  Something
about it looks very familiar.

To the left, you can see a weapon rack containing a wooden sword,
a bow, and a quiver of arrows.  These items also look vaguely
familiar.

Next to the weapon rack is a small desk with a closed drawer.  You can
see a keyhole above the drawer's handle.");
                    }
                    else if (game.choice == "(N)")
                    {
                        Console.Clear();
                        Console.WriteLine(@"Turning away from the table, you trip over something bulky,
slamming your head onto a sharp corner.  As your skull cracks open,
your entire life flashes before your eyes.  You're back to
being unconcious before your body hits the ground, and you die
not long after.

You really should've avoided moving around in a strange,
dark room.

GAME OVER!

Press enter to exit the game.");
                        Console.ReadLine();
                    }
                }
                else if (game.choice == "(D)")
                {
                    Console.Clear();
                    Console.WriteLine(@"You soon find that you are locked-in.  You won't be able
to figure out how to leave this room without a
viable light source.

Press enter to continue.");
                    Console.ReadLine();
                    Console.Clear();
                    game.choice = null;
                }
                else if (game.choice == "(L)")
                {
                    Console.Clear();
                    Console.WriteLine(@"Unable to see in front of you, you trip over something
slippery.  As you fall forward, you feel something sharp
pierce your stomach, sever your spine, and exit through
your back.

It's a pity you have come to such an untimely end. If
you didn't have to join the afterlife, you'd
probably decide not to walk into any more dark
spaces.

GAME OVER!

Press enter to leave the game.");
                    Console.ReadLine();
                }
                else
                {
                    game.invalidSelection();
                    game.resetUserInput();
                }
            }
        }
    }
}

