using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingleResponsibilityPrinciple.Before
{
    class LogingSystem
    {
        User newUser;
        Password passWord;
        DateBase db;
        public LogingSystem()
        {
            this.newUser = new UserName();
            this.passWord = new Password();
            this.db = new DateBase();
        }

        public void CreateNewLogin()
        {
            try
            {
                if (!db.SearchExistUser(this.newUser))
                {
                    //Add new user
                }
                else
                {
                    //Access to application
                }
            }
            //Искат ни  първо (1 )да показваме всички логини които са неуспешни или успешни
            //Неправилен начин
            catch (Exception ex)
            {
                //1. File.WriteAllText("access.login.txt", ex.Message);
                //2. второ след време искат да добавят и часа когато е станало                
                File.WriteAllText("access.login.txt",DateTime.Now +  ex.Message);
                //3 след време искат да променят мястото за съхранение да не във файл, а база данни
                //Нарушаване на правилото:
                //  copy/paste на много места
                //  Класа прави твърде много неща, а не конкретно нещо
                Console.WriteLine(ex.Message);
            }
        }
        public void ExistLogin()
        {
            try
            {
                var existUser = db.ExistUser.GetData();
            }
            //Искат ни  първо (1 )да показваме всички логини които са неуспешни или успешни
            //Неправилен начин
            catch (Exception ex)
            {
                //1. File.WriteAllText("access.login.txt", ex.Message);
                //2. второ след време искат да добавят и часа когато е станало               
                //3 след време искат да променят мястото за съхранение да не във файл, а база данни
                File.WriteAllText("access.login.txt", DateTime.Now + ex.Message);               
                Console.WriteLine(ex.Message);
            }
        }
    }
}
