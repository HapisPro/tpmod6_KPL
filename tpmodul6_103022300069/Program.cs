using System;
using tpmodul6_103022300069;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - M. Hafizh Al Kautsar");
        video.IncreasePlayCount(1000000);
        video.PrintVideoDetails();
    }
}