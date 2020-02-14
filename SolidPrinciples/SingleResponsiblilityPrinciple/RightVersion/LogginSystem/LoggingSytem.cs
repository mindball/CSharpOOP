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
            Log log;
            
            public LoggingSytem()
            {
                this.newUser = new UserName();
                this.passWord = new Password();
                this.db = new DateBase();
                this.log = new Log();
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
