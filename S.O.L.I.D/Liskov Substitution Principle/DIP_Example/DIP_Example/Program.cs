using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMusicPlayer phone = new Phone();
            IMusicPlayer computer = new Computer();
            IMusicPlayer speaker = new Speaker();

            
            phone.Play();  
            computer.Pause(); 
            speaker.Stop();

            //müzik uygulamasının kodu değiştirilmeden yeni cihazlar eklenebilir veya mevcut cihazlar değiştirilebilir.

        }
    }
}
