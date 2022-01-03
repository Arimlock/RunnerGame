using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunnerGame
{
    public class ShowPlaying
    {
        public static void Play()
        {

        }
        public static void Move(ConsoleKey key, Control dino)
        {
            int movement;
            if (key == ConsoleKey.W)
                movement = dino.Height;
            else
                movement = -dino.Height;
            dino.Location = new System.Drawing.Point(0,dino.Location.Y+movement);
        }
    }
}
