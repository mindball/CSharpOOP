using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovPrinciple
{
    public abstract class Animal
    {
        // - Type checking в базов клас трябва да се избягва!!!!
        // - Всички методи в абстракния ни клас да са еднакви за всички
        //  - If you need to check what is the object - move
        //  the behavior inside the object
        // - New Base Class – if two classes share a common behavior, but
        //  are not substitutable, create a third, from which both derive
        // - референцията към базовия тип да се реплейсват от наследяващия клас без това да 
        // води до проблем
        //
       
        

        //грешна имплементация за sleep, ако например някои спи по различен начин 
        //трябва да търсим друга абстракция, или да го направим abstract-ктен и децата да си го имплементират
        // (ako има в базовия клас 'is a нещо си' ние вече сме coupling-нати с нещо си, като допълнение: изтрием
        // ли 'нещо си' да кажем че е клас змия този анимал няма да се компилира.)
        // 
        //      public override void Sleep()
        //      {
        //          if(this is Snake) -> това е Type checking
        //              Console.WriteLine("спи като змия")
        //          
        //          Console.WriteLine("sleep");
        //      }
        public abstract void Sleep();
        public abstract void Jump();
        public abstract void Eat();


        // - There shouldn’t be any virtual methods in constructors
        public Animal()
        {
            this.Atack();
        }
        public string  AtackStrategy { get; set; }
        public virtual void Atack()
        {
            Console.WriteLine(this.AtackStrategy);
        }


    }
}
