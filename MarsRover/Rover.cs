using System;
using System.Linq;

namespace MarsRover
{
    public class Rover
    {
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public Face Face { get; set; }
        public Command[] Directions {get; set;}

        public Rover(string roverXandYCoordinatesAndOrientation, string directions) {
            var coordinatesAndOrientationArray =  roverXandYCoordinatesAndOrientation.Split(' ');
            XCoordinate = int.Parse(coordinatesAndOrientationArray[0]);
            YCoordinate = int.Parse(coordinatesAndOrientationArray[1]);
            Face = (Face)Enum.Parse(typeof(Face), coordinatesAndOrientationArray[2]);
            
            Directions = directions.Select(c => (Command)Enum.Parse(typeof(Command), c.ToString()))
                                      .ToArray();
           
        }

    }
}
