using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class Players
    {
        public string First { get; set; }
        public string Last { get; set; }
        public int ID { get; set; }
        public double Average_Score { get; set; }
        public List<int> Last_Matches;

        #region list
        static List<Players> players = new List<Players>
        {
        new Players {First="Alesha", Last="Orlovskiy", ID=1,Average_Score=25.9 , Last_Matches= new List<int> {1, 1, 1, 1}},
        new Players {First="Olezha", Last="O'Donnell", ID=2,Average_Score=20.9 , Last_Matches= new List<int> {1, 0, 0, 0}},
        new Players {First="Andre", Last="Mortensen", ID=3,Average_Score=31.8 , Last_Matches= new List<int> {1, 1, 1, 1}},
        new Players {First="Cesar", Last="Tyukin", ID=4,Average_Score=20.1 , Last_Matches= new List<int> {1, 1, 0, 1}},
        new Players {First="Sam", Last="Deng", ID=5,Average_Score=13.5 , Last_Matches= new List<int> {0, 1, 1, 0}},
        new Players {First="Derrick", Last="Rose", ID=6,Average_Score=30.4 , Last_Matches= new List<int> {0, 0, 0, 1}},
        new Players {First="Avery", Last="Bradley", ID=7,Average_Score=28.6 , Last_Matches= new List<int> {1, 1, 1, 1}},
        new Players {First="Dan", Last="Henderson", ID=8,Average_Score=23.4 , Last_Matches= new List<int> {0, 1, 0, 1}},
        new Players {First="Lance", Last="Stevenson", ID=9,Average_Score=28.8 , Last_Matches= new List<int> {1, 1, 1, 1}},
        new Players {First="Terry", Last="Crews", ID=10,Average_Score=16.0 , Last_Matches= new List<int> {0, 0, 0, 0}},
        new Players {First="Jordan", Last="Clarkson", ID=11,Average_Score=25.8 , Last_Matches= new List<int> {1, 1, 1, 1}},
        new Players {First="Michael", Last="Turner", ID=12,Average_Score=24.3 , Last_Matches= new List<int> {1, 1, 1, 0}}
        };
        #endregion



        static void Main(string[] args)
        {
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            #region queries

            var numQuery =
           from num in numbers
           where (num % 2) == 1
           select num;

            var playersScore =
           from player in players
           where player.Average_Score >= 25
           select player;

            var listOfPlayers =
           from player in players
           orderby player.Last
           select player;

            var lastWin =
           from player in players
           where player.Last_Matches[3] == 1
           select player;

            var lastNameGroup =
           from player in players
           group player by player.Last[0];

            var lastNameGroupOrder =
           from player in players
           orderby player.Last
           group player by player.Last[0];

            var wonAllMatches=
           from player in players
           let wons = player.Last_Matches[0] 
           + player.Last_Matches[1] 
           + player.Last_Matches[2]
           + player.Last_Matches[3]
           where wons == 4
           select player;

            var AverageScores =
           (from player in players
           select player.Average_Score)
           .Average();

            var scorersCount =
            players.Where(a => a.Average_Score > 20)
            .Count();

            var firstWithA =
            players.Where(l => l.First.StartsWith("A"));

            #endregion

            #region print

            Console.WriteLine("1.Odd numbers");
            Console.WriteLine("");
            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }
            Console.WriteLine("");
            Console.WriteLine("_________________________________");

            Console.WriteLine("2.Players with average 25 or better");
            Console.WriteLine("");
            foreach (Players player in playersScore)
            {
                Console.WriteLine("{0} {1} - {2}", player.First, player.Last, player.Average_Score);
            }
            Console.WriteLine("_________________________________");

            Console.WriteLine("3.Order by Last Name");
            Console.WriteLine("");
            foreach (Players player in listOfPlayers)
            {
                Console.WriteLine("{0}, {1}", player.Last, player.First);
            }
            Console.WriteLine("_________________________________");

            Console.WriteLine("4.Won Last Match");
            Console.WriteLine("");
            foreach (Players player in lastWin)
            {
                Console.WriteLine("{0}, {1}", player.Last, player.First);
            }
            Console.WriteLine("_________________________________");

            Console.WriteLine("5.Last Name Groups");
            Console.WriteLine("");
            foreach (var player in lastNameGroup)
            {
                Console.WriteLine(player.Key);
                foreach (Players lastNames in player)
                {
                    Console.WriteLine("{0}, {1}", lastNames.Last, lastNames.First);
                }
            }
            Console.WriteLine("_________________________________");

            Console.WriteLine("8.Last Name Groups with Order");
            Console.WriteLine("");
            foreach (var player in lastNameGroupOrder)
            {
                Console.WriteLine(player.Key);
                foreach (Players lastNames in player)
                {
                    Console.WriteLine("{0}, {1}", lastNames.Last, lastNames.First);
                }
            }
            Console.WriteLine("_________________________________");

            Console.WriteLine("7.Won All Matches");
            Console.WriteLine("");
                foreach (Players player in wonAllMatches)
                {
                    Console.WriteLine("{0}, {1}", player.Last, player.First);
                }
            Console.WriteLine("_________________________________");

            Console.WriteLine("8.Average Score for All Players");
            Console.WriteLine("");
            Console.WriteLine(AverageScores);
            Console.WriteLine("");
            Console.WriteLine("_________________________________");

            Console.WriteLine("9.Number of players with 20 points or better");
            Console.WriteLine("");
            Console.WriteLine(scorersCount);
            Console.WriteLine("");
            Console.WriteLine("_________________________________");

            Console.WriteLine("10.First letter of First Name is A");
            Console.WriteLine("");
            foreach (Players player in firstWithA)
            {
                Console.WriteLine("{0}, {1}", player.First, player.Last);
            }
            Console.WriteLine("_________________________________");
            #endregion

            Console.ReadKey();
        }
    }
}
