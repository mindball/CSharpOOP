namespace ChainPatternWikiExample
{
    public abstract class Logger
    {
        protected LogLevel logMask;
        private Logger next;

        public Logger(LogLevel logMask)
        {
            this.logMask = logMask;
        }

        public Logger SetNext(Logger nextLogger)
        {
            Logger lastLogger = this;
            while(lastLogger.next != null)
            {
                lastLogger = lastLogger.next;
            }

            lastLogger.next = nextLogger;
            return this;
        }

        public void Message(string msg, LogLevel severity)
        {
            if((severity & this.logMask) != 0)
            {
                this.WriteMessage(msg);
            }
            
            if(next != null)
            {
                next.Message(msg, severity);
            }
        }

        abstract protected void WriteMessage(string msg);
    }
}
