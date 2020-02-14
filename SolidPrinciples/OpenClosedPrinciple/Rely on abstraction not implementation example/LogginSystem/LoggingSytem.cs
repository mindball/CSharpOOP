using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibilityPrinciple.After
{
    class LoggingSytem
    {
        class LoggingSytem
        {
            //dependency injection;
            User newUser;
            Password passWord;
            DateBase db;
            //Rely on abstraction not implementation
            //
            //Log log; // ако го направим така е директна имплементация по правилно е:
            ILooggable logger;  //чрез параметрите на конструктора да се подават
            //защото след време когато искаме да сменим съхр. на логове от файл => db ще е много лесно
            
            public LoggingSytem(ILooggable logger)
            {
                this.newUser = new UserName();
                this.passWord = new Password();
                this.db = new DateBase();
                //директна имплементация
                //this.log = new Log(); По правилно
                this.logger = logger;
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
                catch (Exception ex)
                {
                    log.Loging(ex);
                }
            }
    }
}
