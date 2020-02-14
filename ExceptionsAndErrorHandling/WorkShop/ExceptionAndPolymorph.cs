using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShop
{
    class ExceptionAndPolymorph
    {
        private Example example = new Example();
        public void UseSomeDateFromExample()
        {
            try
            {
            }
            catch(Exception ex)
            {
                //Ако exception-а e от друг тип да кажем ArgumentException стават
                //две неща първо вече сме влезнали в catch-a (следващ catch няма да се изпълни),
                //второ exception вече е от тип ArgumentOutOfRangeException и ArgumentNullException
                //затова е по редно да се ползва when!!!
                if (ex is ArgumentOutOfRangeException ||
                    ex is ArgumentNullException
                    )
                {
                    //do something up in Exception Hierarchy
                }
            }
        }

        public void UseSomeDateFromExampleNewCSharpVersion()
        {
            Example example = new Example();

            try
            {
            }
            catch (Exception ex)
            when(ex is ArgumentOutOfRangeException ||
                    ex is ArgumentNullException)
            {
                    //do something up in Exception Hierarchy                
            }
            catch (ArgumentException ex)
            {
                //do something
            }
        }
    }
}
