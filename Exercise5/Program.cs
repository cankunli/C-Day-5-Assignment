using System;

namespace Exercise5
{
    public class Myclass
    {
        public delegate void LogHandlerv(string message);
        public void process(LogHandlerv logHandler)
        {
            if (logHandler! = null)
            {
                logHandler("begin");
            }
            if(logHandler != null)
            {
                logHandler("End");
            }
        }
        public class Mylogger
        {
            public void logger(string s)
            {
                Console.WriteLine(s);
            }
        }
    }
    class Program
    {
        static void Logger(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            MyLogger f1 = new MyLogger();
            Myclass myclass = new Myclass();
            Myclass.LogHandlerv myLogger = null;
            myLogger += new Myclass.LogHandlerv(Logger);
            myLogger += new Myclass.LogHandler(f1.Logger);
            Myclass.process(myLogger);
            return;
        }
    }
}
