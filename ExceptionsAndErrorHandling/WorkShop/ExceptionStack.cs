namespace WorkShop
{
   public class ExceptionStack
    {
        public void A1()
        {
            try
            {
                B1();
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Method A");
                throw;
            }
        }

        public void B1()
        {
            try
            {
                C1();
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Method B");
                throw;
            }
        }

        public void C1()
        {
            try
            {
                int.Parse("hundred");
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Method C");
                throw;
            }
        }

        //Stack trace from only A2 ползва се при private method-дите
        public void A2()
        {
            try
            {
                B2();
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Method A");
                throw ex; 
            }
        }

        public void B2()
        {
            try
            {
                C2();
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Method B");
                throw;
            }
        }

        public void C2()
        {
            try
            {
                int.Parse("hundred");
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Method C");
                throw;
            }
        }
    }
}
