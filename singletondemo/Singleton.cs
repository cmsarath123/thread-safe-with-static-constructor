using System;
using System.Collections.Generic;
using System.Text;

namespace singletondemo
{
    public class Singleton
    {
        private static int ObjectsCount = 0;
        public static Singleton instance = new Singleton();
        public static Singleton GetInstance
        {
            get
            {
                return instance;
            }
        }
        static Singleton()
        {

        }
        private Singleton()
        {
            ObjectsCount++;
            Console.WriteLine($"instances {ObjectsCount}");
        }

        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
