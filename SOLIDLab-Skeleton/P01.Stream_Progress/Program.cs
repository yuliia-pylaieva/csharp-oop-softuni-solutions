using System;

namespace P01.Stream_Progress
{
    public static class Program
    {
        private static void Main()
        {
            StreamProgressInfo fileProgress = new(new File("text.txt", 4, 100));
            Console.WriteLine(fileProgress.CalculateCurrentPercent());

            StreamProgressInfo musicProgress = new(new Music("Slipknot", "Duality", 5, 100));
            Console.WriteLine(musicProgress.CalculateCurrentPercent());

        }
    }
}
