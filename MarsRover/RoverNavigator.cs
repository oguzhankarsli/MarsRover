using System;

namespace MarsRover
{
    public class RoverNavigator
    {
        private static readonly Face[] faces = { Face.N, Face.E, Face.S, Face.W };
        public int UpperCoordinate { get; set; }
        public int RightCoordinate { get; set; }

        public RoverNavigator(string upperRightsCoordinates) {
            var upperRightsCoordinatesArray = upperRightsCoordinates.Split(' ');
            UpperCoordinate = int.Parse(upperRightsCoordinatesArray[0]);
            RightCoordinate = int.Parse(upperRightsCoordinatesArray[1]);

        }

        public void NavigateRover(Rover rover) {
            foreach (var command in rover.Directions)
            {
                switch (command)
                {
                    case Command.L:
                        rover.Face = TurnDirectionToLeft(rover.Face);
                        break;
                    case Command.R:
                        rover.Face = TurnDirectionToRight(rover.Face);
                        break;
                    case Command.M:
                        Move(rover);
                        break;
                    default:
                        break;
                }
            }
        }

        private Face TurnDirectionToLeft(Face face)
        {
            var index = Array.IndexOf(faces, face);
            return index == 0 ? faces[3] : faces[index - 1];
        }

        private Face TurnDirectionToRight(Face face)
        {
            var index = Array.IndexOf(faces, face);
            return index == 3 ? faces[0] : faces[index + 1];
        }


        private void Move(Rover rover) {
            switch (rover.Face)
            {
                case Face.N:
                    if (rover.YCoordinate < UpperCoordinate) {
                        rover.YCoordinate += 1;
                    }
                    break;
                case Face.W:
                    rover.XCoordinate -= 1;
                    break;
                case Face.S:
                    rover.YCoordinate -= 1;
                    break;
                case Face.E:
                    if (rover.XCoordinate < UpperCoordinate)
                    {
                        rover.XCoordinate += 1;
                    }
                    
                    
                    break;
                default:
                    break;
            }
        }
    }
}
