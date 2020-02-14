using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.LiveDemo
{
    //Най вече се ползва за тестване DependencyInversion!!!!!!!!!!
    static class StartUp
    {
        public static void Main()
        {
            //1.Направили сме си логиката за печатене през конзолата
            Game game = new Game(new ConsoleRenderer(), new EmailSender());
            game.Loop();

            //2.след като сме го използвали вече искаме да направим друго рендиране да кажем в browser-a,
            //и добавяме новия рендер HTML и просто създавеме новия клас с импл. на интерфейса и всичко 
            //се нарежда много по бързо - така кода се extend-ва, ленсо се добавят нови неща
            //нещата не са coupling-нати
            Game gameTwo = new Game(new HtmlRenderer(), new EmailSender());
            game.Loop();

            //3. Решаваме че ще изпращаме email (виж класа Game)
            //  

            //Constructor injection до сега каквото правихме
            //4. Имаме и Property injection, рядко се ползва но го има и трябва да направим проверка
            //  на пропертитата дали са инициализирани
            /*  class Copy
             *  {
             *      //Check property needs to always be provided
             *      private IReader reader;
             *      private IWriter writer;
             *      
             *      public Copy(IReader reader, IWriter writer)
             *      {
             *          this.reader = reader;
             *          this.writer = writer;
             *      }
             *      
             *  }
             *  
             *  var newCopy(new ConsoleReader(), new FileWriter("out.txt"));
             **/

            //5. Parameter injection
            //6. word "new" violation да не се ползва в класовете(разгледай случай )
            //7. Виж примера с P01.HellowWorld before and after защо се използва за тестване DIP
            //8. Разгледай примера с Database 
            //  ако искаме да добавим нова база данни например Mysql и т.н.
            //9. DIP conteiner
        }
    }
}
