
using ConsoleUI;

Console.WriteLine("Hello, World!");

TableServers host1List1 = TableServers.GetTableServers();
TableServers host2List2 = TableServers.GetTableServers();

for (int i = 0; i < 5; i++)
{
    Host1GetNextServer();
    Host2GetNextServer();
}

void Host1GetNextServer()
{
    Console.WriteLine("the next server is :" + host1List1.GetNextServer());
}

void Host2GetNextServer()
{
    Console.WriteLine("the next server is :" + host2List2.GetNextServer());
}