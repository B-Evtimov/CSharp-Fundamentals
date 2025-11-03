using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProjects
{
    public class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            HashSet<string> usersInTeams = new HashSet<string>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] creationInput = Console.ReadLine().Split('-');
                string creator = creationInput[0];
                string teamName = creationInput[1];

                if (teams.Any(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(t => t.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    Team team = new Team(teamName, creator);
                    teams.Add(team);
                    usersInTeams.Add(creator);
                    Console.WriteLine($"Team {teamName} has been created by {creator}!");
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] joinInput = command.Split("->");
                string user = joinInput[0];
                string teamName = joinInput[1];

                Team teamToJoin = teams.FirstOrDefault(t => t.Name == teamName);

                if (teamToJoin == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (usersInTeams.Contains(user))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                }
                else
                {
                    teamToJoin.Members.Add(user);
                    usersInTeams.Add(user);
                }
            }

            var validTeams = teams
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name);

            foreach (var team in validTeams)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            var disbandedTeams = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.Name);

            Console.WriteLine("Teams to disband:");
            foreach (var team in disbandedTeams)
            {
                Console.WriteLine(team.Name);
            }
        }
    }
}
