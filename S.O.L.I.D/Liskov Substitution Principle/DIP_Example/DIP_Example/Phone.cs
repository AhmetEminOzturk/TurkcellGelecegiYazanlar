using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Example
{
    public class Phone : IMusicPlayer
    {
        public void Play()
        {
            Console.WriteLine("Play music on phone");
        }

        public void Pause()
        {
            Console.WriteLine("Pause music on phone");
        }

        public void Stop()
        {
            Console.WriteLine("Stop music on phone");
        }
    }
}
