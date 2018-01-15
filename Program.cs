using System;
using System.Collections.Generic;

namespace dreamteam
{
    class Program
    {
        static void Main(string[] args)
        {
            // create two lists to hold two teams of 3 
            List<ITeammate> serverSide = new List<ITeammate>();
            List<ITeammate> clientSide = new List<ITeammate>();

            // create new instances of each teammate class
            Greg Greg = new Greg();
            Krys Krys = new Krys();
            Kimmie Kimmie = new Kimmie();
            Garrett Garrett = new Garrett();
            Paul Paul = new Paul();
            Sean Sean = new Sean();

            // add teammates to each of the two lists
            serverSide.Add(Paul);
            serverSide.Add(Garrett);
            serverSide.Add(Sean);

            clientSide.Add(Greg);
            clientSide.Add(Krys);
            clientSide.Add(Kimmie);


            // iterate over the lists and run each teammates work() method
            foreach (ITeammate teammate in serverSide)
            {
                teammate.Work();
            }

            foreach (ITeammate teammate in clientSide)
            {
                teammate.Work();
            }
        }
    }
}
