using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    class SorterWrongVersion<T>
    {
        //кое в имплементацията не е Open/Closed:
        //  * aко за решим да добавим след време нов сорт-метод какво ще се случи, 
        //      колко неща ще се променят (ние ще модифицираме класа, което е неправилно, 
        //      а трябва да extend-нем самата абстракция както е във RightVersion)
        /*
         * В този пример имам super coupling: този клас знае за всичките сортирвания и как стават, както и 
         * методите за сортиране знаят също за себе си.
         * */

        public SorterWrongVersion(string type)
        {
            if (type == "merge")
            {
                this.MergeSort(new List<T>());
            }
            if (type == "select")
            {
                this.SelectionSort(new List<T>());
            }
            //add new sort
            if (type == "bogo")
            {
                this.BogoSort(new List<T>());
            }
        }

        private IEnumerable<T> SelectionSort(
            IEnumerable<T> collection)
        {
            Console.WriteLine("Selection sort is tge best!!!");
            return collection;
        }

        private IEnumerable<T> MergeSort(IEnumerable<T> collection)
        {
            Console.WriteLine("Merge sort is the worst!!");
            return collection;
        }

        //добавяне на нов сорт
        private IEnumerable<T> BogoSort(IEnumerable<T> collection)
        {
            Console.WriteLine("Add new sort");
            return collection;
        }




    }
}

