﻿using System;

namespace Yose
{
    static class Application
    {
        static void Main(string[] args)
        {
            new Server().Start();
            Console.Out.WriteLine("Server started");
            Console.ReadLine();
        }
    }
}
