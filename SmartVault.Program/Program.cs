using System;
using System.IO;

namespace SmartVault.Program
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                return;
            }

            WriteEveryThirdFileToFile(args[0]);
            GetAllFileSizes();
        }

        public static void GetAllFileSizes()
        {
            var files = Directory.GetFiles("..\\..\\..\\..\\SmartVault.DataGeneration\\bin\\Debug\\net5.0\\TestDoc.txt");
            long totalSize = 0;

            foreach (var file in files)
            {
                totalSize += new FileInfo(file).Length;
            }

            Console.WriteLine($"Total File Size: {totalSize} bytes");
        }

        public static void WriteEveryThirdFileToFile(string accountId)
        {
            var files = Directory.GetFiles("..\\..\\..\\..\\SmartVault.DataGeneration\\bin\\Debug\\net5.0\\TestDoc.txt");
            for (int i = 2; i < files.Length; i += 3)
            {
                var content = File.ReadAllText(files[i]);

                if (content.Contains("Smith Property"))
                {
                    var outputFileName = Path.Combine("..\\..\\..\\..\\Txt", $"{accountId}_OutputFile_{i / 3}.txt");

                    File.WriteAllText(outputFileName, content);
                }
            }
        }
    }
}