using System;
using System.Collections.Generic;

namespace StarWarsPlanets
{
    public class Planet
    {
        public string Name { get; set; }
        public string Climate { get; set; }
        public string Terrain { get; set; }
        public int Population { get; set; }
        public string[] Residents { get; set; }

        public Planet(string name, string climate, string terrain, int population, string[] residents)
        {
            Name = name;
            Climate = climate;
            Terrain = terrain;
            Population = population;
            Residents = residents;
        }

        public void DisplayPlanetInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Climate: {Climate}");
            Console.WriteLine($"Terrain: {Terrain}");
            Console.WriteLine($"Population: {Population}");
            Console.WriteLine("Residents:");
            foreach (var resident in Residents)
            {
                Console.WriteLine($"- {resident}");
            }
            Console.WriteLine();
        }

        public static void AddPlanet(List<Planet> planets)
        {
            Console.Write("Enter the name of the planet: ");
            string name = Console.ReadLine();

            Console.Write("Enter the climate of the planet: ");
            string climate = Console.ReadLine();

            Console.Write("Enter the terrain of the planet: ");
            string terrain = Console.ReadLine();

            Console.Write("Enter the population of the planet: ");
            int population = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of residents: ");
            int numberOfResidents = int.Parse(Console.ReadLine());
            string[] residents = new string[numberOfResidents];
            for (int i = 0; i < numberOfResidents; i++)
            {
                Console.Write($"Enter resident {i + 1}: ");
                residents[i] = Console.ReadLine();
            }

            planets.Add(new Planet(name, climate, terrain, population, residents));
        }
    }
}
