using System.IO;

namespace Program
{
    class Program
    {
        static string path = @"C:\Users\demon\Desktop\TemporaryFolder";

        public static void Main(string[] args)
        {
            GetSizeFiles(path);
        }
        public static void GetSizeFiles(string Path)
        {
            Directory.CreateDirectory(Path);
            string[] files = Directory.GetFiles(Path);

            int weight = 0;

            for (int i = 0; i < files.Length; i++)
            {
                weight += files[i].Length;
            }
            Console.WriteLine(weight);
        }
    }
}