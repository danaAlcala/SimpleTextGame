using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTextGame
{
    class HelpFile
    {
        public HelpFile()
        {
            Console.Clear();
            Console.WriteLine("Welcome to help!  Let's get started.\n\n");
            Console.WriteLine(@"Ok.  So this is a text adventure game.  Never played one before?
Well that's OK.  It's pretty simple.  Think of this as a digital
'Choose Your Own Adventure' book.  Only instead of turning pages,
you make decisions with (K)eywords.  Notice the parenthesis in
the word '(K)eyword'?  You'll come across a lot of these along
the way.  Whenever you see that, it means you're looking at a
(K)eyword.  Got it?  Good.

Now press enter to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(@"Now you might be asking yourself, 'what is a (K)eyword? what do
I use them for?'  As I said before, you'll use them to make decisions.
Oh... you want to know 'how' to use them?  It's easy!  You just type the
(K)eyword, press enter, and voila!  No, you don't really have to type the
whole (K)eyword.  You don't even have to include the weird-looking
parenthesis (actually, it won't even work if you do).  All you have to do
is type the first letter of the word, and you're good.  But don't forge
to press the enter key!  That is the key!  Hehe.

Now press enter to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(@"The following is a list of general-use keywords.  That means that,
for the most part, you can use these keys at any given time.
**************************************************************************
(H)elp - Brings you back to this nifty help module.
(I)nspect - This allows you to inspect your immediate surroundings.  This
            will reveal assets in the room that you are currently
            occupying, such as furniture, doors, treasure, and (K)ey
            items.
**************************************************************************

Press enter to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(@"There's one more thing I wanted to bring up to you, and that is
there are times when all you have to do is answer a simple (Y)es or (N)o
question.  The game won't always make it super-obvious if that is the
case, but I'm sure you'll be able to figure it out.  You ARE an
intelligent person, aren't you?  Well... maybe at least a little smart?

But I digress.  Just remember that if you ever need to come back to this
(H)elp module, simply enter the letter 'h' at any time.

Press enter to return to our scheduled programming.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
