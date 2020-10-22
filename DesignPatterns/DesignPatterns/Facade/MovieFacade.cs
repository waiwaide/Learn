using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Facade
{
    class MovieFacade
    {
        private Projector projector=new Projector("三星");
        private Amplifier amplifier= new Amplifier();
        private Screen screen=new Screen();
        private DVDPlayer dvdPlayer=new DVDPlayer();
        private Light light=new Light();

        internal Projector Projector
        {
            get
            {
                return projector;
            }

            set
            {
                projector = value;
            }
        }

        public MovieFacade()
        {
         
        }
       
      
        public void OpenMovie()
        {
            Projector.Open();
            amplifier.Open();
            screen.Open();
            dvdPlayer.Open();
            light.Open();
        }

        public void CloseMovie()
        {
            Projector.Close();
            amplifier.Close();
            screen.Close();
            dvdPlayer.Close();
            light.Close();
        }

    }
}
