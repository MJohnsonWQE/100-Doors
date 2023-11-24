using System;

namespace _100Doors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] Doors = new bool[100];
            Array.Fill(Doors, false); //FALSE IS SHUT, TRUE IS OPEN
            int x = 1;
            Console.WriteLine("Input a number of runs");
            int y = int.Parse(Console.ReadLine());
            for (int i = 0; i < y; i++) { DoorSwitch(Doors, ref x);}
        }

        public static void DoorSwitch(bool[] Doors, ref int x)
        {
            Console.Clear();
            for (int i = 0; i < 100; i++)
            {
                if (((i + 1) % x) == 0)
                {
                    if (Doors[i] == true) { Doors[i] = false;}
                    else if (Doors[i] == false) { Doors[i] = true;}
                }
                if (Doors[i] == true) { Console.WriteLine("Door {0} is Open", i + 1); } // Tells user all open doors
                //else if (Doors[i] == false) { Console.WriteLine("Door {0} is Shut", i + 1);} // Tells user all closed doors
            }
            x++;
        }
    }
}
