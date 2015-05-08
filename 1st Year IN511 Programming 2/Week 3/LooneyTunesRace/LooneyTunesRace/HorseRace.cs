using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LooneyTunesRace
{
    public class HorseRace
    {
        private Horse[] horses;
    
        public HorseRace(PictureBox[] PictureBoxes)
        {
            throw new System.NotImplementedException();
            horses[0] = new Horse("Daffy" PictureBoxes[0],100);
            horses[1] = new Horse("Pepe" PictureBoxes[1],100);
            horses[2] = new Horse("Taz" PictureBoxes[2],100);
            horses[3] = new Horse("Wiley" PictureBoxes[3],100);

        }
    
        public Horse CheckForWinner()
        {
            throw new System.NotImplementedException();
        }

        public void Race()
        {
            throw new System.NotImplementedException();
        }

        public void RestartRace(Timer timer1)
        {
            for (int i = 0; i < 4; i++)
            {
                horses[i].PictureBox.Left+10;
            }
            timer1.Enabled = true;
        }

        public void StopRace()
        {
            throw new System.NotImplementedException();
        }
    }
}
