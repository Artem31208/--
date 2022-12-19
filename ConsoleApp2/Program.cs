using ConsoleApp2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

MountainNavigation.LetsStartNewJourney();

(int x, int y) = MountainNavigation.GetShipPosition();

int[,] map = MountainNavigation.GetThePlanetMap();

MountainNavigation.MoveTheSpaceShip(-1, -1);
MountainNavigation.MoveTheSpaceShip(-1, -1);
MountainNavigation.MoveTheSpaceShip(-1, -1);
