using System;

namespace CloneManually
{
    public class Person
    {
        public string FirstName;
        public Person SecondName;


        //Недостатък е че ако разширяваме кода може да забравим нещо за инициализация, тоест
        //поддръжката на кода става трудна. Също така ако конструктора ми е бавен ще се забавят 
        //извикването му ще забави проекта.
        public object Clone()
        {
            Person p = new Person();
            p.FirstName = this.FirstName;
            p.SecondName = this.SecondName;

            return p;
        }
    }
}
