using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Usage: showsize <filename>");
            return;
        }

        string filePath = args[0];
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found.");
            return;
        }

        long size = new FileInfo(filePath).Length;
        Console.WriteLine(FormatSize(size));
    }

    static string FormatSize(long bytes)
    {
        if (bytes < 1024)
            return $"{bytes} bytes";
        if (bytes < 1024 * 1024)
            return $"{bytes / 1024.0:0.#}kb";
        if (bytes < 1024 * 1024 * 1024)
            return $"{bytes / 1024.0 / 1024.0:0.#}mb";
        return $"{bytes / 1024.0 / 1024.0 / 1024.0:0.#}gb";
    }
}