using System;
using System.Collections.Generic;
using System.Text;

namespace Lectures
{
    class CallBack
    {
        public void DoWord(int number, Action<int> callBack)
        {
            Console.WriteLine(number);
            callBack(number);
        }
    }
}
