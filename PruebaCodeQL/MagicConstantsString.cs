﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaCodeQL
{
    class MagicConstantsString
    {
        public static void send(string ip, string message)
        {
            // ...
        }

        public static void testmessage()
        {
            send("127.0.0.1", "test message");
        }

        public static void Main(string[] args)
        {
            testmessage();
            send("127.0.0.1", "hello world");
        }
    }

}
