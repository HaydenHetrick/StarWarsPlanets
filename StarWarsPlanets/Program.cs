using System;
using System.Collections.Generic;

namespace StarWarsPlanets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Planet> planets = new List<Planet>();

            planets.Add(new Planet("Tatooine", "Arid", "Desert", 200000, new string[] { "Luke Skywalker", "Anakin Skywalker" }));
            planets.Add(new Planet("Alderaan", "Temperate", "Grasslands, Mountains", 1000000000, new string[] { "Leia Organa" }));
            planets.Add(new Planet("Yavin IV", "Tropical", "Jungle", 30000, new string[] { "None" }));

            Console.WriteLine("Star Wars Planets");
            foreach (Planet planet in planets)
            {
                planet.DisplayPlanetInfo();
            }

            planets.Sort((p1, p2) => p1.Population.CompareTo(p2.Population));

            Console.WriteLine("Planets sorted by population:");
            foreach (Planet planet in planets)
            {
                planet.DisplayPlanetInfo();
            }

            bool addingPlanets = true;

            while (addingPlanets)
            {
                Planet.AddPlanet(planets);

                Console.Write("Do you want to add another planet? (y/n): ");
                string answer = Console.ReadLine();

                if (answer.ToLower() != "y")
                {
                    addingPlanets = false;
                }
            }

            planets.Sort((p1, p2) => p1.Population.CompareTo(p2.Population));

            Console.WriteLine("\nUpdated list of planets:");
            foreach (Planet planet in planets)
            {
                planet.DisplayPlanetInfo();
            }

            Console.ReadKey();
        }
    }
}
