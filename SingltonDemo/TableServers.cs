using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class TableServers
    {

        private static readonly TableServers _instance = new();
        private readonly List<string> servers = new();
        private int nextServer = 0;

        private TableServers()
        {
            servers.Add("tim");
            servers.Add("sue");
            servers.Add("mary");
            servers.Add("bob");

        }

        public static TableServers GetTableServers()
        {
            return _instance;
        }

        public string GetNextServer()
        {
            string output = servers[nextServer];
            nextServer++;
            if (nextServer >= servers.Count)
                nextServer = 0;

            return output;
        }

    }
}
