using System;

namespace CommandLineDrawing
{
    public class IllegalCommandException
    {
        private string woordcheck( string[,] data)
        {

            if (data.Length != 7)
            {
                
            }
            if ((data[,0] == "tekencommando") ||(data[, 0] == "undo") || (data[, 0] == "clear") ||(data[, 0] == "vul"))
            {
                return data[, 0];
            }
            else
            {
                throw new FormatException(data[, 0] + " is een ongeldig commando! ");
            }
           
           
        }
    }
}
