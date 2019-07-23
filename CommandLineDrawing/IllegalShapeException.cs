using System;

namespace CommandLineDrawing
{
    public class IllegalShapeException
    {
        private string vormCheck(string word)
        {

            if ((word == "rechthoek") || (word == "ellips"))
            {
                return word;
            }
            else
            {
                throw new FormatException(word + " is een onbekende vorm. ");
            }


        }
    }
}
