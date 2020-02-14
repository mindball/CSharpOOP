using System;

namespace Attributes
{
    class StartUp
    {
        static void Main(string[] args)
        {

            //Copy from https://www.dotnetperls.com/
            Console.WriteLine("SET CACHED AND CURRENT FLAGS");
            var attributes = FlagAttribute.Cached | FlagAttribute.Current;

            // See if current flag is set.
            if ((attributes & FlagAttribute.Current) == FlagAttribute.Current)
            {
                Console.WriteLine("File is current");
            }

            // See if obsolete flag is not set.
            if ((attributes & FlagAttribute.Obsolete) != FlagAttribute.Obsolete)
            {
                Console.WriteLine("File is not obsolete");
            }

            // Remove current flag.
            Console.WriteLine("REMOVE CURRENT FLAG");
            attributes &= ~FlagAttribute.Current;
            var a = attributes & FlagAttribute.Current;

            // See if current flag is set again.
            if ((attributes & FlagAttribute.Current) != FlagAttribute.Current)
            {
                Console.WriteLine("File is not current");
            }



            // 1. 
            // Set the first type.
            RenderType type1 = RenderType.ContentPage;

            // 2.
            // Set the second type if the condition matches.
            if (true)
            {
                //Note: The "|" operator is used in the cases. This means the values are combined.
                //same as var type1 = RenderType.ContentPage | RenderType.GZip;
                type1 |= RenderType.GZip;
            }

            // 3.
            // Check the enum flags.
            var res = (int)(RenderType.GZip | RenderType.ContentPage);
            Check(type1, res);

            // 4.
            // Set a new enum in three statements.
            RenderType type2 = RenderType.ViewPage;
            type2 |= RenderType.DataUri;
            type2 |= RenderType.GZip;

            // 5.
            // See if the enum contains this flag.
            if ((type2 & RenderType.DataUri) == RenderType.DataUri)
            {
                Console.WriteLine("True");
            }

            // 6.
            // See if the enum contains this flag.
            if ((type2 & RenderType.ContentPage) == RenderType.ContentPage)
            {
                throw new Exception();
            }

            // 7.
            // Check the enum flags.
            int res2 = (int)(type2);
            Check(type2, res2);
        }

        private static void Check(RenderType type1, int res)
        {
            //Copy from https://www.dotnetperls.com/
            var res1 = (int)(RenderType.ContentPage | RenderType.DataUri | RenderType.GZip);
            var res2 = (int)(RenderType.ContentPage | RenderType.GZip);
            var res3 = (int)(RenderType.ContentPage);
            var res4 = (int)(RenderType.ViewPage | RenderType.DataUri | RenderType.GZip);
            var res5 = (int)(RenderType.ViewPage | RenderType.GZip);
            var res6 = (int)(RenderType.ViewPage);
            var res7 = (int)(RenderType.HomePage | RenderType.DataUri | RenderType.GZip);
            var res8 = (int)(RenderType.HomePage | RenderType.GZip);
            var res9 = (int)(RenderType.HomePage);

            // Switch on the flags.
            switch (type1)
            {
                case RenderType.ContentPage | RenderType.DataUri | RenderType.GZip:
                    {
                        Console.WriteLine("content, datauri, gzip");
                        break;
                    }
                case RenderType.ContentPage | RenderType.GZip: // first match
                    {
                        Console.WriteLine("content, gzip");
                        break;
                    }
                case RenderType.ContentPage:
                    {
                        Console.WriteLine("content");
                        break;
                    }
                case RenderType.ViewPage | RenderType.DataUri | RenderType.GZip: // second match
                    {
                        Console.WriteLine("view, datauri, gzip");
                        break;
                    }
                case RenderType.ViewPage | RenderType.GZip:
                    {
                        Console.WriteLine("view, gzip");
                        break;
                    }
                case RenderType.ViewPage:
                    {
                        Console.WriteLine("view");
                        break;
                    }
                case RenderType.HomePage | RenderType.DataUri | RenderType.GZip:
                    {
                        Console.WriteLine("home, datauri, gzip");
                        break;
                    }
                case RenderType.HomePage | RenderType.GZip:
                    {
                        Console.WriteLine("home, gzip");
                        break;
                    }
                case RenderType.HomePage:
                    {
                        Console.WriteLine("home");
                        break;
                    }
            }
        }
    }
}
