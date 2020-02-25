using System.Collections.Generic;

namespace Example2
{
    public class LazyFactoryObject
    {
        private static IDictionary<LazyObjectSize, LazyObject> lazyObjectList =
            new Dictionary<LazyObjectSize, LazyObject>();

        public LazyFactoryObject()
        {
            //empty constructor
        }

        //takes size and create 'expensive' list
        private IList<int> Result(LazyObjectSize size)
        {
            IList<int> result = null;

            switch (size)
            {
                case LazyObjectSize.Small:
                    result = CreateSomeExpensiveList(1, 100);
                    break;
                case LazyObjectSize.Big:
                    result = CreateSomeExpensiveList(1, 1000);
                    break;
                case LazyObjectSize.Bigger:
                    result = CreateSomeExpensiveList(1, 10000);
                    break;
                case LazyObjectSize.Huge:
                    result = CreateSomeExpensiveList(1, 100000);
                    break;
                case LazyObjectSize.None:
                    result = null;
                    break;
                default:
                    result = null;
                    break;
            }

            return result;
        }

        //not an expensive item to create, but you get the point
        //delays creation of some expensive object until needed
        private IList<int> CreateSomeExpensiveList(int start, int end)
        {
            IList<int> result = new List<int>();

            for (int counter = 0; counter < (end - start); counter++)
            {
                result.Add(start + counter);
            }

            return result;
        }

        public LazyObject GetLazyFactoryObject(LazyObjectSize size)
        {
            //yes, i know it is illiterate and inaccurate
            LazyObject noGoodSomeOne;

            //retrieves LazyObjectSize from list via out, else creates one and adds it to list
            if (lazyObjectList.TryGetValue(size, out noGoodSomeOne))
            {
                noGoodSomeOne = new LazyObject();
                noGoodSomeOne.Size = size;
                noGoodSomeOne.Result = this.Result(size);

                lazyObjectList.Add(size, noGoodSomeOne);
            }

            return noGoodSomeOne;
        }
    }
}
