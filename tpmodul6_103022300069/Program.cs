using System;
using tpmodul6_103022300069;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - M. Hafizh Al Kautsar");

        video.IncreasePlayCount(10000000);
        video.PrintVideoDetails();

        for (int i = 0; i < 215; i++)
        {
            video.IncreasePlayCount(10000000);
        }

        Console.WriteLine();
        video.PrintVideoDetails();
        Console.WriteLine();

        Console.WriteLine("------Uji prekondisi");
        video.IncreasePlayCount(100000000);
    }
}
