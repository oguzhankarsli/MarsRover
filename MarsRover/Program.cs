using System;
using System.Collections.Generic;

namespace MarsRover
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the upper-right coordinates Example(5 5):");
            var upperRightsCoordinates = Console.ReadLine();
            var roverNavigator = new RoverNavigator(upperRightsCoordinates);
            var i = 0;
            var newInput = "X";
            var rovers = new List<Rover>();
            while (newInput.Equals("X")){
                i++;
                Console.WriteLine("Enter {0} corresponding to the x and y co-ordinates and the rover's orientation. Example(1 2 N):", i);
                var roverXandYCoordinatesAndOrientation = Console.ReadLine();
                Console.WriteLine("Enter {0} rover directions. Example(LMLMLMLMM):", i);
                var roverdirections = Console.ReadLine();
                
                var rover = new Rover(roverXandYCoordinatesAndOrientation, roverdirections);
                rovers.Add(rover);
                
                Console.WriteLine("Please, write X to enter new rover or write Y to complete entering rovers:");
                newInput = Console.ReadLine();
            }

            Console.WriteLine("Output: ");
            foreach (var rover in rovers) {
                roverNavigator.NavigateRover(rover);
                Console.WriteLine("{0} {1} {2}", rover.XCoordinate, rover.YCoordinate, rover.Face);
            }

            Console.ReadKey();
            
            

        }
    }
}
