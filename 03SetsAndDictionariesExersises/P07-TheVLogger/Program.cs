using System;
using System.Collections.Generic;

namespace P07_TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> vloggerCollection = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string input;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                if (input.Contains("joined"))
                {
                    string username = input.Split()[0];
                    if (!vloggerCollection.ContainsKey(username))
                    {
                        vloggerCollection.Add(username, new Dictionary<string, HashSet<string>>());
                        vloggerCollection[username].Add("followings", new HashSet<string>());
                        vloggerCollection[username].Add("followers", new HashSet<string>());
                    }
                }
                else if (input.Contains("followed"))
                {
                    string[] usernames = input.Split();
                    string firstVlogger = usernames[0];
                    string secondVlogger = usernames[1];

                    if (!vloggerCollection.ContainsKey(firstVlogger) || 
                        !vloggerCollection.ContainsKey(secondVlogger) || 
                        firstVlogger == secondVlogger)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    vloggerCollection[firstVlogger]["following"].Add(secondVlogger);

                }
            }
            
        }
    }
}
