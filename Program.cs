using System;
using System.Collections.Generic;

namespace dreamteam
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Teammate> serverSide = new List<Teammate>();
            List<Teammate> clientSide = new List<Teammate>();

            Greg Greg = new Greg();
            Krys Krys = new Krys();
            Kimmie Kimmie = new Kimmie();
            Garrett Garrett = new Garrett();
            Paul Paul = new Paul();
            Sean Sean = new Sean();

            serverSide.Add(Paul);
            serverSide.Add(Garrett);
            serverSide.Add(Sean);

            clientSide.Add(Greg);
            clientSide.Add(Krys);
            clientSide.Add(Kimmie);

            foreach (Teammate teammate in serverSide)
            {
                teammate.Work();
            }

            foreach (Teammate teammate in clientSide)
            {
                teammate.Work();
            }
        }
    }
}
