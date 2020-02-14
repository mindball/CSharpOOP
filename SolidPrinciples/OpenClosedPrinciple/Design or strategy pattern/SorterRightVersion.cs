using OpenClosedPrinciple.Design_or_strategy_pattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    class SorterRightVersion<T>
    {
        public SorterRightVersion(string type)
        {
            //design pattern or strategy pattern
            //кое общото (за да напавим абстракция трябва да видим общите неща!!!)
            /*
             * Design smell: Need to retest after chabnges
             *  - Old parts changed -> possible bugs;
             *  Ако нещо има нужда от ре-тестване значи нямаме принципа Open/Closed  
             *
             * */

            ISorterRightVersion<T> sorterStrategy = null;

            if (type == "merge")
            {
                sorterStrategy = new MergeSorter<T>();
            }
            if (type == "select")
            {
                sorterStrategy = new SelectionSorter<T>();
            }
            //ако трябва да добавим нов сорт
            //  1. Нов клас с имплементация на интерфейса
            //  
            if (type == "bogo")
            {
                sorterStrategy = new NewSortBogo<T>();
            }

            sorterStrategy.Sort(new List<T>());
            
        }

    }
}
