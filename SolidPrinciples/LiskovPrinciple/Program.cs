using System;

namespace LiskovPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
           // - референцията към базовия тип да се реплейсват от наследяващия клас без това да 
        // води до проблем
            //other liskov principel
            //Animal cat = new Cat();
            //cat.Jump();
            //cat.Eat();
            //cat.Sleep();

            //Animal snake = new Snake();
            //snake.Jump();
            //snake.Eat();
            //snake.Sleep();
            //end of other liskov principel


            //Smell code:
            /* type checking:
             * class GraphicEditor
             * {
             *      public void Draw(IShape shape)
             *      {
             *              грешно:
             *         if(shape is Rectangle)
             *         {
             *              var ractangle = shape as Rectangle
             *         }
             *      }                   
             * }
             * 
             * */
             /* Override method says: I'm not implemented
              * Трябва да разгледаме абстракцията си наново.
              * 
              * */
              /* Base class depends on its subypes
               *    class BaseShape
               *    {
               *        
               *        void DoSpecificWork()
               *        {
               *            //тук е зависимостта
               *            if(this is Square))
               *            {
               *                //somelogic
               *            }                         
               *        }
               *    
               *    }
               *    class Square : BaseShape
               *    {
               *        base.DoSpecificWork();
               *    }
               * 
               * */

            // - There shouldn’t be any virtual methods in constructors
            Animal lion = new Cat("Running"); //Няма да се инициализира полето AtackStrategy, \
            //единствено ако го извикаме с             
            //lion.Atack();
            //Тествай първо само с инициализация на обект, след това като обекта вика метода дебъгни го и разгедай
            //end of There shouldn’t be any virtual methods in constructors

        }
    }
}
