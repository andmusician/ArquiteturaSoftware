using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArquiteturaSoftware.Singleton
{
    internal class Singleton
    {       

        public static void Execute()
        {
            Logger logger1 = Logger.Instance();
            Logger logger2 = Logger.Instance();

            if(logger1 == logger2)
            {
                Console.WriteLine("Mesma Instancia");
            }

            Console.WriteLine(logger1.Write("Exception1"));
            Console.WriteLine(logger2.Write("Exception2")); 
        }
        
    }

    public class Logger
    {
        public static readonly Logger instance = new Logger();

        public static Logger Instance()
        {
            return instance;
        }

        public string Write(string message)
        {
            return $"Mensagem de Log: {message}";
        }
    }
}
