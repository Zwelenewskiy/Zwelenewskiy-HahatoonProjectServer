﻿using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Threading.Tasks;

namespace HahatoonProjectServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Factory.StartNew(() => 
            {
                Server server = new Server();
                server.Start(Structs.HOST);

                while (true)
                {
                    server.NewConnection();
                }
            }, TaskCreationOptions.LongRunning);


            while (true)
            {
                Functions.ReadCommand();
            }
        }       
    }
}
