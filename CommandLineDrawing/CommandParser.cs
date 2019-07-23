using System.Collections.Generic;

namespace CommandLineDrawing
{
    public class CommandParser
    {
        public string[,] data;
        private int i = 0;
        
        private void verdeel()
        {
            string lijn = commandTextBox.Text;
            data[i, 0] = lijn.Substring(0, lijn.IndexOf(" "));
            data[i, 1] = lijn.Substring(lijn.IndexOf(" ")+1,lijn.IndexOf(" ")+2);
            data[i, 2] = lijn.Substring(lijn.IndexOf(" ") + 2, lijn.IndexOf(","));
            data[i, 3] = lijn.Substring(lijn.IndexOf(","), lijn.IndexOf(",")+1);
            data[i, 4] = lijn.Substring(lijn.IndexOf(",") + 1, lijn.IndexOf(",")+2);
            data[i, 5] = lijn.Substring(lijn.IndexOf(",") + 2, lijn.IndexOf(",")+3);
            data[i, 6] = lijn.Substring(lijn.IndexOf(",") + 3, lijn.IndexOf(",")+4);
            data[i, 7] = lijn.Substring(lijn.IndexOf(",")+4);
            i++;

        }
        private void checkwoord()
        {
           

            if (commandTextBox.Text.Contains("undo"){
                paper.Canvas
    }
            else if (commandTextBox.Text.Contains("clear"){
                paperCanvas.clear();
            }
            else if (commandTextBox.Text.Contains("teken"){
                pa
            }
            else if (commandTextBox.Text.Contains("vul"){

            }
        }
     
}
