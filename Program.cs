using System;

namespace GameOfLife
{
    public class LifeSimulation
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Conway's Game of Life!");
            bool [,] arr = new bool[20, 20];
            arr[20,20] = false;
            arr[1, 1] = true;
            Console.Write(arr);

        }
    }
}
