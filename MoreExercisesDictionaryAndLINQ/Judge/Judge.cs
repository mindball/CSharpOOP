using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Judge
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, List<int>>> userContent = new Dictionary<string, Dictionary<string, List<int>>>();
        Dictionary<string, Dictionary<string, int>> contest = new Dictionary<string, Dictionary<string, int>>();
        string userName;
        string inputContest;
        int point;
        

        while(true)
        {
            string input = Console.ReadLine();
            if (input.Equals("no more time"))
                break;

            string[] splitInput = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            userName = splitInput[0];
            inputContest = splitInput[1];
            point = int.Parse(splitInput[2]);


            if (userContent.ContainsKey(userName))
            {
                if(userContent[userName].ContainsKey(inputContest))
                {
                    if (contest[inputContest][userName] < point)
                    {
                        contest[inputContest][userName] = point;
                        userContent[userName][inputContest].Add(point);
                    }
                }
                else
                {
                    if(contest.ContainsKey(inputContest))
                    {
                        contest[inputContest].Add(userName, point);
                    }
                    else
                    {
                        userContent[userName].Add(inputContest, new List<int>());
                        userContent[userName][inputContest].Add(point);

                        contest.Add(inputContest, new Dictionary<string, int>());
                        contest[inputContest].Add(userName, point);
                    }
                    
                }
            }
            else if (!userContent.ContainsKey(userName))
            {
                userContent.Add(userName, new Dictionary<string, List<int>>());
                userContent[userName].Add(inputContest, new List<int>());
                userContent[userName][inputContest].Add(point);

                if (contest.ContainsKey(inputContest))
                    contest[inputContest].Add(userName, point);
                else
                {
                    contest.Add(inputContest, new Dictionary<string, int>());
                    contest[inputContest].Add(userName, point);
                }
            }
            else
            {
                userContent.Add(userName, new Dictionary<string, List<int>>());
                userContent[userName].Add(inputContest, new List<int>());
                userContent[userName][inputContest].Add(point);

                contest.Add(inputContest, new Dictionary<string, int>());
                contest[inputContest].Add(userName, point);
            }
        }

        foreach (var item in contest)
        {
            Console.WriteLine($"{item.Key}: {item.Value.Count} participants");
            var sortByDescOrderUserPoint = item.Value.OrderByDescending(x => x.Value);
            int count = 1;
            foreach (var user in sortByDescOrderUserPoint)
            {
                Console.WriteLine($"{count}. {user.Key} <::> {user.Value}");
                count++;
            }
        }
       
    }
}

