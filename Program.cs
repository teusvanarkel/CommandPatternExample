using System;
using CommandPatternExample.CustomerCommands;

namespace CommandPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager();
            manager.AddAddress();
            manager.AddPhone();
                        
        }
    }
}
