using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SingleResponsibilityPrinciple.After
{
    public class Logger : ILoggable
    {
        public void Log(Exception ex)
        {
            //Искат ни  първо (1 )да показваме всички логини които са неуспешни или успешни           
            // 1.File.WriteAllText("access.login.txt", ex.Message);
            //2. второ след време искат да добавят и часа когато е станало                
            //File.WriteAllText("access.login.txt", DateTime.Now + ex.Message);
            //3 след време искат да променят мястото за съхранение да не във файл, а база данни
            File.WriteAllText("toDateBase", ex.Message);
            
        }
    }
}
