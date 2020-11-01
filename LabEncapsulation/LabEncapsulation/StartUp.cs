using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var people = new List<Person>();
            
            for (int i = 0; i < lines; i++)
            {
                string[] personArg = Console.ReadLine().Split(" ").ToArray();
                string firstName = personArg[0];
                string lastName = personArg[1];
                int age = int.Parse(personArg[2]);
                decimal salary = decimal.Parse(personArg[3]);
                Person person = null;
                try
                {
                    person = new Person(firstName, lastName, age, salary);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    continue;
                }
                people.Add(person);
               // team.AddPlayer(person);
            }
            string teamName = Console.ReadLine();
            Team team = new Team(teamName);
            foreach (Person person in people)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
        }
    }
}
