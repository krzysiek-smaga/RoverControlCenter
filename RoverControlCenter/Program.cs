using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {

            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            Rover[] rovers = new Rover[] { lunokhod, apollo, sojourner };

            DirectAll(rovers);

            Object[] allSpaceObjects = new Object[] { lunokhod, apollo, sojourner, sputnik };
            foreach (Object spaceObject in allSpaceObjects)
            {
                Type t = spaceObject.GetType();
                Console.WriteLine($"Tracking a {t}...");
            }

            IDirectable[] spaceObjects = new IDirectable[] { lunokhod, apollo, sojourner, sputnik };

            Console.WriteLine(" ");

            DirectAll(spaceObjects);

            Console.ReadLine();
        }

        public static void DirectAll(IDirectable[] spaceObjects)
        {
            foreach (IDirectable spaceObject in spaceObjects)
            {
                Console.WriteLine(spaceObject.GetInfo());
                Console.WriteLine(spaceObject.Explore());
                Console.WriteLine(spaceObject.Collect());
            }
        }
    }
}
