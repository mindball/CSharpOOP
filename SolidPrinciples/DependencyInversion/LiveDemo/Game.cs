using DependencyInversion.LiveDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.LiveDemo
{
    class Game
    {
        private IEnumerable<Shape> shapes;
        private IRenderer renderer;
        //3.
        private IEmailSender emailSender;

        public Game(IRenderer renderer, IEmailSender emailSender)
        {
            this.renderer = renderer;
            //3.
            this.emailSender = emailSender;
            this.emailSender.SendEmail("", "");
        }

        public void Loop()
        {
            while(true)
            {
                foreach (var item in shapes)
                {
                    this.renderer.DrawAt(item);
                }
            }
            
        }
    }
}
