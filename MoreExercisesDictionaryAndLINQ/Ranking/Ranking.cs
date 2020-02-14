using System;
using System.Collections.Generic;
using System.Linq;

class Ranking
{
    static void Main()
    {
        //store key= contest value=password
        Dictionary<string, string> contestStore = new Dictionary<string, string>();
        //key=username, value=nested Dict<key=contest, value=points>>
        Dictionary<string, Dictionary<string, int>> usersStore = new Dictionary<string, Dictionary<string, int>>();        
        Dictionary<string, int> userStorePoints = new Dictionary<string, int>();
        string winUser = "";
        int maxPoints = 0;

        string input;
        string[] splitInput;
        string nameOfContest;
        string contestPass;
        string username;
        int points;

        while (true)
        {
            input = Console.ReadLine();
            if (input.Equals("end of contests"))
                break;

            splitInput = input.Split(new char[] { ':' });
            nameOfContest = splitInput[0];
            contestPass = splitInput[1];

            if (contestStore.ContainsKey(nameOfContest))
                contestStore[nameOfContest] = contestPass;
            else
                contestStore.Add(nameOfContest, contestPass);
        }

        while(true)
        {
            input = Console.ReadLine();
            if (input.Equals("end of submissions"))
                break;

            splitInput = input.Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
            nameOfContest = splitInput[0];
            contestPass = splitInput[1];
            username = splitInput[2];
            points = int.Parse(splitInput[3]);

            string currentPassword;
            if (contestStore.TryGetValue(nameOfContest, out currentPassword) && currentPassword.Equals(contestPass))
            {
                if (usersStore.ContainsKey(username))
                {
                    //exist user = true, contain exist contest
                    if (usersStore[username].ContainsKey(nameOfContest))
                    {
                        
                        //compare current point at exist user with input points
                        if (points > usersStore[username][nameOfContest])
                        {
                            int oldPoints = usersStore[username][nameOfContest];
                            usersStore[username][nameOfContest] = points;
                            userStorePoints[username] = (userStorePoints[username] - oldPoints) + points;
                        }
                        else
                            continue;                        
                    }
                    else
                    {
                        usersStore[username].Add(nameOfContest, points);                        
                        userStorePoints[username] += points;                        
                    }
                }
                else
                {
                    usersStore.Add(username, new Dictionary<string,int>());
                    usersStore[username].Add(nameOfContest, points);                    
                    userStorePoints.Add(username, points);
                }
                //Track маx points
                if (maxPoints < userStorePoints[username])
                {
                    maxPoints = userStorePoints[username];
                    winUser = username;
                }
            }
            else
                continue;
        }

        Console.WriteLine($"Best candidate is {winUser} with total {userStorePoints[winUser]} points.");
        Console.WriteLine("Ranking: ");
        var sortUser = usersStore.OrderBy(x => x.Key);

        foreach (var item in sortUser)
        {
            Console.WriteLine(item.Key);
            var sortContest = item.Value.OrderByDescending(x => x.Value);
            foreach (var item2 in sortContest)
            {
                Console.WriteLine("#  " + item2.Key + " -> " + item2.Value);
            }
        }
    }

}

